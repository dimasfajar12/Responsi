using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman3368
{
    class Karyawan
    {
        private int nik;
        private string nama;
        private int gajiBulanan;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public int Nik
        {
            get { return nik; }
            set { nik = value; }
        }
        public int GajiBulanan
        {
            get { return gajiBulanan; }
            set { gajiBulanan = value; }
        }

        public Karyawan(string nama, int nik, int gajiBulanan)
        {
            Nik = nik;
            Nama = nama;
            if (gajiBulanan <= 0)
            {
                GajiBulanan = 0;
            }
            else
            {
                GajiBulanan = gajiBulanan;
            }

        }




        public int PeningkatanGaji(int gajiBulanan)
        {
            GajiBulanan = gajiBulanan + ((gajiBulanan / 100) * 10);

            return 0;
        }

    }
}