using AbstractFactory.Factory;
using AbstractFactory.Labels;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatingSystem os_info = System.Environment.OSVersion;
            Console.WriteLine(os_info.VersionString);
            Dialog d = null;
            if (os_info.VersionString.Contains("Windows"))
            {
                d = new Dialog(new WindowsViewsFactory());
            }
            else
            {
                d = new Dialog(new MacOSViewsFactory());
            }
            Console.ReadLine();
        }
    }
}
