using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class FileTest
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public FileTest(string Name)
        {
            this.Name = Name;
        }
    }
}
