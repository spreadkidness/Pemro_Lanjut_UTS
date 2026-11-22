using Microsoft.Data.SqlClient;

namespace SistemInformasiPenggajian.Config
{
    public class Koneksi
    {
        private static string connStr = @"Server=localhost\SQLEXPRESS;Database=db_penggajian;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }
    }

    // Menyimpan sesi pengguna yang berhasil login
    public static class UserSession
    {
        public static int IdUser { get; set; }
        public static string NamaLengkap { get; set; } = "";
        public static string Role { get; set; } = "";
    }
}