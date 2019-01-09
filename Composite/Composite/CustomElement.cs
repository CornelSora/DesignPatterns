using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class CustomElement : AComponent
    {
        public List<AComponent> Components = new List<AComponent>();
        public string Continut { get; set; }

        public CustomElement(string tagName, string Continut) : base(tagName)
        {
            this.Continut = Continut;
        }

        public override void AddNewComponent(AComponent component)
        {
            Components.Add(component);
        }

        public override void RemoveComponent(AComponent component)
        {
            Components.Remove(component);
        }

        public override void Execute(int level = 0)
        {
            if (string.IsNullOrWhiteSpace(this.Continut))
            {
                Console.WriteLine(this.GetWhiteSpace(level) + "<{0}>", this.TagName);
            }
            else
            {
                Console.WriteLine(this.GetWhiteSpace(level) + "<{0}>\n{1}", this.TagName, this.Continut);
            }
            foreach (var component in Components)
            {
                component.Execute(level + 1);
            }
            Console.WriteLine(this.GetWhiteSpace(level) + "</{0}>", this.TagName);
        }
    }
}
