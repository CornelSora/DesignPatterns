using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            LazySingletonThreadSafe singleton1 = LazySingletonThreadSafe.GetInstance();
            LazySingletonThreadSafe singleton2 = LazySingletonThreadSafe.GetInstance();

            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton2.GetHashCode());

            LazySingletonThreadSafe[] singletons = new LazySingletonThreadSafe[10];
            Parallel.For(0, 10, index =>
            {
                singletons[index] = LazySingletonThreadSafe.GetInstance();
                Console.WriteLine(string.Format("For the index: {0} we have: {1}", index, singletons[index].GetHashCode()));
            });

            Singleton[] clasicSingletons = new Singleton[10];
            Parallel.For(0, 10, index =>
            {
                clasicSingletons[index] = Singleton.GetInstance();
                Console.WriteLine(string.Format("For the index: {0} we have: {1}", index, clasicSingletons[index].GetHashCode()));
            });

            Console.ReadLine();
        }
    }
}
