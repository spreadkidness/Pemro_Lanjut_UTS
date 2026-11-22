namespace SistemInformasiPenggajian
{
    partial class FrmEntriJabatan
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtKodeJabatan = new TextBox();
            txtNamaJabatan = new TextBox();
            numGajiPokok = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numTunjangan = new NumericUpDown();
            btnSimpan = new Button();
            btnBatal = new Button();
            numTarifLembur = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numGajiPokok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTunjangan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTarifLembur).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Kode Jabatan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 44);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Jabatan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 72);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Gaji Pokok :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 101);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 3;
            label4.Text = "Tunjangan Jabatan :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 130);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 4;
            label5.Text = "Tarif Lembur / Jam :";
            // 
            // txtKodeJabatan
            // 
            txtKodeJabatan.Location = new Point(155, 12);
            txtKodeJabatan.Name = "txtKodeJabatan";
            txtKodeJabatan.Size = new Size(165, 23);
            txtKodeJabatan.TabIndex = 5;
            // 
            // txtNamaJabatan
            // 
            txtNamaJabatan.Location = new Point(155, 41);
            txtNamaJabatan.Name = "txtNamaJabatan";
            txtNamaJabatan.Size = new Size(165, 23);
            txtNamaJabatan.TabIndex = 6;
            // 
            // numGajiPokok
            // 
            numGajiPokok.Location = new Point(155, 70);
            numGajiPokok.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numGajiPokok.Name = "numGajiPokok";
            numGajiPokok.Size = new Size(165, 23);
            numGajiPokok.TabIndex = 7;
            numGajiPokok.ThousandsSeparator = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(879, 255);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 8;
            // 
            // numTunjangan
            // 
            numTunjangan.Location = new Point(155, 99);
            numTunjangan.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numTunjangan.Name = "numTunjangan";
            numTunjangan.Size = new Size(165, 23);
            numTunjangan.TabIndex = 9;
            numTunjangan.ThousandsSeparator = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(169, 173);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(71, 23);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(246, 173);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(74, 23);
            btnBatal.TabIndex = 11;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // numTarifLembur
            // 
            numTarifLembur.Location = new Point(155, 128);
            numTarifLembur.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numTarifLembur.Name = "numTarifLembur";
            numTarifLembur.Size = new Size(165, 23);
            numTarifLembur.TabIndex = 12;
            numTarifLembur.ThousandsSeparator = true;
            // 
            // FrmEntriJabatan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 214);
            Controls.Add(numTarifLembur);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(numTunjangan);
            Controls.Add(numericUpDown2);
            Controls.Add(numGajiPokok);
            Controls.Add(txtNamaJabatan);
            Controls.Add(txtKodeJabatan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEntriJabatan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tambah / Ubah Data Jabatan";
            Load += FrmEntriJabatan_Load;
            ((System.ComponentModel.ISupportInitialize)numGajiPokok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTunjangan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTarifLembur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtKodeJabatan;
        private TextBox txtNamaJabatan;
        private NumericUpDown numGajiPokok;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numTunjangan;
        private Button btnSimpan;
        private Button btnBatal;
        private NumericUpDown numTarifLembur;
    }
}