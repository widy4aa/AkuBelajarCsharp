using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidyaTugasPbo.Tugas02
{
    //Superclass Car
    internal class Car
    {
        public string Merek, NamaPemilik, Jenis;
        public int JumlahPintu, KapasitasBensin, JumlahRoda;

        public Car(string merek, string namaPemilik, string jenis, int jumlahPintu, int kapasitasBensin, int jumlahRoda)
        {
            Merek = merek;
            NamaPemilik = namaPemilik;
            Jenis = jenis;
            JumlahPintu = jumlahPintu;
            KapasitasBensin = kapasitasBensin;
            JumlahRoda = jumlahRoda;
        }
        public void info()
        {
            Console.WriteLine($"Merek : " + Merek);
            Console.WriteLine($"Nama Pemilik: " + NamaPemilik);
        }
    }
    //SubClass
    class MobilSedan : Car
    {
        public bool NosInclude, TurboInclude;

        public MobilSedan(string merek, string namaPemilik, string jenis, int jumlahPintu, int kapasitasBensin, int jumlahRoda, bool nosInclude, bool turboInclude)
            : base(merek, namaPemilik, jenis, jumlahPintu, kapasitasBensin, jumlahRoda)
        {
            NosInclude = nosInclude;
            TurboInclude = turboInclude;
        }

        public void info()
        {
            Console.WriteLine($"Subclass Mobil sedan ---");
            base.info();
            Console.WriteLine($"apakah ada nos nya :" + NosInclude);
            Console.WriteLine($"apakah memiliki Tubo didalamnya :" + TurboInclude);
        }
    }

    class MobilTruck : Car
    {
        public int UkuranBag;

        public MobilTruck(string merek, string namaPemilik, string jenis, int jumlahPintu, int kapasitasBensin, int jumlahRoda, int ukuranBag)
            : base(merek, namaPemilik, jenis, jumlahPintu, kapasitasBensin, jumlahRoda)
        {
            UkuranBag = ukuranBag;
        }

        public void info()
        {
            Console.WriteLine($"\nSubclass Mobil Truck ---");
            base.info();
            Console.WriteLine($"Ukuran Bag nya : " + UkuranBag + "ton");
        }
    }
}
