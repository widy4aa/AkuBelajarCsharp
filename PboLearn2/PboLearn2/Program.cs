// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Lingkaran linkaranCui =  new Lingkaran(7);
        linkaranCui.LuasLingkaran();

        Tabung tabungCui = new Tabung:Lingkaran(7);
    }
}

class Lingkaran
{
    public double r;
    public int luas;

    public Lingkaran(double r)
    {
        this.r = r;
    }


    public int LuasLingkaran ()
    {
        double luas = 3.14 * this.r * this.r;
        return (int)luas;
    }
}

class Tabung : Lingkaran
{
    public double Tinggi;
    public  Tabung(double r, double tinggi) : base(r)
    {
        this.Tinggi = tinggi;
    }

    public int VolumeTabung()
    {
        double volume=base.LuasLingkaran()*Tinggi;
        Console.WriteLine($"volume");
        return(int)volume;
    }
}