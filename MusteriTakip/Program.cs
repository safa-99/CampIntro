using System;

namespace MusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer {id = 1, name = "Ahmet" , age = 35};
            Customer c2 = new Customer { id = 2, name = "Zeynep", age = 19 };
            Customer c3 = new Customer { id = 3, name = "Kemal", age = 70 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(c1);
            customerManager.Add(c2);
            customerManager.Delete(c3);
            customerManager.Update(c1);
        }
    }
}
