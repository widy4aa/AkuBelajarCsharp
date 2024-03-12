using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidyaTugasPbo.Tugas02
{
    internal class PionCatur
    {
        string Warna, Nama;
        public PionCatur(string Warna, string Nama)
        {
            this.Warna = Warna;
            this.Nama = Nama;
        }

        public void info()
        {
            Console.WriteLine($"PionCatur Dengan Nama : " + Nama);
            Console.WriteLine($"PionCatur Dengan Warna : " + Warna);
        }
    }

    class King : PionCatur
    {
        public bool KondisiCheck;
        public King(bool KondisiCheck, string Warna, string Nama)
           : base(Warna, Nama)
        {
            this.KondisiCheck = KondisiCheck;
        }
        public void info()
        {
            Console.WriteLine($"Subclass Pion Raja ---");
            base.info();
            Console.WriteLine($"Keadaan : " + KondisiCheck);
        }
    }

    class Pawn : PionCatur
    {
        public string PromoteTo;
        public Pawn(string PromoteTo, string Warna, string Nama)
           : base(Warna, Nama)
        {
            this.PromoteTo = PromoteTo;
        }
        public void info()
        {
            Console.WriteLine($"\nSubclass Pion Pawn ---");
            base.info();
            Console.WriteLine($"Akan Di Promosikan Menjadi: " + PromoteTo);
        }
    }
}
