/*Sistem perbankan: Sistem bank mencatat daftar rekening yang dimiliki nasabahnya. 
    Rekening dapat berupa rekening tabungan dan rekening giro. 
    Rekening dapat dikenai penarikan dan penyetoran serta cek saldo. 
    Rekening tabungan dapat memiliki bunga yang dimasukkan ke rekening tiap awal bulan. 
    Rekening giro dapat melayani penarikan melebihi saldo tersedia dengan batas tertentu.*/

namespace perbankan { 
    
    class programs
    {
        public static void Main(String[] args)
        {
            //Tabungan
            tabungan tabugancui = new tabungan("bri");
            Console.WriteLine("--Rekening Tabungan");
            tabugancui.storanTabungan(200000);
            tabugancui.SaldoAkhirBulan();
            tabugancui.menabungBerapaBulan(10);
            tabugancui.SaldoAkhirBulan();
            tabugancui.cekSaldo();
            tabugancui.tarikTunai(2000);
            tabugancui.cekSaldo();

            //Giro
            giro girocui = new giro("BCA");
            Console.WriteLine("\n\n--Rekening GIRO");
            girocui.storanGiro(10000000);
            girocui.storanGiro(10000000);
            girocui.cekSaldo();
            girocui.tarikTunai(20000001);
            girocui.cekSaldo();
            girocui.tarikTunai(20000001);




        }
    }
 
}