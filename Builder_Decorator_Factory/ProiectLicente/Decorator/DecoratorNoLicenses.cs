using System;
using System.Collections.Generic;
using System.Text;
using ProiectLicente.Builder;

namespace ProiectLicente.Decorator
{
    public class DecoratorNoLicenses : ADecorator
    {
        public DecoratorNoLicenses(ASoftware software) : base(software)
        {
        }

        public override void SetNoLicenses(int nr)
        {
            software.NoLicenses = nr;
        }

        public override void PrintSoftwareLicense()
        {
            base.PrintSoftwareLicense();
        }
    }
}
