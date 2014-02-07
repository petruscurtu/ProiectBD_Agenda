using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.Data;

using DataLayer;

using System;
using System.IO;


namespace BusinessLayer
{
    class ManageFisiere
    {
        public static DataView dv_fisiere_proprii;
        public static DataView dv_fisiere_externe;
        static DataTable t_fis_proprii;
        static DataTable t_fis_externe;
        static string fis_selectat;

        public static void get_dvs()
        {
            
            t_fis_proprii = ManagerFisiere.get_fisiere_pr(ManageAgenda.get_userid());
            DataView view = new DataView(t_fis_proprii);
            DataTable table2 = view.ToTable("proprii", false, "Nume_Fisier", "Data_si_Ora");  //view.ToTable("Nume_Fisier", "Data_si_Ora", "ShareList");
            dv_fisiere_proprii = new DataView(table2);

            t_fis_externe = ManagerFisiere.get_fisiere_ext(ManageAgenda.get_userid());
            view = new DataView(t_fis_externe);
            DataTable table3 = view.ToTable("shared", false, "Nume_Fisier", "Owner", "Data_si_Ora");
            dv_fisiere_externe = new DataView(table3);


        }


        public static void upload_fisier(string filename)
        {
            string nume_criptat = criptare_fis(filename);
            string[] words = filename.Split('\\');
            string filename2 = words[words.Length - 1];
            words = nume_criptat.Split('\\');
            string nume_criptat2 = words[words.Length - 1];
            ManagerFisiere.insert(ManageAgenda.get_userid(), DateTime.Now.ToString(), filename2, nume_criptat2);
        }

        public static bool download(int index,string filename)
        {
            DataRow dr = t_fis_proprii.Rows[index];

            string cript = dr["Nume_Criptat"].ToString();

            decriptare_fisier(cript, filename);

            //MessageBox.Show(filename);

            return true;
        }

        public static bool download_ext(int index, string filename)
        {
            DataRow dr = t_fis_externe.Rows[index];

            string cript = dr["Nume_Criptat"].ToString();

            decriptare_fisier(cript, filename);

            //MessageBox.Show(filename);

            return true;
        }

        private static void decriptare_fisier(string cript, string decript)
        {
            string pathOld = @".\data\" + cript;


            using (FileStream fsSource = new FileStream(pathOld,
            FileMode.Open, FileAccess.Read))
            {

                // Read the source file into a byte array. 
                byte[] bytes = new byte[fsSource.Length];
                //byte r=15;
                int numBytesToRead = (int)fsSource.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    // Read may return anything from 0 to numBytesToRead. 
                    int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                    // Break when the end of the file is reached. 
                    if (n == 0)
                        break;

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = bytes.Length;
                for (int i = 0; i < numBytesToRead; i++) bytes[i] = (byte)(bytes[i] ^ 'r');

                Directory.CreateDirectory(Path.GetDirectoryName(decript));

                using (FileStream fsNew = new FileStream(decript,
                FileMode.Create, FileAccess.Write))
                {
                    fsNew.Write(bytes, 0, numBytesToRead);
                }

                //MessageBox.Show("a mers decriptarea??");

            }


        }

        private static string criptare_fis(string filename)
        {

            string pathNew = @".\data\aaa";
            string data = DateTime.Now.ToString();
            string[] words;
            words = data.Split(' ', '.', ':');
            foreach (string word in words)
                pathNew = pathNew + word;
            // pathNew=pathNew+".txt";


            using (FileStream fsSource = new FileStream(filename,
            FileMode.Open, FileAccess.Read))
            {

                // Read the source file into a byte array. 
                byte[] bytes = new byte[fsSource.Length];
                //byte r=15;
                int numBytesToRead = (int)fsSource.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    // Read may return anything from 0 to numBytesToRead. 
                    int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                    // Break when the end of the file is reached. 
                    if (n == 0)
                        break;

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = bytes.Length;
                for (int i = 0; i < numBytesToRead; i++) bytes[i] = (byte)(bytes[i] ^ 'r');

                Directory.CreateDirectory(Path.GetDirectoryName(pathNew));

                using (FileStream fsNew = new FileStream(pathNew,
                FileMode.Create, FileAccess.Write))
                {
                    fsNew.Write(bytes, 0, numBytesToRead);
                }

                //MessageBox.Show("a mers criptarea??");

            }
            return pathNew;
        }

        public static void set_fis_selectat(string fisid)
        {
            fis_selectat = fisid;
        }

        public static string get_fis_selectat()
        {
            return fis_selectat;
        }

        public static void share(string username, string fis_nume)
        {
            ManagerFisiere.share(username, fis_nume);
        }

    }

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

        public static void update(int index, string data, string ora, string minut, string titlu, string detalii)
        {
            ManagerAgenda.updated(userid_logat, index, data + " " + ora + ":" + minut, titlu, detalii);
        }

        public static void del_inregistrare(int ind)
        {
            ManagerAgenda.delete(ind);
        }

        public static string get_titlu(int ind)
        {
            for (int i = 0; i < intrari_agenda.Rows.Count; i++)
            {
                if (Convert.ToInt32(intrari_agenda.Rows[i].ItemArray[0]) == ind)
                    return intrari_agenda.Rows[i].ItemArray[3].ToString();
            }
            return null;
        }

        public static string get_detalii(int ind)
        {
            for (int i = 0; i < intrari_agenda.Rows.Count; i++)
            {
                if (Convert.ToInt32(intrari_agenda.Rows[i].ItemArray[0]) == ind)
                    return intrari_agenda.Rows[i].ItemArray[4].ToString();
            }
            return null;
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
