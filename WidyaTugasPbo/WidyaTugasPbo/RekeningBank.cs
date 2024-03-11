using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidyaTugasPbo
{
    internal class RekeningBank
    {
        public int id_rekening;
        public string name,pemilik;

        public RekeningBank(int id_rekening, string name, string pemilik)
        {
            this.id_rekening = id_rekening;
            this.name = name;
            this.pemilik = pemilik;
        }   
        public void info()
        {
            Console.WriteLine($"id rekening nya adalah : " + id_rekening);
            Console.WriteLine($"Nama Bank : " + name);
            Console.WriteLine($"Nama Pemilik rekening : " + pemilik);
        }
    }

    class RekeningFisik : RekeningBank 
    {
        public string IdRekeningCard;
        public int ExpCard;

        public RekeningFisik(string idRekeningCard, int expCard, int id_rekening, string name, string pemilik) 
            : base(id_rekening,name,pemilik)
        {
            IdRekeningCard = idRekeningCard;
            ExpCard = expCard;
        }

        public void info()
        {
            Console.WriteLine($"Subclass Rekening Fisik ---");
            base.info();
            Console.WriteLine($"id card nya : " + IdRekeningCard);
            Console.WriteLine($"exp card nya : " + ExpCard);
        }
    }

    class VirtualAcount : RekeningBank
    {
        public string IdVa;

        public VirtualAcount(string idVa,int id_rekening, string name, string pemilik) : base(id_rekening,name, pemilik)
        {   
            IdVa = idVa;
        }

        public void info()
        {
            Console.WriteLine($"\nSubclass Virtual Account ---");
            base.info();
            Console.WriteLine($"Id Virtual Account: " + IdVa);
        }

     }
}
