using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidyaTugasPbo.Tugas03
{
    internal class otomobil
    {
        public string merek,namapemilik;
        public int jumlahRoda;

        public otomobil(string namaPemilik, string merek, int jumlahRoda)
        {
            namapemilik= namaPemilik;
            this.merek = merek;
            this.jumlahRoda = jumlahRoda;
        }

        public void info()
        {
            Console.WriteLine($"Merek Kenderaan : "+merek);
            Console.WriteLine($"Nama Pemiliknya : " + namapemilik);
            Console.WriteLine($"Memiliki Jumlah Roda : " + jumlahRoda);
        }
    }

    class sedan : otomobil
    {
        public bool PunyaRoofTop;

        public sedan(bool punyaRoofTop,string namaPemilik, string merek, int jumlahRoda) : base(namaPemilik,merek,jumlahRoda)
        {
            PunyaRoofTop = punyaRoofTop;
        }

        public void info()
        {
            Console.WriteLine($"\nSubclass sedan ---");
            base.info();
            Console.WriteLine($"Rooftop : " + PunyaRoofTop);
        }
    }
    class truk : otomobil
    {
        public bool bag;

        public truk(bool bag, string namaPemilik, string merek, int jumlahRoda) : base(namaPemilik, merek, jumlahRoda)
        {
            this.bag = bag;
        }

        public void info()
        {
            Console.WriteLine($"\nSubclass truk ---");
            base.info();
            Console.WriteLine($"bag : " + bag);
        }
    }

    class motor : otomobil
    {
        public bool pintu;

        public motor(bool pintu, string namaPemilik, string merek, int jumlahRoda) : base(namaPemilik, merek, jumlahRoda)
        {
            this.pintu = pintu;
        }

        public void info()
        {
            Console.WriteLine($"\nSubclass motor ---");
            base.info();
            Console.WriteLine($"Punya Pintu : " + pintu);
        }

    }
}
