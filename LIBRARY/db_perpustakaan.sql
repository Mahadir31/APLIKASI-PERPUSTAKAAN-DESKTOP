-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 01 Nov 2022 pada 17.33
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_perpustakaan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblanggota`
--

CREATE TABLE `tblanggota` (
  `KodeAnggota` varchar(7) NOT NULL,
  `NamaAnggota` varchar(100) NOT NULL,
  `JenisKelamin` varchar(10) NOT NULL,
  `AlamatAnggota` varchar(100) NOT NULL,
  `TelponAnggota` char(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tblanggota`
--

INSERT INTO `tblanggota` (`KodeAnggota`, `NamaAnggota`, `JenisKelamin`, `AlamatAnggota`, `TelponAnggota`) VALUES
('AGT0001', 'SARIF', 'Laki-Laki', 'GUNUNG SARI', '089765432112'),
('AGT0002', 'UDIN', 'Laki-Laki', 'LOMBOK', '089765432112');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblbuku`
--

CREATE TABLE `tblbuku` (
  `KodeBuku` varchar(7) NOT NULL,
  `JudulBuku` varchar(100) NOT NULL,
  `PengarangBuku` varchar(100) NOT NULL,
  `Penerbit` varchar(100) NOT NULL,
  `TahunBuku` year(4) NOT NULL,
  `StokBuku` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tblbuku`
--

INSERT INTO `tblbuku` (`KodeBuku`, `JudulBuku`, `PengarangBuku`, `Penerbit`, `TahunBuku`, `StokBuku`) VALUES
('BK0001', 'LASKAR PELANGI', 'ANDREA HIRATA', 'BENTANG PUSTAKA', 2000, 10),
('BK0002', 'CINTA BRONTOSAURUS', 'RADITYA DIKA', 'GAGAS MEDIA', 2001, 10),
('BK0003', 'SEPATU DAHLAN', 'KHRISNA PABICHARA', 'NOURA BOOKS', 2000, 10),
('BK0004', 'DEAR NATHAN', 'ERISKA FEBRIANTI', 'BEST MEDIA', 2001, 10),
('BK0005', 'SANG PEMIMPI', 'ANDREA HIRATA', 'BENTENG PUSTAKA', 2002, 10),
('BK0006', 'Metode Penelitian Kualitatif', 'Sugiyono', 'Alfabeta', 2017, 10),
('BK0007', 'Metode Penelitian Kuantitatif', 'Sugiyono', 'Alfabet', 2018, 10),
('BK0008', 'Kultur Jaringan : Teori Dan Praktek', 'Yusnita', 'ANDI', 2019, 10),
('BK0009', 'Stategi meningkatkan Daya Baca', 'Nurhadi', 'Bumi Aksara', 2016, 10),
('BK0010', 'Teknik Pengerjaan Listrik Edisi Revisi', 'Daryanto', 'Bumi Aksara', 2016, 10),
('BK0011', 'Menguasai Statistik dengan SPSS 25', 'Singgih Santoso', 'Elex Media Komputer', 2018, 10),
('BK0012', 'Ilmu Ekonomi MIkro', 'Dr.Erlina Rufaidah,M.Si, Drn.Nurdin,M.Si', 'Expert', 2017, 10),
('BK0013', 'Ilmu Menjual Edisi 2', 'Prof.Dr.H.Zulkarnain,M.M.', 'Expert', 2018, 10),
('BK0014', 'Jasa Pariwisata', 'Dr.Diena Mutiara Lemy,A.Par.,M.M.', 'Explore', 2018, 10),
('BK0015', 'Manajemen Penilaian Kinerja Kariawan', 'Bintaro, Daryono', 'Gava Media', 2017, 10),
('BK0016', 'Biomekanika Olahraga', 'I Nyoman Sudarmada,S.Or.,M.Or.,dr.Made Kusuma Wijaya,s.Ked.,M.Kes', 'Graha Ilmu', 2015, 10),
('BK0017', 'Panduan Berolahraga untuk Kesehatan dan Kebugaran', 'Giri Wiarto', 'Graha Ilmu', 2015, 10),
('BK0018', 'Pendidikan Kependudukan dan Lingkungan Hidup', 'Drs.Arwin Surbakti,M.Si.', 'Graha Ilmu', 2015, 10),
('BK0019', 'Teori Belajar dan Pembelajaran', 'Drs.Maskun,M.H.,Valensy Rachmedita,M.Pd.', 'Graha Ilmu', 2016, 10),
('BK0020', 'Mekanika Kekuatan Material Edisi 2', 'Ir.Ramses Yohannes Hutahaean,MT.', 'Graha Ilmu', 2017, 10),
('BK0021', 'Rekayasa Lalu Lintas', 'Leksmono Suryo Putranto', 'Indeks', 1905, 10),
('BK0022', 'Energi Terbarukan', 'Dr.Ir.Agus Haryanto,MP.', 'Innosain', 2017, 10),
('BK0023', 'Geologi Lingkungan', 'Imam Subekti', 'Mobius', 2018, 10),
('BK0024', 'Ilmu Lingkungan Edisi 2', 'H.R.Mulyanto,Ir.,Dipl.H.E', 'Mobius', 2018, 10),
('BK0025', 'Mikrobiologi Pangan', 'Rifda Naufalin', 'Plantaxia', 2018, 10),
('BK0026', 'Penyuluhan Pertanian', 'Helena Tatcher Pakpahan,S.P.,M.Si.', 'Plantaxia', 2017, 10),
('BK0027', 'E-Lerning dan Sistem Informasi Pendidikan Edisi 2', 'Prof.Richardus Eko Indrajit', 'Preinexus', 2016, 10),
('BK0028', 'Gender dan Pendidikan Multikultural', 'Siti Fatimah,Wirdanengsih', 'Prenada Media Group', 2016, 10),
('BK0029', 'Kebijakan Publik Di Indonesia', 'Riant Nugroho', 'Pustaka Pelajar', 2016, 10),
('BK0030', 'Penulisan Buku Ajar Perguruan Tinggi', 'Wahyu Wibowo', 'RajaGrafindo', 2016, 10),
('BK0031', 'Manajemen Kompensasi', 'M.Kadarisman', 'RajaGrafindo', 2017, 10),
('BK0032', 'Pengadaan Barang Dan Jasa', 'Ade Maman Suherman', 'RajaGrafindo', 2017, 10),
('BK0033', 'Stategi Kreatif Dalam Periklanan', 'Rama Kertamukti', 'RajGrafindo', 2017, 10),
('BK0034', 'Ilmu Komunikasi Ilmiah Dan Populer', 'Nurudin', 'RajaGrafindo', 2017, 10),
('BK0035', 'Metodologi Penelitian (Sudaryono)', 'Sudaryono', 'RajaGrafindo', 2017, 10);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbldetailkembali`
--

CREATE TABLE `tbldetailkembali` (
  `NoKembali` varchar(15) NOT NULL,
  `KodeBuku` varchar(7) NOT NULL,
  `JumlahBuku` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbldetailpinjam`
--

CREATE TABLE `tbldetailpinjam` (
  `NoPinjam` varchar(15) NOT NULL,
  `KodeBuku` varchar(7) NOT NULL,
  `JumlahBuku` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblkembali`
--

CREATE TABLE `tblkembali` (
  `NoKembali` varchar(15) NOT NULL,
  `TglKembali` date NOT NULL,
  `TotalKembali` int(12) NOT NULL,
  `Denda` decimal(12,0) NOT NULL,
  `DiBayar` decimal(12,0) NOT NULL,
  `Kembali` decimal(12,0) NOT NULL,
  `KodeAnggota` varchar(7) NOT NULL,
  `NamaPetugas` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblpetugas`
--

CREATE TABLE `tblpetugas` (
  `KodePetugas` varchar(7) NOT NULL,
  `NamaPetugas` varchar(100) NOT NULL,
  `PasswordPetugas` varchar(10) NOT NULL,
  `StatusPetugas` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tblpetugas`
--

INSERT INTO `tblpetugas` (`KodePetugas`, `NamaPetugas`, `PasswordPetugas`, `StatusPetugas`) VALUES
('PTG0032', 'MAHADIR', 'ADMIN', 'ADMIN');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblpinjam`
--

CREATE TABLE `tblpinjam` (
  `NoPinjam` varchar(15) NOT NULL,
  `TglPinjam` date NOT NULL,
  `JamPinjam` varchar(10) NOT NULL,
  `KodeAnggota` varchar(7) NOT NULL,
  `ItemPinjam` int(12) NOT NULL,
  `TotalPinjam` int(12) NOT NULL,
  `NamaPetugas` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tblanggota`
--
ALTER TABLE `tblanggota`
  ADD PRIMARY KEY (`KodeAnggota`);

--
-- Indeks untuk tabel `tblbuku`
--
ALTER TABLE `tblbuku`
  ADD PRIMARY KEY (`KodeBuku`);

--
-- Indeks untuk tabel `tblkembali`
--
ALTER TABLE `tblkembali`
  ADD PRIMARY KEY (`NoKembali`);

--
-- Indeks untuk tabel `tblpetugas`
--
ALTER TABLE `tblpetugas`
  ADD PRIMARY KEY (`KodePetugas`);

--
-- Indeks untuk tabel `tblpinjam`
--
ALTER TABLE `tblpinjam`
  ADD PRIMARY KEY (`NoPinjam`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
