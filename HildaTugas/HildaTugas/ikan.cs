using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HildaTugas
{
    internal class ikan
    {
        public string nama, jenis;
        public bool MasihHidup;

        public ikan (string nama, string jenis, bool masihHidup)
        {
            this.nama = nama;
            this.jenis = jenis;
            MasihHidup = masihHidup;
        }

        public void PrintIkan()
        {
            System.Console.WriteLine($"nama ikan : " + nama);
            System.Console.WriteLine($"jenis ikan : " + jenis);
            System.Console.WriteLine($"Status Kehidupan :" + MasihHidup);
        }
    }

    class IkanBudidaya : ikan 
    {
        string TempatBudidaya;
        
        public IkanBudidaya (string TempatBudidaya,string nama, string jenis, bool masihHidup) : base (nama,jenis,masihHidup)
        {
            this.TempatBudidaya = TempatBudidaya;
        }

        public void PrintIkan()
        {
            base.PrintIkan();
            System.Console.WriteLine($"Tempat Budidaya :" + TempatBudidaya);
        }
    }

    class IkanLiar : ikan
    {
        public bool isdanger;

        public IkanLiar(bool isdanger, string nama, string jenis, bool masihHidup) : base(nama, jenis, masihHidup)
        {
            this.isdanger = isdanger;
        }

        public void PrintIkan()
        {
            base.PrintIkan();
            System.Console.WriteLine($"Ga bahaya tah : "+isdanger);
        }
    }
}
