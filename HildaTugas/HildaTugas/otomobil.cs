using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HildaTugas
{
    internal class otomobil
    {
        public string jenis_kendaraan,merek;

        public otomobil(string jenis_kendaraan,string merek)
        {
            this.jenis_kendaraan = jenis_kendaraan;
            this.merek = merek;
        }

        public void print()
        {
            Console.WriteLine($"Jenis Kendaraan : "+jenis_kendaraan);
            Console.WriteLine($"merek : " + merek);
        }
    }

    class sedan : otomobil
    {
        public bool PunyaNos;

        public sedan(bool PunyaNos, string jenis_kendaraan, string merek) : base(jenis_kendaraan,merek)
        {
            this.PunyaNos = PunyaNos;
        }

        public void print()
        {
            Console.WriteLine($"Punya Nos" + PunyaNos);
        }
    }
    class truk : otomobil
    {
        public bool bag;

        public truk(bool bag, string jenis_kendaraan, string merek) : base(jenis_kendaraan, merek)
        {
            this.bag = bag;
        }

        public void print()
        {
            Console.WriteLine($"Punya bag : " + bag);
        }
    }

    class motor : otomobil 
    {
        public bool pintu;

        public motor(bool pintu, string jenis_kendaraan, string merek) : base(jenis_kendaraan, merek)
        {
            this.pintu = pintu;
        }

        public void print()
        {
            Console.WriteLine($"Punya bag : " + pintu);
        }

    }
}
