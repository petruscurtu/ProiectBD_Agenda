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

namespace Agenda
{
    public partial class Share : Form
    {
        public Share()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string fis_selectat = ManageFisiere.get_fis_selectat();
            ManageFisiere.share(username, fis_selectat);
            this.Visible = false;
            this.Close();
        }
    }
}
