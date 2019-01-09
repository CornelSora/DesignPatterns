using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User.Builder builder = new User.Builder("username", "password");
            builder.setFirstName("First name").setLastName("Last name").setEmail("email").setPhone("12312312");
            User user = builder.createUser();
            Console.WriteLine(user.ToString());
            Console.ReadLine();
        }
    }
}
