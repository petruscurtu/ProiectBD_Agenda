using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using CrossCutting;

namespace Agenda
{
    public partial class agenda : Form
    {
        string[] ore;
        string[] minute;
        public agenda()
        {
            InitializeComponent();
            initializare_proprie();
            set_default_values();
            show_calendar_entries();
        }

        private void show_calendar_entries()
        {
            
            foreach (DataRow dr in ManageAgenda.intrari_agenda.Rows)
            {
                DateTime ev = Convert.ToDateTime(dr["Data"]);
                
                monthCalendar.AddBoldedDate(ev);

            }
        }

        private void btn_add_inreg_click(object sender, EventArgs e)
        {
            string data = monthCalendar.SelectionRange.Start.ToShortDateString();
            string s2 = monthCalendar.SelectionRange.Start.ToShortTimeString();
            if (String.Compare("", tb_titlu.Text) == 0)
            {
                MessageBox.Show("Trebuie sa puneti un titlu inregistrarii!");
                return;
            }
            ManageAgenda.add_inregistrare(data, cb_ora.Text, cb_minute.Text, tb_titlu.Text, tb_detalii.Text);
            restart_window();
        }

        private void initializare_proprie()
        {
            ore = new string[24];
            for (int i = 0; i < 24; i++)
            {
                if (i < 10) ore[i] += "0";
                ore[i] += Convert.ToString(i);
            }
            cb_ora.DataSource = ore;

            minute = new string[60];
            for (int i = 0; i < 60; i++)
            {
                if (i < 10) minute[i] += "0";
                minute[i] += Convert.ToString(i);
            }
            cb_minute.DataSource = minute;
        }

        private void set_default_values()
        {
            tb_titlu.Text = "";
            tb_detalii.Text = "";
            cb_ora.Text = "00";
            cb_minute.Text = "00";

        }

        private void restart_window()
        {
            this.Visible = false;
            agenda a = new agenda();
            a.ShowDialog();
            this.Close();
        }

        private void menu_agenda_click(object sender, EventArgs e)
        {
            restart_window();         
            
        }

        private void meniu_iesire_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
