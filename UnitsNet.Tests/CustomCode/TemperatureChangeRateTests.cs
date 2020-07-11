// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

namespace UnitsNet.Tests.CustomCode
{
    public class TemperatureChangeRateTests : TemperatureChangeRateTestsBase
    {
        protected override double DegreesCelsiusPerMinuteInOneDegreeCelsiusPerSecond => 60;


        protected override double FemtodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond =>  1e15;
        protected override double PicodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond  =>  1e12;
        protected override double NanodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond  =>  1e9;
        protected override double MicrodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond =>  1e6;
        protected override double MillidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond =>  1e3;
        protected override double CentidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond =>  1e2;
        protected override double DecidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond  =>  1e1;
        protected override double DegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond => 1;
        protected override double DecadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond  =>  1e-1;
        protected override double HectodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond =>  1e-2;
        protected override double KilodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond  =>  1e-3;
        protected override double MegadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond  =>  1e-6;
        protected override double GigadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond  =>  1e-9;
        protected override double TeradegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond  =>  1e-12;
        protected override double PetadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond  =>  1e-15;
        protected override double ExadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond   =>  1e-18;
        protected override double ZettadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond =>  1e-21;
        protected override double YottadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond =>  1e-24;
        protected override double QutradegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond =>  1e-27;
        protected override double VettadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond => 1e-30;


    }
}
