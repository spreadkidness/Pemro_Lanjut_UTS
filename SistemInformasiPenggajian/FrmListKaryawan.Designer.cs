namespace SistemInformasiPenggajian
{
    partial class FrmListKaryawan
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
            btnUbah = new Button();
            btnHapus = new Button();
            btnTutup = new Button();
            dgvKaryawan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Cari Karyawan";
            // 
            // txtCari
            // 
            txtCari.Location = new Point(100, 12);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(100, 23);
            txtCari.TabIndex = 1;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(206, 11);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(75, 24);
            btnCari.TabIndex = 2;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(287, 12);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 3;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(368, 12);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(75, 23);
            btnUbah.TabIndex = 4;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(449, 12);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 23);
            btnHapus.TabIndex = 5;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnTutup
            // 
            btnTutup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTutup.Location = new Point(530, 12);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(75, 23);
            btnTutup.TabIndex = 6;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = true;
            btnTutup.Click += btnTutup_Click;
            // 
            // dgvKaryawan
            // 
            dgvKaryawan.AllowUserToAddRows = false;
            dgvKaryawan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.Location = new Point(12, 41);
            dgvKaryawan.MultiSelect = false;
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.ReadOnly = true;
            dgvKaryawan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKaryawan.Size = new Size(593, 354);
            dgvKaryawan.TabIndex = 7;
            // 
            // FrmListKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 407);
            Controls.Add(dgvKaryawan);
            Controls.Add(btnTutup);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(btnTambah);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(label1);
            Name = "FrmListKaryawan";
            Text = "Daftar Data Karyawan";
            Load += FrmListKaryawan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCari;
        private Button btnCari;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnTutup;
        private DataGridView dgvKaryawan;
    }
}