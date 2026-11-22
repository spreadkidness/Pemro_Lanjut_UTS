using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SistemInformasiPenggajian.Config;

namespace SistemInformasiPenggajian
{
    public partial class FrmEntriJabatan : Form
    {
        private string mode;
        private string kodeLama;

        public FrmEntriJabatan(string mode, string kode)
        {
            InitializeComponent();
            this.mode = mode;
            this.kodeLama = kode;
        }

        private void FrmEntriJabatan_Load(object sender, EventArgs e)
        {
            if (mode == "Ubah")
            {
                this.Text = "Ubah Data Jabatan";
                txtKodeJabatan.Enabled = false;
                LoadDetailJabatan();
            }
            else
            {
                this.Text = "Tambah Data Jabatan";
            }
        }

        private void LoadDetailJabatan()
        {
            using (SqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_jabatan WHERE kode_jabatan = @kode", conn);
                cmd.Parameters.AddWithValue("@kode", kodeLama);
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        txtKodeJabatan.Text = r["kode_jabatan"].ToString();
                        txtNamaJabatan.Text = r["nama_jabatan"].ToString();
                        numGajiPokok.Value = Convert.ToDecimal(r["gaji_pokok"]);
                        numTunjangan.Value = Convert.ToDecimal(r["tunjangan_jabatan"]);
                        numTarifLembur.Value = Convert.ToDecimal(r["tarif_lembur_per_jam"]);
                    }
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKodeJabatan.Text) || string.IsNullOrWhiteSpace(txtNamaJabatan.Text))
            {
                MessageBox.Show("Kode dan Nama Jabatan wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = mode == "Tambah"
                        ? "INSERT INTO tbl_jabatan (kode_jabatan, nama_jabatan, gaji_pokok, tunjangan_jabatan, tarif_lembur_per_jam) VALUES (@kode, @nama, @gapok, @tunj, @lembur)"
                        : "UPDATE tbl_jabatan SET nama_jabatan=@nama, gaji_pokok=@gapok, tunjangan_jabatan=@tunj, tarif_lembur_per_jam=@lembur WHERE kode_jabatan=@kode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode", txtKodeJabatan.Text.Trim());
                        cmd.Parameters.AddWithValue("@nama", txtNamaJabatan.Text.Trim());
                        cmd.Parameters.AddWithValue("@gapok", numGajiPokok.Value);
                        cmd.Parameters.AddWithValue("@tunj", numTunjangan.Value);
                        cmd.Parameters.AddWithValue("@lembur", numTarifLembur.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data jabatan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}