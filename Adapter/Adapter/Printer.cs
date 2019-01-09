using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Printer
    {
        public IPrintable printable { get; set; }

        public Printer(IPrintable printable)
        {
            this.printable = printable;
        }

        public void Print()
        {
            List<String> Files = this.printable.GetFiles();
            foreach (var file in Files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
