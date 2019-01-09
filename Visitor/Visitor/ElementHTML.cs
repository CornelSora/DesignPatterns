using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class ElementHTML
    {
        public string Css { get; set; }
        public string TagContent { get; set; }
        public ElementHTML(string TagContent)
        {
            this.TagContent = TagContent;
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
        public abstract void accept(Visitor visitor, string detail);
        public abstract void Execute(int level = 0);
        public abstract void AddNewComponent(ElementHTML component);
        public abstract void RemoveComponent(ElementHTML component);
    }
}
