using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SistemInformasiPenggajian.Config;

namespace SistemInformasiPenggajian
{
    public partial class FrmListJabatan : Form
    {
        public FrmListJabatan()
        {
            InitializeComponent();
        }

        private void FrmListJabatan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData(string keyword = "")
        {
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    string query = @"SELECT kode_jabatan AS [Kode], 
                                            nama_jabatan AS [Nama Jabatan], 
                                            gaji_pokok AS [Gaji Pokok], 
                                            tunjangan_jabatan AS [Tunjangan], 
                                            tarif_lembur_per_jam AS [Tarif Lembur] 
                                     FROM tbl_jabatan 
                                     WHERE nama_jabatan LIKE @key OR kode_jabatan LIKE @key";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" + keyword + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvJabatan.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data jabatan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadData(txtCari.Text.Trim());
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntriJabatan frm = new FrmEntriJabatan("Tambah", "");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvJabatan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris jabatan yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kode = dgvJabatan.SelectedRows[0].Cells["Kode"].Value.ToString() ?? "";
            FrmEntriJabatan frm = new FrmEntriJabatan("Ubah", kode);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvJabatan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris jabatan yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kode = dgvJabatan.SelectedRows[0].Cells["Kode"].Value.ToString() ?? "";
            string nama = dgvJabatan.SelectedRows[0].Cells["Nama Jabatan"].Value.ToString() ?? "";

            if (MessageBox.Show($"Yakin ingin menghapus jabatan '{nama}' ({kode})?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Koneksi.GetConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM tbl_jabatan WHERE kode_jabatan = @kode", conn);
                        cmd.Parameters.AddWithValue("@kode", kode);
                        cmd.ExecuteNonQuery();
                        LoadData();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Jabatan tidak dapat dihapus karena masih digunakan oleh data karyawan!", "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}