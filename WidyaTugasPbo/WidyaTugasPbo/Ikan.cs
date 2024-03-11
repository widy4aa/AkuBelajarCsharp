using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidyaTugasPbo
{
    internal class ikan
    {
        public string nama, jenis, warna;
        public ikan(string nama,string jenis,string warna)
        {
            this.nama = nama;
            this.jenis = jenis;
            this.warna = warna;
        }
        public void info()
        {
            Console.WriteLine($"Nama : " + nama);
            Console.WriteLine($"Jenis : " + jenis);
            Console.WriteLine($"Warna: " + warna);
        }
    }

    class IkanAirTawar : ikan
    {
        public bool HidupDiSungai;
        public IkanAirTawar(bool hidupDiSungai, string nama, string jenis, string warna)
           : base(nama,jenis,warna)
        {
            HidupDiSungai = hidupDiSungai;
        }
        public void info()  
        {
            Console.WriteLine($"\nSubclass Ikan Air Tawar ---");
            base.info();
            Console.WriteLine($"HidupDiSungai: " + HidupDiSungai);
        }
    }

    class IkanAirAsin : ikan
    {
        public bool HidupDiLaut;
        public IkanAirAsin(bool hidupDiLaut, string nama, string jenis, string warna)
           : base(nama, jenis, warna)
        {
            HidupDiLaut = hidupDiLaut ;
        }
        public void info()
        {
            Console.WriteLine($"Subclass Ikan Laut ---");
            base.info();
            Console.WriteLine($"HidupDiLaut: " + HidupDiLaut);
        }
    }

}
