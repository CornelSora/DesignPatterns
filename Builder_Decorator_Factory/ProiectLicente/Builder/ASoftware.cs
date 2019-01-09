using ProiectLicente.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectLicente.Builder
{
    public enum SoftwareType
    {
        BASIC,
        ADVANCED,
        FULL
    }

    public abstract class ASoftware
    {
        public string Name { get; set; }
        public SoftwareType Type { get; set; }
        public int Days { get; set; }
        public bool AdvancedDesign { get; set; }
        public int NoLicenses { get; set; }
        
        public  abstract void PrintSoftwareLicense();

        public ASoftware()
        {

        }

        public ASoftware(string name, SoftwareType type, int days, bool advancedDesign)
        {
            Name = name;
            Type = type;
            Days = days;
            AdvancedDesign = advancedDesign;
        }

        public class Builder
        {
            internal string name;
            internal SoftwareType type;
            internal int days;
            internal bool advancedDesign;
            internal OSType osType;

            public Builder(string name)
            {
                this.name = name;
                this.type = SoftwareType.BASIC;
                this.osType = OSType.WINDOWS;
                this.days = 30;
                this.advancedDesign = true;
            }

            public Builder setType(SoftwareType st)
            {
                this.type = st;
                return this;
            }

            public Builder setDays(int days)
            {
                this.days = days;
                return this;
            }

            public Builder setDesign(bool ad)
            {
                this.advancedDesign = ad;
                return this;
            }

            public Builder setOSType(OSType osType)
            {
                this.osType = osType;
                return this;
            }

            public ASoftware buildSoftware()
            {
                ASoftware software = Factory.Factory.GetSoftware(osType);
                software.Name = this.name;
                software.Type = this.type;
                software.Days = this.days;
                software.AdvancedDesign = this.advancedDesign;

                return software;
                //  return new SoftwareWindows(this.name, this.type, this.days, this.advancedDesign);
            }
        }
    }
}
