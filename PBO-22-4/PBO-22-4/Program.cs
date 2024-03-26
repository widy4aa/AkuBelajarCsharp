using System.Net.NetworkInformation;

class program
{
    public static void Main(string[] args)
    {
        Mahasiswa mahasiswa = new Mahasiswa();
        mahasiswa.IdBarang = "cui";
        Console.WriteLine($"mahasiswa id : " + mahasiswa.IdBarang);
    }
}

class Mahasiswa
{
    private string idbarang;

    public string IdBarang
    {
        get { return this.idbarang;  }
        set { this.idbarang = value; }
    }
}