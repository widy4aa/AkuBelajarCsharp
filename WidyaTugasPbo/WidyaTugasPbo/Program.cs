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
        }
    }
}