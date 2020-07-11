// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

namespace UnitsNet.Tests.CustomCode
{
    public class PressureChangeRateTests : PressureChangeRateTestsBase
    {
        protected override double AtmospheresPerSecondInOnePascalPerSecond => 9.8692*1E-6;



        protected override double FemtopascalsPerSecondInOnePascalPerSecond => 1e15;
        protected override double PicopascalsPerSecondInOnePascalPerSecond => 1e12;
        protected override double NanopascalsPerSecondInOnePascalPerSecond => 1e9;
        protected override double MicropascalsPerSecondInOnePascalPerSecond => 1e6;
        protected override double MillipascalsPerSecondInOnePascalPerSecond => 1e3;
        protected override double CentipascalsPerSecondInOnePascalPerSecond => 1e2;
        protected override double DecipascalsPerSecondInOnePascalPerSecond => 10;
        protected override double PascalsPerSecondInOnePascalPerSecond => 1;
        protected override double DecapascalsPerSecondInOnePascalPerSecond => 0.1;
        protected override double HectopascalsPerSecondInOnePascalPerSecond => 1e-2;
        protected override double KilopascalsPerSecondInOnePascalPerSecond => 1e-3;
        protected override double MegapascalsPerSecondInOnePascalPerSecond => 1E-6;
        protected override double GigapascalsPerSecondInOnePascalPerSecond => 1E-9;
        protected override double TerapascalsPerSecondInOnePascalPerSecond => 1E-12;
        protected override double PetapascalsPerSecondInOnePascalPerSecond => 1E-15;
        protected override double ExapascalsPerSecondInOnePascalPerSecond => 1E-18;
        protected override double ZettapascalsPerSecondInOnePascalPerSecond => 1E-21;
        protected override double YottapascalsPerSecondInOnePascalPerSecond => 1E-24;
        protected override double QutrapascalsPerSecondInOnePascalPerSecond => 1E-27;
        protected override double VettapascalsPerSecondInOnePascalPerSecond => 1E-30;


        protected override double FemtopascalsPerMinuteInOnePascalPerSecond => 6e16;
        protected override double PicopascalsPerMinuteInOnePascalPerSecond => 6e13;
        protected override double NanopascalsPerMinuteInOnePascalPerSecond => 6e10;
        protected override double MicropascalsPerMinuteInOnePascalPerSecond => 6e7;
        protected override double MillipascalsPerMinuteInOnePascalPerSecond => 6e4;
        protected override double CentipascalsPerMinuteInOnePascalPerSecond => 6e3;
        protected override double DecipascalsPerMinuteInOnePascalPerSecond => 6e2;
        protected override double PascalsPerMinuteInOnePascalPerSecond => 60;
        protected override double DecapascalsPerMinuteInOnePascalPerSecond => 6;
        protected override double HectopascalsPerMinuteInOnePascalPerSecond => 0.6;
        protected override double KilopascalsPerMinuteInOnePascalPerSecond => 6e-2;
        protected override double MegapascalsPerMinuteInOnePascalPerSecond => 6e-5;
        protected override double GigapascalsPerMinuteInOnePascalPerSecond => 6e-8;
        protected override double TerapascalsPerMinuteInOnePascalPerSecond => 6e-11;
        protected override double PetapascalsPerMinuteInOnePascalPerSecond => 6e-14;
        protected override double ExapascalsPerMinuteInOnePascalPerSecond => 6e-17;
        protected override double ZettapascalsPerMinuteInOnePascalPerSecond => 6e-20;
        protected override double YottapascalsPerMinuteInOnePascalPerSecond => 6e-23;
        protected override double QutrapascalsPerMinuteInOnePascalPerSecond => 6e-26;
        protected override double VettapascalsPerMinuteInOnePascalPerSecond => 6e-29;

    }
}
