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
        bool modif = true;
        public agenda()
        {
            
            InitializeComponent();
            initializare_proprie();
            set_default_values();
            show_calendar_entries();
            button1.Hide();
            button2.Hide();
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

            ManageAgenda.get_datatable();
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

        private void fisiereleMeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Fisiere a = new Fisiere();
            a.ShowDialog();
            this.Close();
        }


        private void meniu_iesire_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {    
            if(modif)
                ManageAgenda.set_rowfilter(e.Start.ToShortDateString());
                        
            dataGridView.DataSource = ManageAgenda.intrari_zilnice;
        }

        private void btn_sterge_inreg_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                int index = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                ManageAgenda.del_inregistrare(index);
                restart_window();
            }
            else MessageBox.Show("Nu ati selectat nici o intrare.");
        }

        private void btn_modif_inreg_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                button1.Show();
                button2.Show();
                int index = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                tb_titlu.Text = ManageAgenda.get_titlu(index);
                tb_detalii.Text = ManageAgenda.get_detalii(index);
                modif = false;
                btn_add_inreg.Hide();
                btn_sterge_inreg.Hide();
                btn_modif_inreg.Hide();
            }
            else MessageBox.Show("Nu ati selectat nici o intrare.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //salveaza modificarea
            int index = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            string data = monthCalendar.SelectionRange.Start.ToShortDateString();
            if (String.Compare("", tb_titlu.Text) == 0)
            {
                MessageBox.Show("Trebuie sa puneti un titlu inregistrarii!");
                return;
            }
            ManageAgenda.update(index, data, cb_ora.Text, cb_minute.Text, tb_titlu.Text, tb_detalii.Text);
            restart_window();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //anuleaza modificarea
            button1.Hide();
            button2.Hide();
            tb_titlu.Text = "";
            tb_detalii.Text = "";
            modif = true;
            btn_add_inreg.Show();
            btn_sterge_inreg.Show();
            btn_modif_inreg.Show();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Despre d = new Despre();
            d.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

       
    }
}
