using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ElementHTMLCompus : ElementHTML
    {
        public List<ElementHTML> components = new List<ElementHTML>();
        public string Continut { get; set; }

        public ElementHTMLCompus(string TagContent, string Continut) : base(TagContent)
        {
            this.Continut = Continut;
        }

        public override void AddNewComponent(ElementHTML component)
        {
            components.Add(component);
        }

        public override void RemoveComponent(ElementHTML component)
        {
            components.Remove(component);
        }

        public override void Execute(int level = 0)
        {
            if (string.IsNullOrWhiteSpace(this.Continut))
            {
                Console.WriteLine(this.GetWhiteSpace(level) + "<{0}{1}>", this.TagContent, this.Css);
            }
            else
            {
                Console.WriteLine(this.GetWhiteSpace(level) + "<{0}>\n{1}", this.TagContent, this.Continut);
            }
            foreach (var component in components)
            {
                component.Execute(level + 1);
            }
            Console.WriteLine(this.GetWhiteSpace(level) + "</{0}>", this.TagContent);
        }

        public override void accept(Visitor visitor, string detail)
        {
            visitor.visit(this, detail);
        }
    }
}
