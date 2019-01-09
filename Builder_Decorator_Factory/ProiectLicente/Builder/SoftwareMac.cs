using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectLicente.Builder
{
    public class SoftwareMac : ASoftware
    {
        public SoftwareMac()
        {

        }
        public SoftwareMac(string name, SoftwareType type, int days, bool advancedDesign) : base(name, type, days, advancedDesign)
        {
        }

        public override void PrintSoftwareLicense()
        {
            Console.WriteLine(string.Format("Software Mac with name: {0}, type: {1}, days: {2}, has advanced design: {3}, number of licenses: {4}",
                this.Name, this.Type.ToString(), this.Days, this.AdvancedDesign, this.NoLicenses != 0 ? this.NoLicenses : 1));
        }
    }
}
