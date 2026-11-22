using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SistemInformasiPenggajian.Config;

namespace SistemInformasiPenggajian
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id_user, nama_lengkap, role FROM tbl_user WHERE username = @user AND password = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserSession.IdUser = Convert.ToInt32(reader["id_user"]);
                                UserSession.NamaLengkap = reader["nama_lengkap"].ToString() ?? "";
                                UserSession.Role = reader["role"].ToString() ?? "";

                                MessageBox.Show($"Selamat datang, {UserSession.NamaLengkap} ({UserSession.Role})!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Buka Menu Utama (akan dibuat di tahap berikutnya)
                                FrmMenuUtama menu = new FrmMenuUtama();
                                menu.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void txtKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}