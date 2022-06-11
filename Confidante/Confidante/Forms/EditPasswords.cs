using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Security.Cryptography;
using System.IO;

namespace Confidante.Forms
{
    public partial class EditPasswords : Form
    {
        public static int DataID;
        public EditPasswords()
        {
            InitializeComponent();
        }

        IFirebaseConfig Configeration = new FirebaseConfig()
        {
            AuthSecret = "3F35Nqi0uZa9oy6IOUZ7bWbjOAz0lIkr8EEUrIXY",
            BasePath = "https://confidante-f83b2-default-rtdb.firebaseio.com/"
        };

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        private string Decrypt(string cipherText)
        {

            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;


        }

        private void Save_Click(object sender, EventArgs e)
        {

            #region Condition
            if (string.IsNullOrWhiteSpace(FillUser.Text) &&
                string.IsNullOrWhiteSpace(FillPass.Text) &&
                string.IsNullOrWhiteSpace(FillEmail.Text) &&
                string.IsNullOrWhiteSpace(FillURL.Text) &&
                string.IsNullOrWhiteSpace(FillWebName.Text)) MessageBox.Show("Please fill all required fields ^.^");
            #endregion

            if (FillPass.Text.Length >= 8 && (FillPass.Text.Any(char.IsLower)) && (FillPass.Text.Any(char.IsUpper)) && (FillPass.Text.Any(char.IsDigit)))
            {
                DataBase Data = new DataBase()
                {
                    Username = Encrypt(FillUser.Text.Trim()),
                    Password = Encrypt(FillPass.Text.Trim()),
                    WebSite = Encrypt(FillWebName.Text.Trim()),
                    URL = FillURL.Text,
                    Email = Encrypt(FillEmail.Text.Trim()),
                    Date = DateTime.Now
                };


                var set = client.Update(@"Data/" + FillUser.Text, Data);
                MessageBox.Show("Your Data has been successfuly updated ! ^.^ ");

                FillEmail.Text = " ";
                FillPass.Text = " ";
                FillURL.Text = " ";
                FillUser.Text = " ";
                FillWebName.Text = " ";
            }
            else
            {
                MessageBox.Show("Your password is too weak :( ! \n " +
                    "Please make sure your password contains all of the following: \n" +
                    "1.Capital & small letters! \n" +
                    "2. At least one digit is a number. \n" +
                    "3.The password must be at least 8 digits. \n" +
                    "(It's for your own safety, we promise! ^_^) \n");

                FillPass.Text = " ";

            }

        }

        private void DataList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowHide_Click(object sender, EventArgs e)
        {

         
            if (FillPass.PasswordChar == '*')
            {
                ShowHide.BringToFront();
                FillPass.PasswordChar = '\0';
            }
            else if (FillPass.PasswordChar != '*')
            {
                ShowHide.BringToFront();
                FillPass.PasswordChar = '*';
            }
        }

        private void BackGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectData_Click(object sender, EventArgs e)
        {
            // Validation Form
            Validation valid = new Validation();
            var Valid_Result = valid.ShowDialog();
            if(Valid_Result == DialogResult.OK)
            {
                FirebaseResponse result = client.Get(@"Data/" + FillUser.Text);
                DataBase std = result.ResultAs<DataBase>();

                string DecPassword = Decrypt(std.Password);
                string DecEmail = Decrypt(std.Email);
                string DecWebSite = Decrypt(std.WebSite);


                FillPass.Text = DecPassword;
                FillURL.Text = std.URL;
                FillWebName.Text = DecWebSite;
                FillEmail.Text = DecEmail;

            }

            
        }

        

        IFirebaseClient client;
        private void EditPasswords_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(Configeration);
            }
            catch
            {
                MessageBox.Show("A connection problem seems to occur, please make sure you're well connected ^.^");
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (FillPass.PasswordChar == '*')
            {
                ShowHide.BringToFront();
                FillPass.PasswordChar = '\0';
            }

            int MinLength = 8;
            int MaxLength = 15;


            string Available = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDGHJKLZXCVBNM,<.</?'][}{|)(*&^%$#@!`~1234567890";


            StringBuilder Password = new StringBuilder();
            Random random = new Random();

            int PasswordLength = random.Next(MinLength, MaxLength + 1);
            while (PasswordLength-- > 0)
            {
                Password.Append(Available[random.Next(Available.Length)]);


            }

            FillPass.Text = Password.ToString();
        }
    }
}
