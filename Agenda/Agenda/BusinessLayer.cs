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
    class ManageAgenda
    {
        static int userid_logat;
        public static DataTable intrari_agenda;
        public static DataView intrari_zilnice;

        public static void set_userid(int id)
        {
            userid_logat = id;
        }

        public static int get_userid()
        {
            return userid_logat;
        }

        public static void set_rowfilter(string s)
        {
            intrari_zilnice.RowFilter = String.Format("Data = '{0}'", s);
        }

        public static void get_datatable()
        {
            intrari_agenda = ManagerAgenda.get_agenda_for_uid(userid_logat);
            intrari_zilnice = new DataView(intrari_agenda);
        }

        public static void add_inregistrare(string data,string ora,string minut,string titlu,string detalii)
        {

            ManagerAgenda.insert(userid_logat, data + " " + ora + ":" + minut, titlu, detalii);
        }

        public static void del_inregistrare(int ind)
        {
            ManagerAgenda.delete(ind);
        }
    }

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
