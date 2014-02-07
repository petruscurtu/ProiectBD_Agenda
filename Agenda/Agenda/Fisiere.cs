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

            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
             if (selectedRowCount == 1)
             {
                        OpenFileDialog ofd = new OpenFileDialog();
                        DialogResult dr = ofd.ShowDialog();

                        if (dr == DialogResult.OK)
                        {
                            int index = dataGridView1.CurrentRow.Index;
                            filename = ofd.FileName;
                            //apel in business layer pentru deschidere,criptare&stocare fisier
                            ManageFisiere.upload_revision(index,filename);
                            restart_window();
                        }
                        else filename = "";
             }
             else MessageBox.Show("Nu ati selectat nici o intrare.");
        }

        private void share_Click(object sender, EventArgs e)
        {
         
            Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                string fisier =dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                ManageFisiere.set_fis_selectat(fisier);
                Share s = new Share();
                s.ShowDialog();
                restart_window();
            }
            else MessageBox.Show("Nu ati selectat nici o intrare.");
        }
        
private void download_Click(object sender, EventArgs e)
         {
             Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
             if (selectedRowCount == 1)
             {
                 SaveFileDialog saveFileDialog1 = new SaveFileDialog();
 
                 saveFileDialog1.RestoreDirectory = true;
 
                 if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                 {
                     int index = dataGridView.CurrentRow.Index;
                     bool ok = ManageFisiere.download(index,saveFileDialog1.FileName);
 
                     MessageBox.Show("Fisierul a fost downloadat cu succes!");
                     //restart_window();
                 }
             }
             else MessageBox.Show("Nu ati selectat nici o intrare.");
         }
 
         private void download_extern_Click(object sender, EventArgs e)
         {
             Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
             if (selectedRowCount == 1)
             {
                 SaveFileDialog saveFileDialog1 = new SaveFileDialog();
 
                 saveFileDialog1.RestoreDirectory = true;
 
                 if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                 {
                     int index = dataGridView1.CurrentRow.Index;
                     bool ok = ManageFisiere.download_ext(index, saveFileDialog1.FileName);
 
                     MessageBox.Show("Fisierul a fost downloadat cu succes!");
                     //restart_window();
                 }
             }
             else MessageBox.Show("Nu ati selectat nici o intrare.");
         }

         private void delete_Click(object sender, EventArgs e)
         {
             Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
             
             if (selectedRowCount == 1)
             {
                 string fisier = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                 int index = dataGridView.CurrentRow.Index;
                 ManageFisiere.del_fis_selectat(fisier,index);
                 //Share s = new Share();
                 //s.ShowDialog();
                 restart_window();
             }
             else MessageBox.Show("Nu ati selectat nici o intrare.");
        }

        private void rem_access_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                string fisier = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ManageFisiere.remove_access(fisier);
                restart_window();
            }
            else MessageBox.Show("Nu ati selectat nici o intrare.");
        }
    }
}
