using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SistemInformasiPenggajian.Config;

namespace SistemInformasiPenggajian
{
    public partial class FrmEntriPenggajian : Form
    {
        public FrmEntriPenggajian()
        {
            InitializeComponent();
        }

        private void FrmEntriPenggajian_Load(object sender, EventArgs e)
        {
            txtNoSlip.Text = "SLP-" + DateTime.Now.ToString("yyyyMMddHHmm");
            txtPeriode.Text = DateTime.Now.ToString("MMMM yyyy");
            LoadComboKaryawan();
        }

        private void LoadComboKaryawan()
        {
            using (SqlConnection conn = Koneksi.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT nip, nama_karyawan FROM tbl_karyawan WHERE status_aktif = 'Aktif'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbKaryawan.DataSource = dt;
                cmbKaryawan.DisplayMember = "nama_karyawan";
                cmbKaryawan.ValueMember = "nip";

                if (cmbKaryawan.Items.Count> 0)
                {
                    cmbKaryawan_SelectedIndexChanged(cmbKaryawan, EventArgs.Empty);
                }
            }
        }

        private void cmbKaryawan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKaryawan.SelectedValue == null || cmbKaryawan.SelectedValue is DataRowView) return;

            using (SqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = @"SELECT j.nama_jabatan, j.gaji_pokok, j.tunjangan_jabatan, j.tarif_lembur_per_jam
                                 FROM tbl_karyawan k
                                 JOIN tbl_jabatan j ON k.kode_jabatan = j.kode_jabatan
                                 WHERE k.nip = @nip";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nip", cmbKaryawan.SelectedValue.ToString());
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        txtJabatan.Text = r["nama_jabatan"].ToString();
                        numGajiPokok.Value = Convert.ToDecimal(r["gaji_pokok"]);
                        numTunjangan.Value = Convert.ToDecimal(r["tunjangan_jabatan"]);
                        numTarifLembur.Value = Convert.ToDecimal(r["tarif_lembur_per_jam"]);
                        HitungGaji();
                    }
                }
            }
        }

        private void HitungOtomatis_ValueChanged(object sender, EventArgs e)
        {
            HitungGaji();
        }

        private void HitungGaji()
        {
            decimal totalLembur = numJamLembur.Value * numTarifLembur.Value;
            numTotalLembur.Value = totalLembur;

            decimal gajiBersih = (numGajiPokok.Value + numTunjangan.Value + totalLembur) - numPotongan.Value;
            numGajiBersih.Value = gajiBersih < 0 ? 0 : gajiBersih;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoSlip.Text) || cmbKaryawan.SelectedValue == null)
            {
                MessageBox.Show("No. Slip dan Karyawan wajib dipilih!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO tbl_penggajian 
                                     (no_slip, tanggal_gaji, bulan_tahun, nip, gaji_pokok, tunjangan, jam_lembur, total_lembur, potongan, gaji_bersih, id_user)
                                     VALUES (@slip, @tgl, @periode, @nip, @gapok, @tunj, @jam, @totlembur, @pot, @bersih, @user)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@slip", txtNoSlip.Text.Trim());
                        cmd.Parameters.AddWithValue("@tgl", dtpTanggal.Value.Date);
                        cmd.Parameters.AddWithValue("@periode", txtPeriode.Text.Trim());
                        cmd.Parameters.AddWithValue("@nip", cmbKaryawan.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@gapok", numGajiPokok.Value);
                        cmd.Parameters.AddWithValue("@tunj", numTunjangan.Value);
                        cmd.Parameters.AddWithValue("@jam", (int)numJamLembur.Value);
                        cmd.Parameters.AddWithValue("@totlembur", numTotalLembur.Value);
                        cmd.Parameters.AddWithValue("@pot", numPotongan.Value);
                        cmd.Parameters.AddWithValue("@bersih", numGajiBersih.Value);
                        cmd.Parameters.AddWithValue("@user", UserSession.IdUser);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Transaksi penggajian berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan penggajian: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {

        }
    }
}