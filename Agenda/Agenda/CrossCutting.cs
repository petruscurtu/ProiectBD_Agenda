using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Text;

using DatabaseCreate;
using BusinessLayer;

namespace CrossCutting
{

    public class IO_on_Db
    {
        public static void write_users_table()      //apelat de cate ori se face o modificare asupra tabelei de useri
        {
            try
            {
                using (var db = new AgendaDBContext())
                {
                    //creez un tabel in care scriu datele din tabelul de useri!

                    DataTable dt = new DataTable("useri");
                    DataColumn cUserID = new DataColumn("UserId");
                    cUserID.DataType = typeof(int);
                    dt.Columns.Add(cUserID);
                    DataColumn cUsername = new DataColumn("Username");
                    cUsername.DataType = typeof(string);
                    dt.Columns.Add(cUsername);
                    DataColumn cPassword = new DataColumn("Password");
                    cPassword.DataType = typeof(string);
                    dt.Columns.Add(cPassword);

                    //adaug randurile din tabelul de useri
                   
                    var query = from u in db.Users
                                select u;
                    foreach (var user in query)
                    {
                        dt.Rows.Add(user.UserId, user.Username, user.Password);
                    }

                    //scriu tabelul intr-un fisier .xml
                    dt.WriteXml("users.xml");

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Eroare la scriere xml useri", MessageBoxButtons.OK);
            }
        }

        public static void read_users_table()       //apelat cand se initializeaza aplicatia iar lista de useri este GOALA (sau de fiecare data cand se deschide aplicatia... trebuie hotarat
        {

            try
            {
                using (var db = new AgendaDBContext())
                {
                    //creez un tabel in care citesc datele din tabelul de useri!

                    DataTable dt = new DataTable("useri");
                    DataColumn cUserID = new DataColumn("UserId");
                    cUserID.DataType = typeof(int);
                    dt.Columns.Add(cUserID);
                    DataColumn cUsername = new DataColumn("Username");
                    cUsername.DataType = typeof(string);
                    dt.Columns.Add(cUsername);
                    DataColumn cPassword = new DataColumn("Password");
                    cPassword.DataType = typeof(string);
                    dt.Columns.Add(cPassword);

                    //citesc tabelul intr-un fisier .xml
                    dt.ReadXml("users.xml");

                    //adaug randurile din tabelul de useri

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var user = new Users { UserId = Convert.ToInt32(dt.Rows[i][0]), Username = Convert.ToString(dt.Rows[i][1]), Password = Convert.ToString(dt.Rows[i][2]) };
                        db.Users.Add(user);
                        
                    }
                    db.SaveChanges();
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Eroare la scriere xml useri", MessageBoxButtons.OK);
            }

        }
    }

    public class Login
    {
        public static bool verify(string username, string password)
        {
            try
            {
                using (var db = new AgendaDBContext())
                {
                    var query = from u in db.Users
                                select u;
                    foreach (var user in query)
                    {
                        if (user.Username == username && user.Password == ManageUsers.criptare_pass(password))
                            return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public class UserManagement
    {
        static int userid;

        public static void set_current_user(int userid)
        {
            UserManagement.userid=userid;
        }

       public static int get_current_user()
        {
            return userid;
        }
    }

    public class DatabaseManagement
    {
        static int next_user_id;
        static int next_agenda_id;

        public static  void set_next_user_id(int max_userid)
        {
            next_user_id = max_userid + 1;
        }

        public static void set_next_agenda_id(int max_agendaid)
        {
            next_agenda_id = max_agendaid + 1;
        }

        public static void increment_next_user_id()
        {
            next_user_id++;
        }

        public static void increment_next_agenda_id()
        {
            next_agenda_id++;
        }

        public static int get_next_user_id()
        {
            return next_user_id;
        }

        public static int get_next_agenda_id()
        {
            return next_agenda_id;
        }
    }
}
