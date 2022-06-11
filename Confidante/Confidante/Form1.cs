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

namespace Confidante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        IFirebaseConfig Configeration = new FirebaseConfig()
        {
            AuthSecret = "3F35Nqi0uZa9oy6IOUZ7bWbjOAz0lIkr8EEUrIXY",
            BasePath = "https://confidante-f83b2-default-rtdb.firebaseio.com/"
        };

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PasswordLogBox.PasswordChar == '*')
            {
                button1.BringToFront();
                PasswordLogBox.PasswordChar = '\0';
            }
            else if (PasswordLogBox.PasswordChar != '*')
            {
                button1.BringToFront();
                PasswordLogBox.PasswordChar = '*';
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        // AES Algorithm Decryption
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

        private void button2_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(UserNameLogBox.Text) &&
                string.IsNullOrWhiteSpace(PasswordLogBox.Text)) MessageBox.Show("Please fill all fields ^.^");
            #endregion

            FirebaseResponse Res = client.Get(@"Users/" + UserNameLogBox.Text);
            Users ResultUser = Res.ResultAs<Users>(); // Data Result.
            Users CurrentUser = new Users()
            {
                UserName = UserNameLogBox.Text,
                Password = PasswordLogBox.Text,
            };

            string DecPassword = Decrypt(ResultUser.Password);
            string CurrPassword = CurrentUser.Password;

            if (Users.IsEqual(ResultUser, CurrentUser))
            {
               
                if (Users.EqualPassword(DecPassword, CurrPassword))
                {
                    this.Hide(); //Hides Log in page ^.^
                    DashBoard dash = new DashBoard();
                    dash.Show();
                }
            }
            else
            {
                Users.ShowError();
            }
           
        }

        IFirebaseClient client;
        private void Form1_Load(object sender, EventArgs e)
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
    }
}
