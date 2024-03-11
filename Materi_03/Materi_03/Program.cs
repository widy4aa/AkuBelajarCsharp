namespace Materi_03
{
  class Taxi
    {
        public bool Pertanyaan;
        public Taxi() 
        {
            Pertanyaan = true;
        }
    }

    class TestTaxi
    {
        static void Main()
        {
            Taxi t = new Taxi();
            Console.WriteLine(t.Pertanyaan);
        }
    }
}
