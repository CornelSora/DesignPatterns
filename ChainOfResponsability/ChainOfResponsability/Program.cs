using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            View buttonOk = new View();
            buttonOk.Text = "OK";
            buttonOk.TypeOfInfo = "Tooltip";

            View buttonCancel = new View();

            AComponent viewGroup = new ViewGroup();
            viewGroup.Text = "View group ";

            AComponent viewGroup2 = new ViewGroup();
            viewGroup.AddView(buttonOk);
            viewGroup2.AddView(buttonCancel);

            Frame frame = new Frame();
            frame.AddView(viewGroup2);
            frame.Text = "Frame ";

            buttonCancel.DisplayInfo();
            buttonOk.DisplayInfo();
            viewGroup.DisplayInfo();
            viewGroup2.DisplayInfo();
            frame.DisplayInfo();

            Console.ReadLine();
        }
    }
}
