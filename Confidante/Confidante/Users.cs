using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confidante
{
    internal class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; } 
        public string Email { get; set; }

        private static string Error = "Apologies,An Error Has Occured !";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(Error);
        }
        public static bool IsEqual(Users user1, Users user2)
        {
            
            if (user1 == null || user2 == null) { return false; }
            if (user1.UserName != user2.UserName)
            {
                Error = "Sorry, your username doesn't exist.";
                return false;
            }

            return true;
        }

        public static bool EqualPassword(string user1, string user2)
        {
            if (user1 != user2)
            {
                Error = "Sorry, your password is incorrect.";
                return false;
            }
            return true;
        }

        public static bool UserExists(Users user1, Users user2)
        {
            if (user1 == null || user2 == null) { return false; }
            if (user1.UserName != user2.UserName)
            {
                Error = "We're sorry, this username is already in use. \n Kindly try a different one :D ";
                return false;
            }

            return true;

        }
    }
}
