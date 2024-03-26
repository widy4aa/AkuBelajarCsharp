using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

/*Sistem perbankan: Sistem bank mencatat daftar rekening yang dimiliki nasabahnya. 
    Rekening dapat berupa rekening tabungan dan rekening giro. 
    Rekening dapat dikenai penarikan dan penyetoran serta cek saldo. 
    Rekening tabungan dapat memiliki bunga yang dimasukkan ke rekening tiap awal bulan. 
    Rekening giro dapat melayani penarikan melebihi saldo tersedia dengan batas tertentu.*/

namespace perbankan
{
    class rekening
    {
        public string namaRekening;
        public int saldoTunai;
        private int Saldo;


        public rekening(string namaRekening)
        {
            this.namaRekening = namaRekening;
        }

        public int SaldoRekening
        {
            get { return Saldo; }
            set { Saldo = value; }
        }
        public void storan(int storan) 
        {
            SaldoRekening += storan;
        }

        public void cekSaldo(int saldo)
        {
            Console.WriteLine("Saldo anda sekarang adalah Rp. "+saldo);
        }

        public void cekSaldo()
        {

            Console.WriteLine("Rekening anda dengan nama " + this.namaRekening + " \nMemiliki Saldo Sebesar Rp." + SaldoRekening);
        }
        public virtual void tarikTunai(int tarik)
        {
            if (this.SaldoRekening >= tarik)
            {
                this.SaldoRekening -= tarik;
                Console.WriteLine("Anda menarik saldo sejumlah Rp." + tarik);
            }

            if (this.SaldoRekening <= tarik)
            {
                Console.WriteLine("Saldo tidak mencukupi untuk menarik sejumlah Rp." + tarik);
            }
        }
    }

    class tabungan : rekening
    {
        private int bungaPersen,bulan;
        

        public tabungan(string namaRekening): base(namaRekening)
        {
            this.namaRekening = namaRekening;
            this.bungaPersen = 3;
        }

        public void SaldoAkhirBulan()
        {
            for (int i = 0; i < bulan; i++)
            {
                SaldoRekening += SaldoRekening*bungaPersen/100 ;
            }

        }

        public void storanTabungan(int storan)
        {
            Console.WriteLine($"anda mengstor uang ke {namaRekening} sebesar Rp.{storan}");
            base.storan(storan);
        }

        public void menabungBerapaBulan(int bulan)
        {
            Console.WriteLine($"anda menabung uang ke {namaRekening} selama {bulan} dengan bunga {bungaPersen}%");
            this.bulan = bulan;
        }


    }

    class giro : rekening
    {
        private int limitTarikTunai;

        public giro(string namaRekening) : base(namaRekening)
        {
            this.limitTarikTunai = 20000;
        }
        public void storanGiro(int storan)
        {
            Console.WriteLine($"anda mengstor uang ke {namaRekening} sebesar Rp.{storan}");
            base.storan(storan);
        }
        public void tarikTunai(int tarik)
        {
            int saldoLimit = SaldoRekening + limitTarikTunai;
            if ((this.SaldoRekening+this.limitTarikTunai) >= tarik)
            {
                this.SaldoRekening -= tarik;
                Console.WriteLine("Anda menarik saldo sejumlah Rp." + tarik);
            }

            if ((this.SaldoRekening + this.limitTarikTunai) <= tarik)
            {
                Console.WriteLine("limit dari giro hanya Rp"+limitTarikTunai);
                Console.WriteLine("Saldo tidak mencukupi untuk menarik sejumlah Rp." + tarik);
            }
        }

    }
}
