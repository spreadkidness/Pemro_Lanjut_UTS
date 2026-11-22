using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SistemInformasiPenggajian.Config;

namespace SistemInformasiPenggajian
{
    public partial class FrmListKaryawan : Form
    {
        public FrmListKaryawan()
        {
            InitializeComponent();
        }

        private void FrmListKaryawan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData(string keyword = "")
        {
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    string query = @"SELECT k.nip AS [NIP], 
                                            k.nama_karyawan AS [Nama Karyawan], 
                                            j.nama_jabatan AS [Jabatan], 
                                            k.no_rekening AS [No. Rekening], 
                                            k.status_aktif AS [Status]
                                     FROM tbl_karyawan k
                                     JOIN tbl_jabatan j ON k.kode_jabatan = j.kode_jabatan
                                     WHERE k.nama_karyawan LIKE @key OR k.nip LIKE @key";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" + keyword + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKaryawan.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCari_Click(object sender, EventArgs e) => LoadData(txtCari.Text.Trim());

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntriKaryawan frm = new FrmEntriKaryawan("Tambah", "");
            if (frm.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvKaryawan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris karyawan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nip = dgvKaryawan.SelectedRows[0].Cells["NIP"].Value?.ToString() ?? "";
            FrmEntriKaryawan frm = new FrmEntriKaryawan("Ubah", nip);
            if (frm.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvKaryawan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris karyawan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nip = dgvKaryawan.SelectedRows[0].Cells["NIP"].Value?.ToString() ?? "";
            string nama = dgvKaryawan.SelectedRows[0].Cells["Nama Karyawan"].Value?.ToString() ?? "";

            if (MessageBox.Show($"Hapus karyawan '{nama}' ({nip})?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Koneksi.GetConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM tbl_karyawan WHERE nip = @nip", conn);
                        cmd.Parameters.AddWithValue("@nip", nip);
                        cmd.ExecuteNonQuery();
                        LoadData();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Karyawan tidak dapat dihapus karena sudah memiliki data transaksi gaji!", "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTutup_Click(object sender, EventArgs e) => this.Close();
    }
}