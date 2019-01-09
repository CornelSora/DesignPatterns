using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class RecipientCafea : ARecipient
    {
        public RecipientCafea(int cantitate) : base(cantitate)
        {
        }

        public override void Adauga(int cant)
        {
            this.CommonChecker(cant, "cafea");
        }
    }
}
