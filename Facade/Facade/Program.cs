using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var preparatorFacade = new PreparatorFacade();
            preparatorFacade.preparareApaCuZahar();
            preparatorFacade.preparareCafeaAmara();
            preparatorFacade.preparareExpressoLung();

            Console.ReadLine();
        }
    }
}
