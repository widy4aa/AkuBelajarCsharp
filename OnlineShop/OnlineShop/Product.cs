using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Product
    {
        public string namaProduct;
        public int hargaProduct;
        protected int hargaOngkir, hargaTotal;

        public Product(string namaProduct, int hargaProduct)
        {
            this.namaProduct = namaProduct;
            this.hargaProduct = hargaProduct;
        }

        public int HargaTotal
        {
            get { return hargaTotal; }
            set { hargaTotal = this.hargaTotal; }
        }
    }

    class Elektronik : Product
    {
        public int berat;


        public Elektronik(string namaProduct, int berat, int hargaProduct) : base(namaProduct, hargaProduct)
        {
            this.namaProduct = namaProduct;
            this.berat = berat;
            this.hargaProduct = hargaProduct;
            this.hargaOngkir = 20000;
            this.hargaTotal = this.hargaProduct + hargaOnkirBarang();
        }

        public int hargaOnkirBarang()
        {
            int value = hargaOngkir * berat / 2;
            return value;
        }

        public void Print()
        {
            Console.WriteLine("--Kategori Benda Elektronik");
            Console.WriteLine("Nama Product : " + namaProduct);
            Console.WriteLine("Berat Product : " + berat);
            Console.WriteLine("Berat Product : " + hargaProduct);
            Console.WriteLine("Harga Onkir barang elektronik : " + hargaOngkir);
            Console.WriteLine("harga Onkir barang sesuai berat dari " + namaProduct + " : " + hargaOnkirBarang());
            Console.WriteLine("harga total pembelian " + namaProduct + " dengan ongkir seharga " + hargaTotal+"\n");
        }




    }

    class PakaianBaju : Product
    {
        public PakaianBaju(string namaProduct, int hargaProduct) : base(namaProduct, hargaProduct)
        {
            this.namaProduct = namaProduct;
            this.hargaProduct = hargaProduct;
            this.hargaOngkir = 5000;
            this.hargaTotal = this.hargaProduct + hargaProduct;
        }

        public void print()
        {
            Console.WriteLine("--Kategori Benda Pakaian/baju");
            Console.WriteLine("Nama Product : " + namaProduct);
            Console.WriteLine("Berat Product : " + hargaProduct);
            Console.WriteLine("Harga Onkir barang Pakaian/baju : " + hargaOngkir);
            Console.WriteLine("harga total pembelian " + namaProduct + " dengan ongkir seharga " + hargaTotal + "\n");
        }
    }

    class Buku : Product
    {
        public Buku(string namaProduct, int hargaProduct) : base(namaProduct, hargaProduct)
        {
            this.namaProduct = namaProduct;
            this.hargaProduct = hargaProduct;
            this.hargaOngkir = 5000;
            this.hargaTotal = this.hargaProduct + hargaProduct;
        }
        public void print()
        {
            Console.WriteLine("--Kategori Benda Buku");
            Console.WriteLine("Nama Product : " + namaProduct);
            Console.WriteLine("Berat Product : " + hargaProduct);
            Console.WriteLine("Harga Onkir barang Buku: " + hargaOngkir);
            Console.WriteLine("harga total pembelian " + namaProduct + " dengan ongkir seharga " + hargaTotal + "\n");

        }

    }

    class KeranjangBelanja
    {
        private List<Product> items; 
        private int jumlahProduct;

        public KeranjangBelanja()
        {
            items = new List<Product>();
            this.jumlahProduct= 0;
        }

        public void TambahProduk(Product product)
        {
            items.Add(product);
            jumlahProduct++;
        }

        public int HitungTotalHarga()
        {
            int totalHarga = 0;
            foreach (var item in items)
            {
                
                totalHarga += item.HargaTotal;
            }
            return totalHarga;
        }

        public void print()
        {
 
            Console.WriteLine("--Keranjang");
            Console.WriteLine("Total barang di keranjang : " + jumlahProduct);
            Console.WriteLine("List Produknya adalah");
            foreach (var item in items)
            {
                Console.WriteLine("->"+item.namaProduct);
            }
            Console.WriteLine("Harga total dari semua belanjaan : " + HitungTotalHarga());

        }
    }
}