using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Bilal";
            customer1.Id = 7;
            customer1.Nationality = "Turkey";
            customer1.Surname = "Bora";
            customer1.Age = 22;

            Customer customer2 = new Customer();
            customer2.Name = "Hilal";
            customer2.Id = 2;
            customer2.Nationality = "Turkey";
            customer2.Surname = "Bora";
            customer2.Age = 18;

            Customer customer3 = new Customer();
            customer3.Name = "Halil";
            customer3.Id = 3;
            customer3.Nationality = "Turkey";
            customer3.Surname = "Bora";
            customer3.Age = 16;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            foreach (var customer in customers)
            {
                customerManager.Add(customer);
                Console.WriteLine("-----------");
                customerManager.Delete(customer);
                Console.WriteLine("-----------");
                customerManager.Uptade(customer);
                Console.WriteLine("-----------");
            }
            
        }
    }
}
