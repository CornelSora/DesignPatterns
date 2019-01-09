using System;
using System.Threading;

namespace ProducerConsumer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Broker broker = new Broker();
            Producer producer = new Producer(broker);
            Consumer consumer1 = new Consumer(broker);
            Consumer consumer2 = new Consumer(broker);

            Thread producerThread = new Thread(new ThreadStart(producer.Produce));
            Thread consumerThread1 = new Thread(new ThreadStart(consumer1.Consume));
            Thread consumerThread2 = new Thread(new ThreadStart(consumer2.Consume));

            producerThread.Start();
            consumerThread1.Start();
            consumerThread2.Start();

            //producerThread.Interrupt();
            //consumerThread1.Interrupt();
            //consumerThread2.Abort();

            Console.ReadLine();

        }
    }
}
