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
    public partial class Validation : Form
    {
        public Validation()
        {
            InitializeComponent();
        }

        IFirebaseConfig Configeration = new FirebaseConfig()
        {
            AuthSecret = "3F35Nqi0uZa9oy6IOUZ7bWbjOAz0lIkr8EEUrIXY",
            BasePath = "https://confidante-f83b2-default-rtdb.firebaseio.com/"
        };

        public string ReturnValue { get; set; }

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

        private void Submit_Click(object sender, EventArgs e)
        {



            FirebaseResponse result = client.Get(@"Users\" + FillUser.Text);
            Users usr = result.ResultAs<Users>();
            Users CurrentUser = new Users()
            {
                Password = FillPass.Text,
            };

            string DecPassword = Decrypt(usr.Password);
            
            if (CurrentUser.Password == DecPassword)
            {
                this.ReturnValue = "Valid";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
               MessageBox.Show("Not sorry, Invalid password.\nIf you are trying to steal the passwords: No no no !!\nIf this IS you, Kindly try again ^_^");
                FillUser.Text = " ";
                FillPass.Text = " ";
            }


        }

        IFirebaseClient client;
        private void Validation_Load(object sender, EventArgs e)
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
            if (FillPass.PasswordChar == '*')
            {
                button1.BringToFront();
                FillPass.PasswordChar = '\0';
            }
            else if (FillPass.PasswordChar != '*')
            {
                button1.BringToFront();
                FillPass.PasswordChar = '*';
            }
        }
    }
}
