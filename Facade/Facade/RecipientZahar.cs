using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class RecipientZahar : ARecipient
    {
        public RecipientZahar(int cantitate) : base(cantitate)
        {
        }

        public override void Adauga(int cant)
        {
            this.CommonChecker(cant, "zahar");
        }
    }
}
