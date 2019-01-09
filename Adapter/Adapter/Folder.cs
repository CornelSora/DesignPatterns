using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Adapter
{
    public class Folder
    {
        public string Name { get; set; }

        public FileTest[] GetFiles()
        {
            FileTest[] files = new FileTest[10];
            for (var i = 0; i < 10; i++)
            {
                files[i] = new FileTest("file " + i);
            }
            return files;
        }
    }
}
