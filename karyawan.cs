using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrogaman3421
{
    class karyawan
    {
        public int NIK { get; set; }
        public string Nama { get; set; }
        public float gajibulanan { get; set; }
        
        public karyawan (int NIK, string Nama, float gajibulanan)
        {
            if (gajibulanan < 0)
            {
                this.gajibulanan = 0;
            }
            else
            {
                this.gajibulanan = gajibulanan;
            }
            this.NIK = NIK;
            this.Nama = Nama;
        }
        public static void kenaikangaji(karyawan kra1,karyawan  kra2)
        {
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine(" Anda mendapatkan kenaikan gaji sebanyak 10% ");
            Console.WriteLine("---------------------------------------\n");
            kra1.gajibulanan += kra1.gajibulanan * 10 / 100;
            kra2.gajibulanan += kra2.gajibulanan * 10 / 100;
        }
        public static void menampilkan(karyawan kra1, karyawan kra2)
        {
            Console.WriteLine("No Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("1  {0} {1}\t{2}", kra1.NIK, kra1.Nama, kra1.gajibulanan);
            Console.WriteLine("2  {0} {1}\t{2}", kra2.NIK, kra2.Nama, kra2.gajibulanan);
        }
    }
}
