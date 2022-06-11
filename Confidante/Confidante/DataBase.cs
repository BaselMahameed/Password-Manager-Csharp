using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Confidante
{
    internal class DataBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public DateTime Date { get; set; }
        public string URL { get; set; }

        public static bool SimulateData(string  User, string Pass, string DataUser,string DataPass)
        {
            if(User==" " ||Pass==" "|| DataUser==" "|| DataPass==" ")
            {
                MessageBox.Show("Please Fill In Required Fields :) ");
                return false;
            }
            else if(User != DataUser || Pass != DataPass)
            {
                MessageBox.Show("We're Sorry,a field was filled miscorrectly! \n" +
                    "Kindly try again ^.^");
                return false;
            }
            return true;
        }
        
    }
}
