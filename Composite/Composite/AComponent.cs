using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class AComponent
    {
        public string TagName { get; set; }
        public AComponent(string tagName)
        {
            this.TagName = tagName;
        }
        public string GetWhiteSpace(int level)
        {
            string whiteSpace = "";
            for (var i = 0; i < level; i++)
            {
                whiteSpace += " ";
            }
            return whiteSpace;
        }
        public abstract void Execute(int level = 0);
        public abstract void AddNewComponent(AComponent component);
        public abstract void RemoveComponent(AComponent component);
    }
}
