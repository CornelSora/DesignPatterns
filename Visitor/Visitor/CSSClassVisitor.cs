using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class CSSClassVisitor : Visitor
    {
        public override void visit(ElementHTML elementHTML, string detail)
        {
            elementHTML.Css += GetStyle("class", detail);
        }
    }
}
