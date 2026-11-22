namespace SistemInformasiPenggajian
{
    partial class FrmEntriPenggajian
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
            txtNoSlip = new TextBox();
            txtPeriode = new TextBox();
            txtJabatan = new TextBox();
            dtpTanggal = new DateTimePicker();
            cmbKaryawan = new ComboBox();
            numGajiPokok = new NumericUpDown();
            numTunjangan = new NumericUpDown();
            numTarifLembur = new NumericUpDown();
            numPotongan = new NumericUpDown();
            numTotalLembur = new NumericUpDown();
            numJamLembur = new NumericUpDown();
            numGajiBersih = new NumericUpDown();
            btnSimpan = new Button();
            btnBatal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)numGajiPokok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTunjangan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTarifLembur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPotongan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotalLembur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJamLembur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGajiBersih).BeginInit();
            SuspendLayout();
            // 
            // txtNoSlip
            // 
            txtNoSlip.Location = new Point(154, 11);
            txtNoSlip.Name = "txtNoSlip";
            txtNoSlip.ReadOnly = true;
            txtNoSlip.Size = new Size(249, 23);
            txtNoSlip.TabIndex = 0;
            // 
            // txtPeriode
            // 
            txtPeriode.Location = new Point(154, 69);
            txtPeriode.Name = "txtPeriode";
            txtPeriode.Size = new Size(100, 23);
            txtPeriode.TabIndex = 1;
            // 
            // txtJabatan
            // 
            txtJabatan.Location = new Point(154, 127);
            txtJabatan.Name = "txtJabatan";
            txtJabatan.Size = new Size(249, 23);
            txtJabatan.TabIndex = 2;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(154, 40);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(160, 23);
            dtpTanggal.TabIndex = 3;
            // 
            // cmbKaryawan
            // 
            cmbKaryawan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKaryawan.FormattingEnabled = true;
            cmbKaryawan.Location = new Point(154, 98);
            cmbKaryawan.Name = "cmbKaryawan";
            cmbKaryawan.Size = new Size(249, 23);
            cmbKaryawan.TabIndex = 4;
            cmbKaryawan.SelectedIndexChanged += cmbKaryawan_SelectedIndexChanged;
            // 
            // numGajiPokok
            // 
            numGajiPokok.Location = new Point(154, 156);
            numGajiPokok.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numGajiPokok.Name = "numGajiPokok";
            numGajiPokok.ReadOnly = true;
            numGajiPokok.Size = new Size(160, 23);
            numGajiPokok.TabIndex = 5;
            numGajiPokok.TextAlign = HorizontalAlignment.Right;
            numGajiPokok.ThousandsSeparator = true;
            // 
            // numTunjangan
            // 
            numTunjangan.Location = new Point(154, 185);
            numTunjangan.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numTunjangan.Name = "numTunjangan";
            numTunjangan.ReadOnly = true;
            numTunjangan.Size = new Size(160, 23);
            numTunjangan.TabIndex = 6;
            numTunjangan.TextAlign = HorizontalAlignment.Right;
            numTunjangan.ThousandsSeparator = true;
            // 
            // numTarifLembur
            // 
            numTarifLembur.Location = new Point(98, 233);
            numTarifLembur.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numTarifLembur.Name = "numTarifLembur";
            numTarifLembur.ReadOnly = true;
            numTarifLembur.Size = new Size(105, 23);
            numTarifLembur.TabIndex = 7;
            numTarifLembur.TextAlign = HorizontalAlignment.Right;
            numTarifLembur.ThousandsSeparator = true;
            // 
            // numPotongan
            // 
            numPotongan.Location = new Point(298, 262);
            numPotongan.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPotongan.Name = "numPotongan";
            numPotongan.Size = new Size(105, 23);
            numPotongan.TabIndex = 10;
            numPotongan.TextAlign = HorizontalAlignment.Right;
            numPotongan.ThousandsSeparator = true;
            numPotongan.ValueChanged += HitungOtomatis_ValueChanged;
            // 
            // numTotalLembur
            // 
            numTotalLembur.Location = new Point(98, 262);
            numTotalLembur.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numTotalLembur.Name = "numTotalLembur";
            numTotalLembur.ReadOnly = true;
            numTotalLembur.Size = new Size(105, 23);
            numTotalLembur.TabIndex = 9;
            numTotalLembur.TextAlign = HorizontalAlignment.Right;
            numTotalLembur.ThousandsSeparator = true;
            // 
            // numJamLembur
            // 
            numJamLembur.Location = new Point(298, 233);
            numJamLembur.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numJamLembur.Name = "numJamLembur";
            numJamLembur.Size = new Size(105, 23);
            numJamLembur.TabIndex = 8;
            numJamLembur.TextAlign = HorizontalAlignment.Right;
            numJamLembur.ValueChanged += HitungOtomatis_ValueChanged;
            // 
            // numGajiBersih
            // 
            numGajiBersih.Location = new Point(98, 304);
            numGajiBersih.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numGajiBersih.Name = "numGajiBersih";
            numGajiBersih.ReadOnly = true;
            numGajiBersih.Size = new Size(305, 23);
            numGajiBersih.TabIndex = 11;
            numGajiBersih.TextAlign = HorizontalAlignment.Right;
            numGajiBersih.ThousandsSeparator = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(247, 343);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(328, 343);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 14;
            label1.Text = "No. Slip :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 15;
            label2.Text = "Tanggal :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 16;
            label3.Text = "Periode :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 158);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 19;
            label4.Text = "Gaji Pokok :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 130);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 18;
            label5.Text = "Jabatan :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 101);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 17;
            label6.Text = "Karyawan :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 264);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 22;
            label7.Text = "Total Lembur :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 235);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 21;
            label8.Text = "Tarif Lembur :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 187);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 20;
            label9.Text = "Tunjangan :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.Location = new Point(7, 304);
            label10.Name = "label10";
            label10.Size = new Size(88, 19);
            label10.TabIndex = 25;
            label10.Text = "Gaji Bersih :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(214, 264);
            label11.Name = "label11";
            label11.Size = new Size(65, 15);
            label11.TabIndex = 24;
            label11.Text = "Potongan :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(214, 235);
            label12.Name = "label12";
            label12.Size = new Size(78, 15);
            label12.TabIndex = 23;
            label12.Text = "Jam Lembur :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(260, 72);
            label13.Name = "label13";
            label13.Size = new Size(62, 15);
            label13.TabIndex = 26;
            label13.Text = "YYYY-MM";
            // 
            // FrmEntriPenggajian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 379);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(numGajiBersih);
            Controls.Add(numPotongan);
            Controls.Add(numTotalLembur);
            Controls.Add(numJamLembur);
            Controls.Add(numTarifLembur);
            Controls.Add(numTunjangan);
            Controls.Add(numGajiPokok);
            Controls.Add(cmbKaryawan);
            Controls.Add(dtpTanggal);
            Controls.Add(txtJabatan);
            Controls.Add(txtPeriode);
            Controls.Add(txtNoSlip);
            Name = "FrmEntriPenggajian";
            Text = "FrmEntriPenggajian";
            Load += FrmEntriPenggajian_Load;
            ((System.ComponentModel.ISupportInitialize)numGajiPokok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTunjangan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTarifLembur).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPotongan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotalLembur).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJamLembur).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGajiBersih).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNoSlip;
        private TextBox txtPeriode;
        private TextBox txtJabatan;
        private DateTimePicker dtpTanggal;
        private ComboBox cmbKaryawan;
        private NumericUpDown numGajiPokok;
        private NumericUpDown numTunjangan;
        private NumericUpDown numTarifLembur;
        private NumericUpDown numPotongan;
        private NumericUpDown numTotalLembur;
        private NumericUpDown numJamLembur;
        private NumericUpDown numGajiBersih;
        private Button btnSimpan;
        private Button btnBatal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}