using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class BasicElement : AComponent
    {
        public BasicElement(string tagName) : base(tagName)
        { }

        public override void AddNewComponent(AComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Execute(int level = 0)
        {
            Console.WriteLine(this.GetWhiteSpace(level) + "<{0}/>", TagName);
        }

        public override void RemoveComponent(AComponent component)
        {
            throw new NotImplementedException();
        }
    }
}
