using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AdaptorFolder : IPrintable
    {
        public Folder Folder { get; set; }

        public AdaptorFolder(Folder Folder)
        {
            this.Folder = Folder;
        }

        public List<string> GetFiles()
        {
            List<string> result = new List<string>();
            FileTest[] files = this.Folder.GetFiles();
            foreach (var file in files)
            {
                result.Add(file.Name);
            }
            return result;
        }
    }
}
