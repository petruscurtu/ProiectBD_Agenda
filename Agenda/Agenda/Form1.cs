using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.Diagnostics;

using DatabaseCreate;
using CrossCutting;
using BusinessLayer;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init_Database();
        }

        private void Init_Database()
        {
            using (var db = new AgendaDBContext())
            {
                //var user = new Users { UserId = 1, Username = "Scurtu", Password = "Petru" };
                //db.Users.Add(user);
                //db.SaveChanges();
                //IO_on_Db.write_users_table();
                //user = new Users { UserId = 2, Username = "Iordache", Password = "George" };
                //db.Users.Add(user);
                //db.SaveChanges();
                //var query = from u in db.Users
                //            select u;
                //foreach (var item in query)
                //{
                //    MessageBox.Show(item.Username + item.Password, "info", MessageBoxButtons.OK);
                //}
                IEnumerable<int> id = (from u in db.Users
                                        select u.UserId);
                int max;
                if (id.Count() != 0)
                    max = id.Max();
                else
                {
                    max = 0;
                    DatabaseManagement.set_next_agenda_id(max);
                    IO_on_Db.read_users_table();
                    
                }
                //MessageBox.Show(max.ToString());
                DatabaseManagement.set_next_user_id(max);
                id = (from u in db.Agenda
                                         select u.Id);
                if (id.Count() != 0)
                    max = id.Max();
                else
                    max = 0;
                //MessageBox.Show(max.ToString());
                DatabaseManagement.set_next_agenda_id(max);

                id = from u in db.Fisiere select u.FisierId;
                if (id.Count() != 0)
                    max = id.Max();
                else
                    max = 0;
                DatabaseManagement.set_next_fisier_id(max);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string passwd = PasswordBox.Text;
            bool x = Login.verify(username, passwd);
            if (x)
            {
                //MessageBox.Show("Succes ");
                //ManageAgenda.get_datatable();
                this.Visible = false;
                agenda a = new agenda();
                a.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Numele sau parola sunt gresite.\nReincercati");
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewAccount a = new NewAccount();
            a.ShowDialog();
            this.Close();
        }

    }
}
