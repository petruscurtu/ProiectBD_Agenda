using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using DatabaseCreate;
using CrossCutting;

using System.Data.Entity.Validation;

namespace DataLayer
{

    class ManagerAgenda
    {
        public static void insert(int uid,string data_ora,string titl,string detalii)
        {
            try
            {
                using (var db = new AgendaDBContext())
                {
                    // Preiau userul logat ca sa il pot adauga in clasa Agenda pentru ca...
                    var query = from u in db.Users
                                select u;
                    Users us_logat = null;
                    foreach (var user in query)
                    {
                        if (user.UserId == uid)
                            us_logat = user;
                    }

                    int agid = DatabaseManagement.get_next_agenda_id();
                    DatabaseCreate.Agenda a = new DatabaseCreate.Agenda { Id = agid, UserId = uid,data_si_ora= Convert.ToDateTime(data_ora), titlu = titl, notita = detalii,Users=us_logat };
                    db.Agenda.Add(a);
                    db.SaveChanges();
                    DatabaseManagement.increment_next_agenda_id();
                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //MessageBox.Show("Eroare la inserare in agenda!");
            //}

            catch (DbEntityValidationException e)
            {
                string err = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    err += "Entity of type " + Convert.ToString(eve.Entry.Entity.GetType().Name) + " in state " + Convert.ToString(eve.Entry.State) + " has the following validation errors:\n\n";

                    foreach (var ve in eve.ValidationErrors)
                    {
                        err += "- Property: " + Convert.ToString(ve.PropertyName) + ", Error: " + Convert.ToString(ve.ErrorMessage) + "\n";

                    }
                }
                MessageBox.Show(err);

            }
        }

        public static DataTable get_agenda_for_uid(int uid)
        {
            try
            {
                DataTable dt = new DataTable();
                
                using (var db = new AgendaDBContext())
                {
                    var query = (from a in db.Agenda
                                 where a.UserId == uid
                                 select new {Id_intrare=a.Id, a.data_si_ora , Titlu=a.titlu, Detalii=a.notita }
                                 ).ToList();
                
                // Am facut conversia in tabel aici (in datalayer) pentru ca nu se poate returna o lista anonima de tipul query...

                
                dt.Columns.Add().ColumnName="Id_intrare";
                dt.Columns.Add().ColumnName = "Data";
                dt.Columns.Add().ColumnName = "Ora";
                dt.Columns.Add().ColumnName = "Titlu";
                dt.Columns.Add().ColumnName = "Detalii";

                string ora = "";
                string data = "";

                foreach (var item in query)
                {
                    string[] words = Convert.ToString(item.data_si_ora).Split(' ');
                    data = words[0];
                    ora = words[1];
                    dt.Rows.Add(item.Id_intrare, data, ora, item.Titlu, item.Detalii);
                    
                }
                

                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Eroare", MessageBoxButtons.OK);
                return null;
            }
        }
    }

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
