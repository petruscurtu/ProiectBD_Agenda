using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DatabaseCreate;

namespace CrossCutting
{
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
                        if (user.Username == username && user.Password == password)
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
