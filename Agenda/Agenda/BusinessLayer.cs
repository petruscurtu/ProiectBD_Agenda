using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataLayer;

namespace BusinessLayer
{
    class ManageUsers
    {
        public static bool insert(string username, string passwd1, string passwd2)
        {
            if (passwd1 != passwd2)
            {
                MessageBox.Show("Passwords do not match", "Eroare", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                DataLayer.ManageUsers.insert(username, passwd1);
                return true;
            }
        }
    }
}
