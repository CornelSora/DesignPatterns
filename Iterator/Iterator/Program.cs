using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients clients = new Clients();
            clients[0] = new Client("nume1", "adresa1");
            clients[1] = new Client("nume2", "adresa2");
            clients[2] = new Client("nume3", "adresa3");
            clients[3] = new Client("nume4", "adresa4");

            AIterator iterator = clients.GetIterator();

            Client client = iterator.First();

            while (!iterator.IsDone())
            {
                Console.WriteLine(client.ToString());
                iterator.Next();
                client = iterator.CurrentItem();
            }

            client = iterator.Last();

            while (!iterator.IsDone())
            {
                Console.WriteLine(client.ToString());
                iterator.Prev();
                client = iterator.CurrentItem();
            }

            Console.ReadLine();
        }
    }
}
