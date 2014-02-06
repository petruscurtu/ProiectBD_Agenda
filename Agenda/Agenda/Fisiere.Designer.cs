namespace Agenda
{
    partial class Fisiere
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_agenda = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereleMeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.share = new System.Windows.Forms.Button();
            this.download_extern = new System.Windows.Forms.Button();
            this.upl_revision = new System.Windows.Forms.Button();
            this.rem_access = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 16;
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
            this.fisiereleMeleToolStripMenuItem.Click += new System.EventHandler(this.fisiereleMeleToolStripMenuItem_Click);
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 83);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(402, 367);
            this.dataGridView.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(157, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fisiere proprii:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(479, 367);
            this.dataGridView1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(617, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fisiere la care primit access:";
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(12, 54);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 21;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(111, 54);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(75, 23);
            this.download.TabIndex = 22;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(220, 54);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 23;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // share
            // 
            this.share.Location = new System.Drawing.Point(326, 54);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(75, 23);
            this.share.TabIndex = 24;
            this.share.Text = "Share";
            this.share.UseVisualStyleBackColor = true;
            this.share.Click += new System.EventHandler(this.share_Click);
            // 
            // download_extern
            // 
            this.download_extern.Location = new System.Drawing.Point(490, 54);
            this.download_extern.Name = "download_extern";
            this.download_extern.Size = new System.Drawing.Size(75, 23);
            this.download_extern.TabIndex = 25;
            this.download_extern.Text = "Download";
            this.download_extern.UseVisualStyleBackColor = true;
            // 
            // upl_revision
            // 
            this.upl_revision.Location = new System.Drawing.Point(642, 54);
            this.upl_revision.Name = "upl_revision";
            this.upl_revision.Size = new System.Drawing.Size(115, 23);
            this.upl_revision.TabIndex = 26;
            this.upl_revision.Text = "Upload Revision";
            this.upl_revision.UseVisualStyleBackColor = true;
            this.upl_revision.Click += new System.EventHandler(this.upload_revision_click);
            // 
            // rem_access
            // 
            this.rem_access.Location = new System.Drawing.Point(809, 54);
            this.rem_access.Name = "rem_access";
            this.rem_access.Size = new System.Drawing.Size(105, 23);
            this.rem_access.TabIndex = 27;
            this.rem_access.Text = "Remove Access";
            this.rem_access.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Fisiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 462);
            this.Controls.Add(this.rem_access);
            this.Controls.Add(this.upl_revision);
            this.Controls.Add(this.download_extern);
            this.Controls.Add(this.share);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.download);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Fisiere";
            this.Text = "Fisiere";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_agenda;
        private System.Windows.Forms.ToolStripMenuItem fisiereleMeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button share;
        private System.Windows.Forms.Button download_extern;
        private System.Windows.Forms.Button upl_revision;
        private System.Windows.Forms.Button rem_access;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}