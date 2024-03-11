using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidyaTugasPbo
{
    //Superclass Car
    internal class Car
    {
        public string Merek, NamaPemilik, Jenis;
        public int JumlahPintu, KapasitasBensin, JumlahRoda;

        public Car(string merek, string namaPemilik, string jenis, int jumlahPintu, int kapasitasBensin, int jumlahRoda)
        {
            this.Merek = merek;
            this.NamaPemilik = namaPemilik;
            this.Jenis = jenis;
            this.JumlahPintu = jumlahPintu;
            this.KapasitasBensin = kapasitasBensin;
            this.JumlahRoda = jumlahRoda;
        }
        public void info()
        {
            Console.WriteLine($"Merek : " + Merek);
            Console.WriteLine($"Nama Pemilik: " + NamaPemilik);
        }
    }
    //SubClass
    class Sedan : Car
    {
        public Boolean NosInclude, TurboInclude;

        public Sedan(string merek, string namaPemilik, string jenis, int jumlahPintu, int kapasitasBensin, int jumlahRoda, bool nosInclude, bool turboInclude)
            : base(merek, namaPemilik, jenis, jumlahPintu, kapasitasBensin, jumlahRoda)
        {
            NosInclude = nosInclude;
            TurboInclude = turboInclude;
        }

        public void info()
        {
            Console.WriteLine($"Subclass Mobil sedan ---");
            base.info();
            Console.WriteLine($"apakah ada nos nya :"+NosInclude);
            Console.WriteLine($"apakah memiliki Tubo didalamnya :" + TurboInclude);
        }
    }

    class Truck : Car
    {
        public int UkuranBag;

        public Truck (string merek, string namaPemilik, string jenis, int jumlahPintu, int kapasitasBensin, int jumlahRoda, int ukuranBag) 
            : base(merek, namaPemilik, jenis, jumlahPintu, kapasitasBensin, jumlahRoda)
        {
            UkuranBag = ukuranBag;
        }

        public void info()
        {
            Console.WriteLine($"\nSubclass Mobil Truck ---");
            base.info();
            Console.WriteLine($"Ukuran Bag nya : "+UkuranBag+"ton");
        }
    }
}
