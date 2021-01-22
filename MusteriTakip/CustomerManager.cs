using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakip
{
    class CustomerManager
    { 
        public void Add(Customer customer)
        {  
            Console.WriteLine(customer.name + " Eklendi");
        }
           
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.name + " Silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.name + " Güncellendi");
        }

    }
}
