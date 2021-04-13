using System;

namespace ResponsiPemrogaman3421
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan karyawan1 = new karyawan(11563344, "Anna", 3000000);
            karyawan karyawan2 = new karyawan(18925345, "Jeno", 2000000);

            karyawan.menampilkan(karyawan1, karyawan2);
            karyawan.kenaikangaji(karyawan1, karyawan2);
            karyawan.menampilkan(karyawan1, karyawan2);

            Console.ReadKey();
        }
    }
}