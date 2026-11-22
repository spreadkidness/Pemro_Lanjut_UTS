Persiapan Lingkungan Pengembangan (Tools)

1. Install Visual Studio (Community Edition 2022 atau versi terbaru) dengan memilih workload .NET desktop development (bahasa C# atau VB.NET).
2. Database Server: Install SQL Server Express beserta SQL Server Management Studio (SSMS).

Pilih opsi Basic (kotak paling kiri) pada tampilan instalasi SQL Server 2025 Express Edition tersebut.   
1. Langkah Selanjutnya:Basic secara otomatis menginstal SQL Server Database Engine dengan konfigurasi standar yang sudah cukup untuk kebutuhan aplikasi desktop Windows Forms dan koneksi lokal Visual Studio.   
2. Setelah mengklik Basic, klik Accept pada halaman lisensi, lalu tekan Install dan tunggu proses pengunduhan serta pemasangan selesai.
3. Setelah instalasi berhasil, klik tombol Install SSMS (SQL Server Management Studio) yang muncul di layar akhir untuk menginstal aplikasi pengelola databasenya agar Anda bisa membuat database dan tabel secara visual.

Untuk memilih workload .NET desktop development di Visual Studio, ikuti langkah berikut sesuai kondisi instalasi Anda:
1. Jika Baru Menginstal Visual Studio (Dari Awal)Jalankan installer Visual Studio yang sudah diunduh (VisualStudioSetup.exe), lalu klik Continue.
2. Setelah jendela Visual Studio Installer terbuka, Anda akan langsung berada di tab Workloads.
3. Gulir ke bawah pada bagian Desktop & Mobile, lalu centang kotak .NET desktop development (ikon layar monitor dengan tulisan C#/VB).
4. (Opsional) Jika ingin langsung menghubungkan Visual Studio dengan SQL Server, gulir sedikit lagi ke bagian Other Toolsets dan centang Data storage and processing.
5. Klik tombol Install di pojok kanan bawah dan tunggu hingga proses selesai

Jika Visual Studio Sudah Terinstal Sebelumnya
1. Buka menu Start di Windows, ketik Visual Studio Installer, lalu buka aplikasi tersebut.
2. Pada daftar versi Visual Studio yang terinstal, klik tombol Modify (Ubah).
3. Pada tab Workloads, cari bagian Desktop & Mobile, lalu centang kotak .NET desktop development.
4. Klik tombol Modify di pojok kanan bawah untuk mulai mengunduh dan menambahkan komponen tersebut.

Panduan Memilih Development Settings:
1. Pilih C#: Jika Anda menggunakan bahasa C# (paling umum dipakai untuk Windows Forms modern dan sesuai dengan contoh kode koneksi di atas). Pengaturan ini otomatis mengoptimalkan shortcut keyboard dan tata letak jendela khusus untuk pengembangan C#.
2. Pilih Visual Basic: Hanya jika dosen atau kelompok Anda memang sepakat menggunakan bahasa VB.NET.
3. Pilih General: Hanya jika Anda berencana sering berganti-ganti bahasa pemrograman (misal C#, C++, Python, dan VB sekaligus) dalam satu aplikasi Visual Studio yang sama.
