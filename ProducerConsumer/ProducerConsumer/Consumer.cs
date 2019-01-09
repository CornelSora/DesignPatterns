using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProducerConsumer
{
    public class Consumer
    {
        private int myId;
        private Broker broker;
        private static int cid = 1;
        public Consumer(Broker broker)
        {
            this.broker = broker;
            this.myId = cid;
            cid++;
        }

        public void Consume()
        {
            while (true)
            {
                Thread.Sleep(200);
                int ramase;
                Cadou cadou = broker.Get(out ramase);
                if (cadou == null && broker.State == 1)
                {
                    break;
                }
                if (cadou != null)
                {
                    Console.WriteLine(string.Format("Cadou cu id {0}, nume: {1}, descriere {2}, Consumer: {3}", cadou.Id, cadou.Name, cadou.Description, myId));
                    Console.WriteLine("Ramase: " + ramase);
                }
            }
        }
    }
}
