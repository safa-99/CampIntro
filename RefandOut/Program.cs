using System;

namespace RefandOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5; //değer tipler  // ref değer tiplerin referans tipler gibi davranmasını sağlar
            int sayi2 = 10;
            Console.WriteLine(Topla(out sayi1, sayi2));
            Console.WriteLine(sayi1);
        }

        public static int Topla(out int sayi1, int sayi2)
        { //int tipinde ismi sayi1 olan bir değişkenin referansı(kendisi) gelecek. Referans olması o değişenin kendisinin kullanılacağını gösterir

            sayi1 = 70; // değişen değer sayi1 in kendisi
            return sayi1 + sayi2;
        }
    
    }
}
