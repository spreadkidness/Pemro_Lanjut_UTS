namespace SistemInformasiPenggajian
{
    partial class FrmMenuUtama
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
            mnuFile = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            mnuKeluar = new ToolStripMenuItem();
            mnuDataMaster = new ToolStripMenuItem();
            mnuJabatan = new ToolStripMenuItem();
            mnuKaryawan = new ToolStripMenuItem();
            mnuTransaksi = new ToolStripMenuItem();
            mnuPenggajian = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuLogout, mnuKeluar });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "File";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(180, 22);
            mnuLogout.Text = "Logout";
            mnuLogout.Click += mnuLogout_Click;
            // 
            // mnuKeluar
            // 
            mnuKeluar.Name = "mnuKeluar";
            mnuKeluar.Size = new Size(180, 22);
            mnuKeluar.Text = "Keluar";
            mnuKeluar.Click += mnuKeluar_Click;
            // 
            // mnuDataMaster
            // 
            mnuDataMaster.DropDownItems.AddRange(new ToolStripItem[] { mnuJabatan, mnuKaryawan });
            mnuDataMaster.Name = "mnuDataMaster";
            mnuDataMaster.Size = new Size(82, 20);
            mnuDataMaster.Text = "Data Master";
            // 
            // mnuJabatan
            // 
            mnuJabatan.Name = "mnuJabatan";
            mnuJabatan.Size = new Size(152, 22);
            mnuJabatan.Text = "Data Jabatan";
            mnuJabatan.Click += mnuJabatan_Click;
            // 
            // mnuKaryawan
            // 
            mnuKaryawan.Name = "mnuKaryawan";
            mnuKaryawan.Size = new Size(152, 22);
            mnuKaryawan.Text = "Data Karyawan";
            mnuKaryawan.Click += mnuKaryawan_Click;
            // 
            // mnuTransaksi
            // 
            mnuTransaksi.DropDownItems.AddRange(new ToolStripItem[] { mnuPenggajian });
            mnuTransaksi.Name = "mnuTransaksi";
            mnuTransaksi.Size = new Size(67, 20);
            mnuTransaksi.Text = "Transaksi";
            // 
            // mnuPenggajian
            // 
            mnuPenggajian.Name = "mnuPenggajian";
            mnuPenggajian.Size = new Size(180, 22);
            mnuPenggajian.Text = "Penggajian Bulanan";
            mnuPenggajian.Click += mnuPenggajian_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuDataMaster, mnuTransaksi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(397, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // FrmMenuUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 273);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "FrmMenuUtama";
            Text = "Menu Utama - Sistem Informasi Penggajian";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenuUtama_Load;
            Click += mnuPenggajian_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuLogout;
        private ToolStripMenuItem mnuKeluar;
        private ToolStripMenuItem mnuDataMaster;
        private ToolStripMenuItem mnuJabatan;
        private ToolStripMenuItem mnuKaryawan;
        private ToolStripMenuItem mnuTransaksi;
        private ToolStripMenuItem mnuPenggajian;
        private MenuStrip menuStrip1;
    }
}