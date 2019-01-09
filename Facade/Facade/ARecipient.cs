using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public abstract class ARecipient
    {
        public int Cantitate { get; set; }
        public ARecipient(int cantitate)
        {
            this.Cantitate = cantitate;
        }
        public abstract void Adauga(int cant);
        
        protected void CommonChecker(int cant, string type)
        {
            if (this.Cantitate - cant > 0)
            {
                this.Cantitate -= cant;
                Console.WriteLine("Se adauga {0}: {2}, cantitate ramasa: {1}", type, this.Cantitate, cant);
            }
            else
            {
                Console.WriteLine("Cantitate indisponibila de {0} pentru {1}, cant ramasa: {2}", type, cant, this.Cantitate);
            }
        }
    }
}
