using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> {"Safa",
            "Kerem","Asaff","Zeynep","Halil"};
            foreach (var isim in isimler2)
            {
                Console.WriteLine(isim);
            }
            //isimler2.Add("Safa");

        }
    }
}
