using System;
using System.Windows.Forms;
using SistemInformasiPenggajian.Config;

namespace SistemInformasiPenggajian
{
    public partial class FrmMenuUtama : Form
    {
        public FrmMenuUtama()
        {
            InitializeComponent();
        }

        private void FrmMenuUtama_Load(object sender, EventArgs e)
        {
            string role = UserSession.Role?.ToLower() ?? "";

            if (role.Contains("hrd") || role.Contains("admin"))
            {
                // Ganti nama di bawah ini sesuai (Name) di Properties Anda
                mnuDataMaster.Enabled = true;
                mnuTransaksi.Enabled = false;
            }
            else if (role.Contains("finance"))
            {
                // Ganti nama di bawah ini sesuai (Name) di Properties Anda
                mnuDataMaster.Enabled = false;
                mnuTransaksi.Enabled = true;
            }
        }

        private void mnuJabatan_Click(object sender, EventArgs e)
        {
            BukaFormAnak(new FrmListJabatan());
        }

        private void mnuKaryawan_Click(object sender, EventArgs e)
        {
            BukaFormAnak(new FrmListKaryawan());
        }

        private void mnuPenggajian_Click(object sender, EventArgs e)
        {
            BukaFormAnak(new FrmListPenggajian());
        }

        private void BukaFormAnak(Form formBaru)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            formBaru.MdiParent = this;
            formBaru.WindowState = FormWindowState.Maximized;
            formBaru.Show();
        }

        private bool isLogout = false;
        private void mnuLogout_Click(object sender, EventArgs e)
        {
            isLogout = true; // Wajib ada agar OnFormClosed tidak memanggil Application.Exit()

            UserSession.Role = "";
            UserSession.NamaLengkap = "";

            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!isLogout)
            {
                Application.Exit();
            }
        }

        private void mnuKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}