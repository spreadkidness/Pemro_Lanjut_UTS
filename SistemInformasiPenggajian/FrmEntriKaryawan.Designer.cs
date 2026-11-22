namespace SistemInformasiPenggajian
{
    partial class FrmEntriKaryawan
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
            txtNip = new TextBox();
            txtNamaKaryawan = new TextBox();
            cmbJabatan = new ComboBox();
            txtNoRekening = new TextBox();
            chkStatusAktif = new CheckBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtNip
            // 
            txtNip.Location = new Point(134, 20);
            txtNip.Name = "txtNip";
            txtNip.Size = new Size(196, 23);
            txtNip.TabIndex = 0;
            // 
            // txtNamaKaryawan
            // 
            txtNamaKaryawan.Location = new Point(134, 51);
            txtNamaKaryawan.Name = "txtNamaKaryawan";
            txtNamaKaryawan.Size = new Size(196, 23);
            txtNamaKaryawan.TabIndex = 1;
            // 
            // cmbJabatan
            // 
            cmbJabatan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJabatan.FormattingEnabled = true;
            cmbJabatan.Location = new Point(134, 83);
            cmbJabatan.Name = "cmbJabatan";
            cmbJabatan.Size = new Size(196, 23);
            cmbJabatan.TabIndex = 2;
            // 
            // txtNoRekening
            // 
            txtNoRekening.Location = new Point(134, 115);
            txtNoRekening.Name = "txtNoRekening";
            txtNoRekening.Size = new Size(196, 23);
            txtNoRekening.TabIndex = 3;
            // 
            // chkStatusAktif
            // 
            chkStatusAktif.AutoSize = true;
            chkStatusAktif.Checked = true;
            chkStatusAktif.CheckState = CheckState.Checked;
            chkStatusAktif.Location = new Point(134, 145);
            chkStatusAktif.Name = "chkStatusAktif";
            chkStatusAktif.Size = new Size(51, 19);
            chkStatusAktif.TabIndex = 4;
            chkStatusAktif.Text = "Aktif";
            chkStatusAktif.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(170, 175);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(77, 23);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(253, 175);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(77, 23);
            btnBatal.TabIndex = 6;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 7;
            label1.Text = "NIP :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 8;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 9;
            label3.Text = "Jabatan :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 10;
            label4.Text = "No. Rekening :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 145);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 11;
            label5.Text = "Status :";
            // 
            // FrmEntriKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 209);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(chkStatusAktif);
            Controls.Add(txtNoRekening);
            Controls.Add(cmbJabatan);
            Controls.Add(txtNamaKaryawan);
            Controls.Add(txtNip);
            Name = "FrmEntriKaryawan";
            Text = "Tambah / Ubah Data Karyawan";
            Load += FrmEntriKaryawan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNip;
        private TextBox txtNamaKaryawan;
        private ComboBox cmbJabatan;
        private TextBox txtNoRekening;
        private CheckBox chkStatusAktif;
        private Button btnSimpan;
        private Button btnBatal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}