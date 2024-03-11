namespace WidyaTugasPbo
{
    class Programs
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SuperClass Car ---------------------------");
            Sedan skyline = new Sedan("Toyota", "Dyo", "Sedan", 2, 65, 4,true,true);
            skyline.info();
            Truck Mitsubishi = new Truck("Mitsubishi", "Dyo", "Truck", 2, 65, 4,30);
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

        }
    }
}