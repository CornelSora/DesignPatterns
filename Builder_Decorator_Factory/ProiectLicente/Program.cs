using ProiectLicente.Builder;
using ProiectLicente.Decorator;
using ProiectLicente.Factory;
using System;

namespace ProiectLicente
{
    class Program
    {
        static void Main(string[] args)
        {
            ASoftware software = new ASoftware.Builder("IDE")
            .setDays(100)
            .setType(SoftwareType.ADVANCED)
            .setOSType(OSType.MAC)
            .buildSoftware();
            software.PrintSoftwareLicense();

            ADecorator decoratorNr = new DecoratorNoLicenses(software);
            decoratorNr.SetNoLicenses(4);
            decoratorNr.PrintSoftwareLicense();
            Console.ReadLine();
        }
    }
}