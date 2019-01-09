using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create RefinedAbstraction

            Customers customers = new Customers("Chicago");
            // Set ConcreteImplementor

            customers.Data = new CustomersData();

            // Exercise the bridge

            customers.Add("Test123");
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            // Wait for user

            Console.ReadKey();
        }
    }
}
