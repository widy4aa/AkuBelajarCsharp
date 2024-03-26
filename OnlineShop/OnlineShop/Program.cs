// See https://aka.ms/new-console-template for more information

//    Online shop: Terdapat produk dengan berbagai kategori. Informasi dasar tentang produk meliputi nama dan harga. 
//    Terdapat kategori barang elektronik. Berat barang elektronik mempengaruhi ongkos kirim. Terdapat kategori baju dan pakaian dengan ongkos kirim tetap senilai x rupiah. 
//    Terdapat kategori buku dengan ongkos kirim tetap senilai y rupiah. 
//    Terdapat keranjang belanja yang mampu menampung daftar produk dan mampu menghitung total harga dari item-item di dalam keranjang.

namespace OnlineShop {
    class Program {
        public static void Main(string[] args)
        {
              Elektronik tv = new Elektronik("tv",3,2000);
              PakaianBaju bajutidur = new PakaianBaju("spider suit", 200000);
              Buku bukugambar = new Buku("buku gambar", 5000);
              tv.Print();
              bajutidur.print();
              bukugambar.print();


              KeranjangBelanja keranjang = new KeranjangBelanja();
              keranjang.TambahProduk(tv);
              keranjang.TambahProduk(bajutidur);
              keranjang.TambahProduk(bukugambar);


              keranjang.print();


        }
    }
}