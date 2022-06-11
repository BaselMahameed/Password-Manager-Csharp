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



namespace Confidante
{
    public partial class DashBoard : Form
    {
        //dotnet_diagnostic.IDE0055.severity = <severity value>
        //Fields.
        private Form ActiveForm;
        //Constructor.
        public DashBoard()
        {
            InitializeComponent();
            Default.Visible = false;

        }
        IFirebaseConfig Configeration = new FirebaseConfig()
        {
            AuthSecret = "3F35Nqi0uZa9oy6IOUZ7bWbjOAz0lIkr8EEUrIXY",
            BasePath = "https://confidante-f83b2-default-rtdb.firebaseio.com/"
        };
        //Methods.
        private void DisableButton()
        {
            foreach (Control previousBtn in PanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
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

        private void OpenForms(Form form)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
           
            ActiveForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock =DockStyle.Fill;
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;
            form.BringToFront();
            form.Show();
            Welcome.Text = form.Text;
            Default.Visible = true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        IFirebaseClient client;
        private void DashBoard_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(Configeration);
            }
            catch
            {
                MessageBox.Show("A connection problem seems to occur, please make sure you're well connected ^.^");
            }

            FirebaseResponse res = client.Get(@"Data");
            Dictionary<string, DataBase> data = JsonConvert.DeserializeObject<Dictionary<string, DataBase>>(res.Body.ToString());
            if(data != null)
            {
                RetrieveData_Enc(data);
            }
            


        }

        private void AddPass_Click(object sender, EventArgs e)
        {
            DataTable.Rows.Clear();
            OpenForms(new Forms.AddPasswords());

        }

        private void EditPass_Click(object sender, EventArgs e)
        {
            DataTable.Rows.Clear();
            OpenForms(new Forms.EditPasswords());
        }

        private void Simulate_Click(object sender, EventArgs e)
        {
            
        }

        private void Entrance_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Default_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"Data");
            Dictionary<string, DataBase> data = JsonConvert.DeserializeObject<Dictionary<string, DataBase>>(res.Body.ToString());
            RetrieveData_Enc(data);
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            Reset();
            Default.Visible = false;
        }

        private void Reset()
        {
            DisableButton();
            Welcome.Text = "Welcome To confidante";
            Entrance.BackColor = Color.FromArgb(47, 70, 107);
            Logo.BackColor = Color.FromArgb(32, 51, 84);
            AddPass.BackColor = Color.FromArgb(47, 70, 107);
            EditPass.BackColor = Color.FromArgb(47, 70, 107);
            About.BackColor = Color.FromArgb(47, 70, 107);
            Default.Visible = true;    
        }


        // DataTable Info
        private void ShowData_Click(object sender, EventArgs e)
        {

            FirebaseResponse res = client.Get(@"Data");
            Dictionary<string, DataBase> data = JsonConvert.DeserializeObject<Dictionary<string, DataBase>>(res.Body.ToString());
            OpenForms(new Forms.Validation());
            RetrieveData(data);
            

        }

        // Retrieve Decrypted Data
        void RetrieveData(Dictionary<string, DataBase> record)
        {
            DataTable.Rows.Clear();
            foreach (var item in record)
            {
                //DateTime data = DateTime.Now - item.Value.Date;

                // Insert the info into the table
                DataTable.Rows.Add(Decrypt(item.Value.WebSite), Decrypt(item.Value.Username), Decrypt(item.Value.Email), Decrypt(item.Value.Password), item.Value.Date);
            }
        }

        // Retrieve Encrypted Data
        void RetrieveData_Enc(Dictionary<string, DataBase> record)
        {
            DataTable.Rows.Clear();

            foreach (var item in record)
            {
                //DateTime data = DateTime.Now - item.Value.Date;
                DataTable.Rows.Add(item.Value.WebSite, item.Value.Username, item.Value.Email, item.Value.Password, item.Value.Date);
                
            }
            
            
            
        }

        private bool button1WasClicked = false;
        private async Task selectedCellsButton_ClickAsync(object sender, System.EventArgs e)
        {
            Int32 selectedCellCount =
                DataTable.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (DataTable.AreAllCellsSelected(true) )
                {
                    Simulate_Click_2(sender, e);
                   
                        Delete_Click(sender, e);
                    
                }
            }

        
        }
       

        private void HideData_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"Data");
            Dictionary<string, DataBase> data = JsonConvert.DeserializeObject<Dictionary<string, DataBase>>(res.Body.ToString());
            RetrieveData_Enc(data);
           
        }
        
      
        private void Simulate_Click_1(object sender, EventArgs e )
        {
          
            
        }

        private async void Delete_Click(object sender, EventArgs e)
        {

            FirebaseResponse res = client.Get(@"Data");
            Dictionary<string, DataBase> data = JsonConvert.DeserializeObject<Dictionary<string, DataBase>>(res.Body.ToString());
            
                
         }
        private bool IsClicked()
        {
            return true;
        }
        private void Simulate_Click_2(object sender, EventArgs e)
        {
          
            
            OpenForms(new Forms.SimulateLogIn());   
        }

        private void DataTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FirebaseResponse result = client.Get(@"Data");
        }

        private void About_Click(object sender, EventArgs e)
        {
            OpenForms(new Forms.About());   
        }
    }
}
