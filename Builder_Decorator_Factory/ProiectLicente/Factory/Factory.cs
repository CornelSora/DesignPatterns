using ProiectLicente.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectLicente.Factory
{
    public enum OSType
    {
        LINUX,
        MAC,
        WINDOWS
    }

    public class Factory
    {
        public static ASoftware GetSoftware(OSType type)
        {
            if (type == OSType.LINUX)
            {
                return new SoftwareLinux();
            }
            else if (type == OSType.MAC)
            {
                return new SoftwareMac();
            }
            else if (type == OSType.WINDOWS)
            {
                return new SoftwareWindows();
            }
            return new SoftwareWindows();
        }
    }
}
