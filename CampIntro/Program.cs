using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Product urun1 = new Product();
            urun1.id = 1;
            urun1.adi = "Lenovo l340";
            urun1.stok_adet = 10;
            urun1.fiyat = 7.500;
            Product urun2 = new Product();
            urun2.id = 2;
            urun2.adi = "Kiwi Baharat Makinesi";
            urun2.stok_adet = 5;
            urun2.fiyat = 140;
            Product[] urunler = new Product[] {urun1,urun2 };
           

            for (int i = 0; i < urunler.Length; i++)
            {
                Product urun = urunler[i];
                Console.WriteLine("Ürün id : "+urun.id);
                Console.WriteLine("Ürün ad : "+urun.adi);
                Console.WriteLine("Ürün adet : "+urun.stok_adet);
                Console.WriteLine("Ürün fiyat : "+urun.fiyat);
                Console.WriteLine("*******************");
            }

            Console.WriteLine("Foreach ile oluşturulan");

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün id : " + urun.id);
                Console.WriteLine("Ürün ad : " + urun.adi);
                Console.WriteLine("Ürün adet : " + urun.stok_adet);
                Console.WriteLine("Ürün fiyat : " + urun.fiyat);
                Console.WriteLine("*******************");
            }

            Console.WriteLine("While ile oluşturulan");

            while (sayi < urunler.Length)
            {
               
                Product urun = urunler[sayi];
                Console.WriteLine("Ürün id : " + urun.id);
                Console.WriteLine("Ürün ad : " + urun.adi);
                Console.WriteLine("Ürün adet : " + urun.stok_adet);
                Console.WriteLine("Ürün fiyat : " + urun.fiyat);
                Console.WriteLine("*******************");
                sayi++;

              
            }

        }
    }

    class Product
    {
        public int id { get; set; }
        public string adi { get; set; }
        public int  stok_adet { get; set; }
        public double fiyat { get; set; }


    }
}
