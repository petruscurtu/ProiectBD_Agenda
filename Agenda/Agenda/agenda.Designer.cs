namespace Agenda
{
    partial class agenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btn_add_inreg = new System.Windows.Forms.Button();
            this.lbl_ora = new System.Windows.Forms.Label();
            this.lbl_minut = new System.Windows.Forms.Label();
            this.tb_detalii = new System.Windows.Forms.RichTextBox();
            this.tb_titlu = new System.Windows.Forms.TextBox();
            this.lbl_titlu = new System.Windows.Forms.Label();
            this.cb_ora = new System.Windows.Forms.ComboBox();
            this.cb_minute = new System.Windows.Forms.ComboBox();
            this.lbl_Detalii = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_modif_inreg = new System.Windows.Forms.Button();
            this.btn_sterge_inreg = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_agenda = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereleMeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar.Location = new System.Drawing.Point(18, 33);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // btn_add_inreg
            // 
            this.btn_add_inreg.Location = new System.Drawing.Point(756, 218);
            this.btn_add_inreg.Name = "btn_add_inreg";
            this.btn_add_inreg.Size = new System.Drawing.Size(120, 23);
            this.btn_add_inreg.TabIndex = 1;
            this.btn_add_inreg.Text = "Adauga Inregistrare";
            this.btn_add_inreg.UseVisualStyleBackColor = true;
            this.btn_add_inreg.Click += new System.EventHandler(this.btn_add_inreg_click);
            // 
            // lbl_ora
            // 
            this.lbl_ora.AutoSize = true;
            this.lbl_ora.Location = new System.Drawing.Point(531, 183);
            this.lbl_ora.Name = "lbl_ora";
            this.lbl_ora.Size = new System.Drawing.Size(27, 13);
            this.lbl_ora.TabIndex = 4;
            this.lbl_ora.Text = "Ora:";
            // 
            // lbl_minut
            // 
            this.lbl_minut.AutoSize = true;
            this.lbl_minut.Location = new System.Drawing.Point(724, 183);
            this.lbl_minut.Name = "lbl_minut";
            this.lbl_minut.Size = new System.Drawing.Size(36, 13);
            this.lbl_minut.TabIndex = 5;
            this.lbl_minut.Text = "Minut:";
            // 
            // tb_detalii
            // 
            this.tb_detalii.Location = new System.Drawing.Point(467, 64);
            this.tb_detalii.MaxLength = 1000;
            this.tb_detalii.Name = "tb_detalii";
            this.tb_detalii.Size = new System.Drawing.Size(455, 96);
            this.tb_detalii.TabIndex = 6;
            this.tb_detalii.Text = "";
            // 
            // tb_titlu
            // 
            this.tb_titlu.Location = new System.Drawing.Point(467, 33);
            this.tb_titlu.MaxLength = 50;
            this.tb_titlu.Name = "tb_titlu";
            this.tb_titlu.Size = new System.Drawing.Size(459, 20);
            this.tb_titlu.TabIndex = 7;
            // 
            // lbl_titlu
            // 
            this.lbl_titlu.AutoSize = true;
            this.lbl_titlu.Location = new System.Drawing.Point(420, 36);
            this.lbl_titlu.Name = "lbl_titlu";
            this.lbl_titlu.Size = new System.Drawing.Size(30, 13);
            this.lbl_titlu.TabIndex = 8;
            this.lbl_titlu.Text = "Titlu:";
            // 
            // cb_ora
            // 
            this.cb_ora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ora.FormattingEnabled = true;
            this.cb_ora.Location = new System.Drawing.Point(579, 180);
            this.cb_ora.Name = "cb_ora";
            this.cb_ora.Size = new System.Drawing.Size(69, 21);
            this.cb_ora.Sorted = true;
            this.cb_ora.TabIndex = 9;
            // 
            // cb_minute
            // 
            this.cb_minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_minute.FormattingEnabled = true;
            this.cb_minute.Location = new System.Drawing.Point(788, 180);
            this.cb_minute.Name = "cb_minute";
            this.cb_minute.Size = new System.Drawing.Size(69, 21);
            this.cb_minute.TabIndex = 10;
            // 
            // lbl_Detalii
            // 
            this.lbl_Detalii.AutoSize = true;
            this.lbl_Detalii.Location = new System.Drawing.Point(420, 62);
            this.lbl_Detalii.Name = "lbl_Detalii";
            this.lbl_Detalii.Size = new System.Drawing.Size(39, 13);
            this.lbl_Detalii.TabIndex = 11;
            this.lbl_Detalii.Text = "Detalii:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(18, 218);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(647, 252);
            this.dataGridView.TabIndex = 12;
            // 
            // btn_modif_inreg
            // 
            this.btn_modif_inreg.Location = new System.Drawing.Point(756, 259);
            this.btn_modif_inreg.Name = "btn_modif_inreg";
            this.btn_modif_inreg.Size = new System.Drawing.Size(120, 23);
            this.btn_modif_inreg.TabIndex = 13;
            this.btn_modif_inreg.Text = "Modifica Inregisrare";
            this.btn_modif_inreg.UseVisualStyleBackColor = true;
            // 
            // btn_sterge_inreg
            // 
            this.btn_sterge_inreg.Location = new System.Drawing.Point(756, 299);
            this.btn_sterge_inreg.Name = "btn_sterge_inreg";
            this.btn_sterge_inreg.Size = new System.Drawing.Size(120, 23);
            this.btn_sterge_inreg.TabIndex = 14;
            this.btn_sterge_inreg.Text = "Sterge Inregistrare";
            this.btn_sterge_inreg.UseVisualStyleBackColor = true;
            this.btn_sterge_inreg.Click += new System.EventHandler(this.btn_sterge_inreg_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_agenda,
            this.fisiereleMeleToolStripMenuItem,
            this.despreToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_agenda
            // 
            this.menu_agenda.Name = "menu_agenda";
            this.menu_agenda.Size = new System.Drawing.Size(60, 20);
            this.menu_agenda.Text = "Agenda";
            this.menu_agenda.Click += new System.EventHandler(this.menu_agenda_click);
            // 
            // fisiereleMeleToolStripMenuItem
            // 
            this.fisiereleMeleToolStripMenuItem.Name = "fisiereleMeleToolStripMenuItem";
            this.fisiereleMeleToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.fisiereleMeleToolStripMenuItem.Text = "Fisierele mele";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.despreToolStripMenuItem.Text = "Despre";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.meniu_iesire_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Intrari in agenda:";
            // 
            // agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sterge_inreg);
            this.Controls.Add(this.btn_modif_inreg);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lbl_Detalii);
            this.Controls.Add(this.cb_minute);
            this.Controls.Add(this.cb_ora);
            this.Controls.Add(this.lbl_titlu);
            this.Controls.Add(this.tb_titlu);
            this.Controls.Add(this.tb_detalii);
            this.Controls.Add(this.lbl_minut);
            this.Controls.Add(this.lbl_ora);
            this.Controls.Add(this.btn_add_inreg);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "agenda";
            this.Text = "Agenda Electronica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btn_add_inreg;
        private System.Windows.Forms.Label lbl_ora;
        private System.Windows.Forms.Label lbl_minut;
        private System.Windows.Forms.RichTextBox tb_detalii;
        private System.Windows.Forms.TextBox tb_titlu;
        private System.Windows.Forms.Label lbl_titlu;
        private System.Windows.Forms.ComboBox cb_ora;
        private System.Windows.Forms.ComboBox cb_minute;
        private System.Windows.Forms.Label lbl_Detalii;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_modif_inreg;
        private System.Windows.Forms.Button btn_sterge_inreg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_agenda;
        private System.Windows.Forms.ToolStripMenuItem fisiereleMeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}