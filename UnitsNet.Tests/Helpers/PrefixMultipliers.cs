using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsNet.Tests.Helpers
{
    public enum Prefix
    {
        undefined = 0,
        femto,
        pico,
        nano,
        micro,
        milli,
        ceni,
        deci,
        unit,
        deca,
        hecto,
        kilo,
        mega,
        giga,
        tera,
        peta,
        exa,
        zetta,
        yotta,
        qutra,
        vetta,

    }
    class PrefixMultipliers
    {
       public static double Apply(double value, Prefix prefix)
        {
            switch(prefix)
            {
                case Prefix.femto:
                    return value / 1e-15d;
                case Prefix.pico:
                    return value / 1e-12d;
                case Prefix.nano:
                    return value / 1e-9d;
                case Prefix.micro:
                    return value / 1e-6d;
                case Prefix.milli:
                    return value / 1e-3d;
                case Prefix.ceni:
                    return value / 1e-2d;
                case Prefix.deci:
                    return value / 1e-1d;
                case Prefix.unit:
                    return 1.0d/value;
                case Prefix.deca:
                    return value / 1e1d;
                case Prefix.hecto:
                    return value / 1e2d;
                case Prefix.kilo:
                    return value / 1e3d;
                case Prefix.mega:
                    return value / 1e6d;
                case Prefix.giga:
                    return value / 1e9d;
                case Prefix.tera:
                    return value / 1e12d;
                case Prefix.peta:
                    return value / 1e15d;
                case Prefix.exa:
                    return value / 1e18d;
                case Prefix.zetta:
                    return value / 1e21d;
                case Prefix.yotta:
                    return value / 1e24d;
                case Prefix.qutra:
                    return value / 1e27d;
                case Prefix.vetta:
                    return value / 1e30d;
                case Prefix.undefined:
                default:
                    return value;
            }
        }
    }
}
