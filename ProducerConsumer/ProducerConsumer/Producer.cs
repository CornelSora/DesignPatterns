using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProducerConsumer
{
    public class Producer
    {
        private Broker broker;
        private int MAX = 20;
        public Producer(Broker broker)
        {
            this.broker = broker;
        }

        public void Produce()
        {
            int i = 0;
            while (i < MAX)
            {
                Random random = new Random();

                int rnd = random.Next();
                var cadou = new Cadou()
                {
                    Id = rnd,
                    Description = "Cadoul cu id: " + rnd,
                    Name = "Cadou" + rnd
                };

                broker.Add(cadou);

                i++;
            }

            broker.State = 1;
        }


    }
}
