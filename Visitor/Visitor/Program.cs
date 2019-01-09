using System;

namespace Visitor
{
    class Program
    {
        static void AddNewComponent(ElementHTML parent, ElementHTML child)
        {
            parent.AddNewComponent(child);
        }

        static void Main(string[] args)
        {
            ElementHTML html = new ElementHTMLCompus("html", "");
            ElementHTML head = new ElementHTMLCompus("head", "");
            ElementHTML script = new ElementHTMLSimplu("script");
            AddNewComponent(head, script);
            AddNewComponent(html, head);
            ElementHTML body = new ElementHTMLCompus("body", "");
            ElementHTML p = new ElementHTMLSimplu("p");
            AddNewComponent(body, p);
            AddNewComponent(html, body);

            Visitor classVisitor = new CSSClassVisitor();
            classVisitor.visit(body, "whiteBackground");
            Visitor idVisitor = new CSSIdVisitor();
            p.accept(idVisitor, "idP");
            Visitor styleVisitor = new CSSStyleVisitor();

            body.accept(styleVisitor, "style test");
            p.accept(styleVisitor, "style test");

            html.Execute();
            Console.ReadLine();
        }
    }
}
