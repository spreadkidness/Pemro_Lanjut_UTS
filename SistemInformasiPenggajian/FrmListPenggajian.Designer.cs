namespace SistemInformasiPenggajian
{
    partial class FrmListPenggajian
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
            label1 = new Label();
            txtCari = new TextBox();
            btnCari = new Button();
            btnTambah = new Button();
            btnTutup = new Button();
            btnHapus = new Button();
            dgvPenggajian = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPenggajian).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 15);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Cari :";
            // 
            // txtCari
            // 
            txtCari.Location = new Point(45, 12);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(155, 23);
            txtCari.TabIndex = 1;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(206, 12);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(75, 24);
            btnCari.TabIndex = 2;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(287, 11);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 24);
            btnTambah.TabIndex = 3;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnTutup
            // 
            btnTutup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTutup.Location = new Point(449, 11);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(75, 24);
            btnTutup.TabIndex = 5;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = true;
            btnTutup.Click += btnTutup_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(368, 11);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 24);
            btnHapus.TabIndex = 4;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // dgvPenggajian
            // 
            dgvPenggajian.AllowUserToAddRows = false;
            dgvPenggajian.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPenggajian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenggajian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenggajian.Location = new Point(12, 42);
            dgvPenggajian.MultiSelect = false;
            dgvPenggajian.Name = "dgvPenggajian";
            dgvPenggajian.ReadOnly = true;
            dgvPenggajian.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenggajian.Size = new Size(512, 269);
            dgvPenggajian.TabIndex = 6;
            // 
            // FrmListPenggajian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 328);
            Controls.Add(dgvPenggajian);
            Controls.Add(btnTutup);
            Controls.Add(btnHapus);
            Controls.Add(btnTambah);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(label1);
            Name = "FrmListPenggajian";
            Text = "Daftar Transaksi Penggajian";
            Load += FrmListPenggajian_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPenggajian).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCari;
        private Button btnCari;
        private Button btnTambah;
        private Button btnTutup;
        private Button btnHapus;
        private DataGridView dgvPenggajian;
    }
}