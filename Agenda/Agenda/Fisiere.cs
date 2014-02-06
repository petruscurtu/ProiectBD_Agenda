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
        string filename = "";
        public Fisiere()
        {
            InitializeComponent();
            ManageFisiere.get_dvs();
            show_gridviewData();
        }

        private void show_gridviewData()
        {
            
            dataGridView.DataSource = ManageFisiere.dv_fisiere_proprii;
            dataGridView1.DataSource = ManageFisiere.dv_fisiere_externe;
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filename = ofd.FileName;
                //apel in business layer pentru deschidere,criptare&stocare fisier
                ManageFisiere.upload_fisier(filename);
                restart_window();
            }
            else filename = "";
        }

        private void upload_revision_click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filename = ofd.FileName;
                //apel in business layer pentru deschidere,criptare&stocare fisier
                restart_window();
            }
            else filename = "";
        }
    }
}
