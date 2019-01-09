using Factory.Factory;
using Factory.Users;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = FactoryUsers.getInstance();
            AUser client = factory.createUser(UserType.CLIENT);
            AUser administrator = factory.createUser(UserType.ADMINISTRATOR);
            AUser contributor = factory.createUser(UserType.CONTRIBUTOR);

            client.printInfo();
            administrator.printInfo();
            contributor.printInfo();

            Console.ReadLine();
        }
    }
}
