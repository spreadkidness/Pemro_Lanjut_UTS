using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SistemInformasiPenggajian.Config;

namespace SistemInformasiPenggajian
{
    public partial class FrmEntriKaryawan : Form
    {
        private string mode;
        private string nipLama;

        public FrmEntriKaryawan(string mode, string nip)
        {
            InitializeComponent();
            this.mode = mode;
            this.nipLama = nip;
        }

        private void FrmEntriKaryawan_Load(object sender, EventArgs e)
        {
            LoadComboJabatan();

            if (mode == "Ubah")
            {
                this.Text = "Ubah Data Karyawan";
                txtNip.Enabled = false;
                LoadDetailKaryawan();
            }
            else
            {
                this.Text = "Tambah Data Karyawan";
            }
        }

        private void LoadComboJabatan()
        {
            using (SqlConnection conn = Koneksi.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT kode_jabatan, nama_jabatan FROM tbl_jabatan", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbJabatan.DataSource = dt;
                cmbJabatan.DisplayMember = "nama_jabatan";
                cmbJabatan.ValueMember = "kode_jabatan";
            }
        }

        private void LoadDetailKaryawan()
        {
            using (SqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_karyawan WHERE nip = @nip", conn);
                cmd.Parameters.AddWithValue("@nip", nipLama);
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        txtNip.Text = r["nip"].ToString();
                        txtNamaKaryawan.Text = r["nama_karyawan"].ToString();
                        cmbJabatan.SelectedValue = r["kode_jabatan"].ToString();
                        txtNoRekening.Text = r["no_rekening"].ToString();
                        chkStatusAktif.Checked = r["status_aktif"].ToString() == "Aktif";
                    }
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNip.Text) || string.IsNullOrWhiteSpace(txtNamaKaryawan.Text) || cmbJabatan.SelectedValue == null)
            {
                MessageBox.Show("NIP, Nama Karyawan, dan Jabatan wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = mode == "Tambah"
                        ? "INSERT INTO tbl_karyawan (nip, nama_karyawan, kode_jabatan, no_rekening, status_aktif) VALUES (@nip, @nama, @jabatan, @rek, @status)"
                        : "UPDATE tbl_karyawan SET nama_karyawan=@nama, kode_jabatan=@jabatan, no_rekening=@rek, status_aktif=@status WHERE nip=@nip";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nip", txtNip.Text.Trim());
                        cmd.Parameters.AddWithValue("@nama", txtNamaKaryawan.Text.Trim());
                        cmd.Parameters.AddWithValue("@jabatan", cmbJabatan.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@rek", txtNoRekening.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", chkStatusAktif.Checked ? "Aktif" : "Nonaktif");
                        cmd.ExecuteNonQuery();
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}