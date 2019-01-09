using System;

namespace Composite
{
    class Program
    {
        static void AddNewComponent(AComponent parent, AComponent child)
        {
            parent.AddNewComponent(child);
        }

        static void Main(string[] args)
        {
            AComponent html = new CustomElement("html", "");
            AComponent head = new CustomElement("head", "");
            AComponent script = new BasicElement("script");
            AddNewComponent(head, script);
            AddNewComponent(html, head);
            AComponent body = new CustomElement("body", "");
            AddNewComponent(body, new BasicElement("br"));
            AComponent p = new CustomElement("p", "This a paragraph");
            AddNewComponent(p, new BasicElement("br"));
            AddNewComponent(body, p);
            p = new CustomElement("p", "This the second paragraph");
            AddNewComponent(p, new BasicElement("br"));
            AddNewComponent(body, p);
            AddNewComponent(html, body);
            html.Execute();
            Console.ReadLine();
        }
    }
}
