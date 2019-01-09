using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class Visitor
    {
        public string GetStyle(string type, string detail)
        {
            return string.Format(" {0}=\"{1}\"", type, detail);
        }
        public abstract void visit(ElementHTML elementHTML, string detail);
    }
}
