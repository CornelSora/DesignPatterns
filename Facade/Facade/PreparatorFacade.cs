using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class PreparatorFacade
    {
        private ARecipient recipientApa = new RecipientApa(100);
        private ARecipient recipientCafea = new RecipientCafea(200);
        private ARecipient recipientZahar = new RecipientZahar(100);

        public void preparareExpressoLung()
        {
            Console.WriteLine("Se prepara....");
            recipientApa.Adauga(100);
            recipientCafea.Adauga(30);
            recipientZahar.Adauga(20);
            Console.WriteLine("S-a preparat expresso lung");
        }

        public void preparareExpressoScurt()
        {
            Console.WriteLine("Se prepara....");
            recipientApa.Adauga(50);
            recipientCafea.Adauga(35);
            recipientZahar.Adauga(10);
            Console.WriteLine("S-a preparat expresso scurt");
        }

        public void preparareCafeaAmara()
        {
            Console.WriteLine("Se prepara....");
            recipientApa.Adauga(20);
            recipientCafea.Adauga(70);
            Console.WriteLine("S-a preparat cafea amara");
        }

        public void preparareApaCuZahar()
        {
            Console.WriteLine("Se prepara....");
            recipientApa.Adauga(60);
            recipientZahar.Adauga(30);
            Console.WriteLine("S-a preparat apa cu zahar");
        }
    }
}
