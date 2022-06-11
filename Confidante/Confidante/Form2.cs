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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        IFirebaseConfig Configeration = new FirebaseConfig()
        {
            AuthSecret = "3F35Nqi0uZa9oy6IOUZ7bWbjOAz0lIkr8EEUrIXY",
            BasePath = "https://confidante-f83b2-default-rtdb.firebaseio.com/"
        };


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(UserNameBox.Text) &&
                string.IsNullOrWhiteSpace(PasswordBox.Text) &&
                string.IsNullOrWhiteSpace(EmailBox.Text)) MessageBox.Show("Please fill all registeration fields ^.^");
            #endregion

            FirebaseResponse Res = client.Get(@"Users/" + UserNameBox.Text);
            Users ResultUser = Res.ResultAs<Users>(); // Data Result.

            if (PasswordBox.Text.Length >= 8 && (PasswordBox.Text.Any(char.IsLower)) && (PasswordBox.Text.Any(char.IsUpper)) && (PasswordBox.Text.Any(char.IsDigit)))
            {
                Users user = new Users()
                {
                    UserName = UserNameBox.Text,
                    Password = Encrypt(PasswordBox.Text.Trim()),
                    Email = EmailBox.Text,

                };

                if (!(Users.UserExists(user, ResultUser)))
                {

                    SetResponse set = client.Set(@"Users/" + UserNameBox.Text, user);

                    MessageBox.Show("You've been successfuly registered ! ^.^ ");

                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }

                else
                {
                    Users.ShowError();
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Your password is too weak :( ! \n " +
                    "Please make sure your password contains all of the following: \n" +
                    "1.Capital & small letters! \n" +
                    "2. At least one digit is a number. \n" +
                    "3.The password must be at least 8 digits. \n" +
                    "(It's for your own safety, we promise! ^_^) \n");

                this.Hide();
                Form2 form = new Form2();
                form.ShowDialog();
            }



        }
        IFirebaseClient client;
        private void Form2_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (PasswordBox.PasswordChar == '*')
            {
                button1.BringToFront();
                PasswordBox.PasswordChar = '\0';
            }
            else if (PasswordBox.PasswordChar != '*')
            {
                button1.BringToFront();
                PasswordBox.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
