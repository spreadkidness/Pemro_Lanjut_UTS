using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SistemInformasiPenggajian.Config;

namespace SistemInformasiPenggajian
{
    public partial class FrmListPenggajian : Form
    {
        public FrmListPenggajian()
        {
            InitializeComponent();
        }

        private void FrmListPenggajian_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData(string keyword = "")
        {
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    string query = @"SELECT p.no_slip AS [No. Slip], 
                                            p.tanggal_gaji AS [Tanggal], 
                                            p.bulan_tahun AS [Periode], 
                                            k.nip AS [NIP], 
                                            k.nama_karyawan AS [Nama Karyawan], 
                                            j.nama_jabatan AS [Jabatan], 
                                            p.gaji_bersih AS [Gaji Bersih]
                                     FROM tbl_penggajian p
                                     JOIN tbl_karyawan k ON p.nip = k.nip
                                     JOIN tbl_jabatan j ON k.kode_jabatan = j.kode_jabatan
                                     WHERE k.nama_karyawan LIKE @key OR p.no_slip LIKE @key OR p.bulan_tahun LIKE @key
                                     ORDER BY p.tanggal_gaji DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" + keyword + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPenggajian.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data penggajian: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadData(txtCari.Text.Trim());
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntriPenggajian frm = new FrmEntriPenggajian();
            if (frm.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPenggajian.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data slip gaji yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string noSlip = dgvPenggajian.SelectedRows[0].Cells["No. Slip"].Value?.ToString() ?? "";
            if (MessageBox.Show($"Yakin ingin menghapus slip gaji '{noSlip}'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_penggajian WHERE no_slip = @slip", conn);
                    cmd.Parameters.AddWithValue("@slip", noSlip);
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
            }
        }

        private void btnTutup_Click(object sender, EventArgs e) => this.Close();
    }
}