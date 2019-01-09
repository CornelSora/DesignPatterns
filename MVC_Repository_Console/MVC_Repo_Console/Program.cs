using PregatireExamen.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregatireExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientController clientController = new ClientController();
            clientController.DisplayClientView();
        }
    }
}
