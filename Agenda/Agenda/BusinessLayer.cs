using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.Data;

using DataLayer;

namespace BusinessLayer
{
    class ManageUsers
    {
        public static bool insert(string username, string passwd1, string passwd2)
        {
            string passwd3 = criptare_pass(passwd1);
            if (passwd1 != passwd2)
            {
                MessageBox.Show("Passwords do not match", "Eroare", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                DataLayer.ManageUsers.insert(username, passwd3);
                return true;
            }
        }

        public static string criptare_pass(string pass)        //criptare triviala. voi modifica cand va fi nevoie
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(pass);
            data = x.ComputeHash(data);
            String md5Hash = System.Text.Encoding.ASCII.GetString(data);
            int nr = md5Hash.Length;

            return md5Hash;
        }
    }
}
