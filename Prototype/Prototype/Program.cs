using Prototype.Prototype;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ACloneWar p1 = new WhiteClone("White clone star");
            ACloneWar c1 = (WhiteClone)p1.Clone();
            Console.WriteLine("Cloned: {0}", p1.Id);
            Console.WriteLine("To: {0}", c1.Id);

            ACloneWar p2 = new BlackClone("Black clone star");
            ACloneWar c2 = (BlackClone)p2.Clone();
            Console.WriteLine("Cloned: {0}", p2.Id);
            Console.WriteLine("To: {0}", c2.Id);

            // Wait for user

            Console.ReadKey();
        }
    }
}
