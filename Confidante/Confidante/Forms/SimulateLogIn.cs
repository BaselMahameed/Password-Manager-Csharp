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
using Newtonsoft.Json;

namespace Confidante.Forms
{
    public partial class SimulateLogIn : Form
    {
        public SimulateLogIn()
        {
            InitializeComponent();
        }

        IFirebaseConfig Configeration = new FirebaseConfig()
        {
            AuthSecret = "3F35Nqi0uZa9oy6IOUZ7bWbjOAz0lIkr8EEUrIXY",
            BasePath = "https://confidante-f83b2-default-rtdb.firebaseio.com/"
        };

        private void Pass_Click(object sender, EventArgs e)
        {

        }
        IFirebaseClient client;
        private string Decrypt(string cipherText)
        {
            if(cipherText == null)
            {
                return "There Wasn't any data :( ";
            } 
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

            FirebaseResponse result = client.Get(@"Data/" + FillUser.Text);
            DataBase ResultUser = result.ResultAs<DataBase>(); // Data Result.
            DataBase CurrentUser = new DataBase()
            {
                Username = FillUser.Text,
                Password = FillPass.Text,
            };
            
            if(ResultUser == null)
            {
                MessageBox.Show("You've Inserted Incorrect Information ! \n");
                FillUser.Text = " ";
                FillPass.Text = " ";
            }
            else
            {
                string DecUser = Decrypt(ResultUser.Username);
                string DecPassword = Decrypt(ResultUser.Password);
                string CurrPassword = CurrentUser.Password;
                string CurrUser = CurrentUser.Username;

                if (DataBase.SimulateData(CurrUser, CurrPassword, DecUser, DecPassword))
                {
                    MessageBox.Show("You've Inserted Correct Information ! \n ^.^");
                    FillUser.Text = " ";
                    FillPass.Text = " ";


                }

            }
                


                
           
            
                
            
            

        }

        private void SimulateLogIn_Load(object sender, EventArgs e)
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
