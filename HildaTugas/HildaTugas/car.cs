using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HildaTugas
{
    internal class car
    {
        string merek, nama_pemilik, warna;
        public car(string merek, string nama_pemilik, string warna)
        {
            this.merek = merek;
            this.nama_pemilik = nama_pemilik;
            this.warna = warna;
        }

        public void printCar()
        {
            Console.WriteLine($"merek :"+merek);
            Console.WriteLine($"nama pemilik :" +nama_pemilik);
            Console.WriteLine($"warna :" + warna);
        }
    }

    class  mobilsedan : car
    {
        public bool PunyaNos;

        public mobilsedan(bool punyaNos, string merek, string nama_pemilik, string warna) : base(merek, nama_pemilik, warna)
        {
            PunyaNos = punyaNos;
        }

        public void PrintCar()
        {
            base.printCar();
            Console.WriteLine($"PunyaNos : " + PunyaNos);
        }
    }

    class mobiltruk : car
    {
        public int ukuran_bag;
        public mobiltruk(int ukuran_bag, string merek, string nama_pemilik, string warna) : base(merek, nama_pemilik, warna)
        {
            this.ukuran_bag = ukuran_bag;
        }
        public void PrintCar()
        {
            base.printCar();
            Console.WriteLine($"ukuran bag : ");
        }
    }
}
