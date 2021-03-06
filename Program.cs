using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiuas2377
{
    class Program
    {
        static List<Penjualan> daftarProduk = new List<Penjualan>();
        static Penjualan pjln = new Penjualan();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        TampilProduk();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilihan Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar\n");
        }

        static void TambahProduk()
        {
            Console.Clear();
            pjln = new Penjualan();
            Console.WriteLine("Tambah data Penjualan\n");
            Console.Write("Nota   : ");
            pjln.Nota = Console.ReadLine();
            Console.Write("Tanggal   : ");
            pjln.Tanggal = Console.ReadLine();
            Console.Write("Customer  : ");
            pjln.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K]   : ");
            pjln.Jenis = Console.ReadLine() == "T" ? "Tunai" : "Kredit";
            Console.Write("Total Nota   : ");
            pjln.TotalNota = Console.ReadLine();
            daftarProduk.Add(pjln);
        
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }


        static void TampilProduk()
        {
            Console.Clear();

            int no = 1;
            Console.WriteLine("Data Penjualan\n");
            foreach (Penjualan objProd in daftarProduk)
            {
                Console.WriteLine("{0}.{1},{2},{3},{4},{5}", no, objProd.Nota, objProd.Tanggal, objProd.Customer, objProd.Jenis, objProd.TotalNota);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}