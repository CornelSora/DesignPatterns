using ProiectLicente.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectLicente.Decorator
{
    public abstract class ADecorator : ASoftware
    {
        protected ASoftware software;

        public ADecorator(ASoftware software)
        {
            this.software = software;
        }

        public abstract void SetNoLicenses(int nr);

        public override void PrintSoftwareLicense()
        {
            if (software != null)
            {
                software.PrintSoftwareLicense();
            }
        }
    }
}
