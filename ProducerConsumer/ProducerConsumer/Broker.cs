using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProducerConsumer
{
    public class Broker
    {
        public Queue<Cadou> cadouri = new Queue<Cadou>();
        public int State { get; set; } = 0;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Add(Cadou cadou)
        {
            cadouri.Enqueue(cadou);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public Cadou Get(out int ramase)
        {
            ramase = cadouri.Count;
            return cadouri.Count == 0 ? null : cadouri.Dequeue();
        }
    }
}
