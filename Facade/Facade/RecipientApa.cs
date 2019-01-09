using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class RecipientApa : ARecipient
    {
        public RecipientApa(int cantitate) : base(cantitate)
        {
        }

        public override void Adauga(int cant)
        {
            this.CommonChecker(cant, "apa");
        }
    }
}
