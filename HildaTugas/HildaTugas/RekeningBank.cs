using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HildaTugas
{
    internal class RekeningBank
    {
        public int BankID;
        public string nama_pemilik, nama_bank;
        
        public RekeningBank(int bankID, string namaPemilik,string namaBank)
        {
            BankID = bankID;
            nama_pemilik = namaPemilik;
            nama_bank = namaBank;
        }
        
        public void printBank()
        {
            Console.WriteLine($"id_bank : "+BankID);
            Console.WriteLine($"nama pemilik : "+nama_pemilik);
            Console.WriteLine($"nama_bank : "+nama_bank);
        }

    }
    class nasional_bank : RekeningBank 
    {
        public bool IsBumn;

        public nasional_bank (bool isBumn, int bankID, string namaPemilik, string namaBank) 
            : base(bankID, namaPemilik, namaBank)
        {
            this.IsBumn = isBumn;
        }

        public void printBank()
        {
            base.printBank();
            Console.WriteLine($"apakah perusahaan Bumn : " + IsBumn);
        }
    }
    class internasional_bank : RekeningBank
    {
        public bool HasCompany;

        public internasional_bank(bool HasCompany, int bankID, string namaPemilik, string namaBank)
            : base(bankID, namaPemilik, namaBank)
        {
            this.HasCompany = HasCompany;
        }

        public void printBank()
        {
            base.printBank();
            Console.WriteLine($"Punya Cabang perusahaan di indonesia : " + HasCompany);
        }
    }
}
