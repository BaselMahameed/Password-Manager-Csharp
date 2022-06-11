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
    public partial class AddPasswords : Form

    {
        public static int DataID = 0;
        public AddPasswords()
        {
            InitializeComponent();
            LoadTheme();
        }

        IFirebaseConfig Configeration = new FirebaseConfig()
        {
            AuthSecret = "3F35Nqi0uZa9oy6IOUZ7bWbjOAz0lIkr8EEUrIXY",
            BasePath = "https://confidante-f83b2-default-rtdb.firebaseio.com/"
        };

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn= (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
           

        }

        // AES Algorithm Encryption
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FillPass_TextChanged(object sender, EventArgs e)
        {

        }

        IFirebaseClient client;

        private void AddPasswords_Load(object sender, EventArgs e)
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

        private void Add_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(FillUser.Text) &&
                string.IsNullOrWhiteSpace(FillPass.Text) &&
                string.IsNullOrWhiteSpace(FillEmail.Text)&&
                string.IsNullOrWhiteSpace(FillURL.Text)&&
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


                SetResponse set = client.Set(@"Data/" + FillUser.Text, Data);
                MessageBox.Show("Your Data has been successfuly added ! ^.^ ");
                DataID++;
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

        private void BackGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (FillPass.PasswordChar == '*')
            {
                HideShow.BringToFront();
                FillPass.PasswordChar = '\0';
            }
            else if (FillPass.PasswordChar != '*')
            {
                HideShow.BringToFront();
                FillPass.PasswordChar = '*';
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {

            if (FillPass.PasswordChar == '*')
            {
                HideShow.BringToFront();
                FillPass.PasswordChar = '\0';
            }

            int MinLength = 8;
            int MaxLength = 15;

            
            string Available = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDGHJKLZXCVBNM,<.</?'][}{|)(*&^%$#@!`~1234567890";


            StringBuilder Password = new StringBuilder();
            Random random = new Random();

            int PasswordLength = random.Next(MinLength, MaxLength+1);
            while(PasswordLength-- > 0)
            {
                Password.Append(Available[random.Next(Available.Length)]);


            }

            FillPass.Text=Password.ToString();

        }
    }
}
