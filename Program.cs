using ResponsiPemograman3368;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman3398
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("Paijo", 190302123, 3000000);
            Karyawan karyawan2 = new Karyawan("Jono", 190302124, 2000000);

            Console.WriteLine("No Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(1 + ". " + karyawan1.Nik + " " + karyawan1.Nama + "\t" + String.Format("{0:n0}", karyawan1.GajiBulanan));
            Console.WriteLine(2 + ". " + karyawan2.Nik + " " + karyawan2.Nama + "\t" + String.Format("{0:n0}", karyawan2.GajiBulanan));


            Console.WriteLine("Alhamdulillah dapat kenaikan gaji 10%");
            karyawan1.PeningkatanGaji(karyawan1.GajiBulanan);
            karyawan2.PeningkatanGaji(karyawan2.GajiBulanan);

            Console.WriteLine("No Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(1 + ". " + karyawan1.Nik + " " + karyawan1.Nama + "\t" + String.Format("{0:n0}", karyawan1.GajiBulanan));
            Console.WriteLine(2 + ". " + karyawan2.Nik + " " + karyawan2.Nama + "\t" + String.Format("{0:n0}", karyawan2.GajiBulanan));



            Console.ReadKey();
        }
    }
}
