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
    public partial class Fisiere : Form
    {
        public Fisiere()
        {
            InitializeComponent();
        }

        private void restart_window()
        {
            this.Visible = false;
            Fisiere a = new Fisiere();
            a.ShowDialog();
            this.Close();
        }

        private void menu_agenda_click(object sender, EventArgs e)
        {
            //restart_window();
            this.Visible = false;
            agenda a = new agenda();
            a.ShowDialog();
            this.Close();
        }

        private void fisiereleMeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //Fisiere a = new Fisiere();
            //a.ShowDialog();
            //this.Close();
            //Face ceva??
        }


        private void meniu_iesire_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
