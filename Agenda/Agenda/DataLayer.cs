using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DatabaseCreate;
using CrossCutting;

namespace DataLayer
{

    

    class ManageUsers
    {
        public static void insert(string username,string password)
        {
            try
            {
                using (var db = new AgendaDBContext())
                {
                    int userid = DatabaseManagement.get_next_user_id();
                    Users u = new Users { Username = username, Password = password, UserId = userid };
                    db.Users.Add(u);
                    db.SaveChanges();
                    DatabaseManagement.increment_next_user_id();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Eroare", MessageBoxButtons.OK);
            }
        }
    }
}
