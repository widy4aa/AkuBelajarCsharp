using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HildaTugas
{
    internal class PionCatur
    {
       public string jenis, warna;

       public PionCatur (string jenis, string warna)
        {
            this.jenis = jenis;
            this.warna = warna;
        }
        
        public void printCatur()
        {
            Console.WriteLine($"Jenis Pion : " + jenis);
            Console.WriteLine($"Warna Pion : " + warna);
        }
    }

    class pionPetinggi : PionCatur 
    {
        public bool isimportant;
        
        public pionPetinggi (string jenis, string warna,bool isimportant) :base(jenis,warna)
        {
            this.isimportant = isimportant;
        }
        public void printCatur()
        {
            base.printCatur();
            Console.WriteLine($"Apakah Penting : " + isimportant);
        }
    }
    class PionBudak : PionCatur
    {
        public string KenaikanPangkat;

        public PionBudak(string jenis, string warna, string KenaikanPangkat) : base(jenis, warna)
        {
            this.KenaikanPangkat = KenaikanPangkat;
        }
        public void printCatur()
        {
            base.printCatur();
            Console.WriteLine($" Naik Pangkat Menjadi: " + KenaikanPangkat);
        }
    }
}
