using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ElementHTMLSimplu: ElementHTML
    {
        public ElementHTMLSimplu(string TagContent) : base(TagContent)
        { }

        public override void accept(Visitor visitor, string detail)
        {
            visitor.visit(this, detail);
        }

        public override void Execute(int level = 0)
        {
            Console.WriteLine(this.GetWhiteSpace(level) + "<{0}{1}></{0}>", TagContent, Css);
        }

        #region NOTIMPLEMENTED
        public override void AddNewComponent(ElementHTML component)
        {
            throw new NotImplementedException();
        }
        public override void RemoveComponent(ElementHTML component)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
