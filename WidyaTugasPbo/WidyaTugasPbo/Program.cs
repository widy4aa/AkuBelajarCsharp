using WidyaTugasPbo.Tugas02;
using WidyaTugasPbo.Tugas03;

namespace WidyaTugasPbo
{
    class Programs
    {
        public static void Main(string[] args)
        {
         /*   Console.WriteLine("SuperClass Car ---------------------------");
            MobilSedan skyline = new MobilSedan("Toyota", "Dyo", "Sedan", 2, 65, 4,true,true);
            skyline.info();
            MobilTruck Mitsubishi = new MobilTruck("Mitsubishi", "Dyo", "Truck", 2, 65, 4,30);
            Mitsubishi.info();

            Console.WriteLine("\nSuperclass Ikan --------------------------");
            IkanAirAsin Tongkol = new IkanAirAsin(true, "tongkol", "Ikan Laut", "Silver");
            Tongkol.info();
            IkanAirTawar Lele = new IkanAirTawar(true, "Lele", "Ikan Sungai", "Hitam");
            Lele.info();

            Console.WriteLine("\nSuperclass PionCatur --------------------------");
            King RajaPutih = new King(false, "Putih", "Raja");
            RajaPutih.info();
            Pawn PawnHitam = new Pawn("Queen", "Black", "Budak");
            PawnHitam.info();

            Console.WriteLine("\nSuperclass RekeningBank --------------------------");
            RekeningFisik Rekening1 = new RekeningFisik("CC28216217", 2025,2324147,"BRI","Widya Fitriadi Nugraha");
            Rekening1.info();
            VirtualAcount Va1 = new VirtualAcount("VA21273974", 2324147, "BRI", "Widya Fitriadi Nugraha");
            Va1.info();
         */
            Console.WriteLine("\nSuperclass Otomobil --------------------------");
            sedan lancer = new sedan(true, "Dyo", "lancer", 4);
            lancer.info();
            truk Go = new truk(true, "Dyo", "Go", 6);
            Go.info();
            motor cb = new motor(false, "Dyo", "Honda", 2);
            cb.info();
        }
    }
}