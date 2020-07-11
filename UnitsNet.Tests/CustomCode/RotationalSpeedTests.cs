// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class RotationalSpeedTests : RotationalSpeedTestsBase
    {
        protected override double FemtoradiansPerSecondInOneRadianPerSecond => 1e15;
        protected override double PicoradiansPerSecondInOneRadianPerSecond => 1e12;
        protected override double NanoradiansPerSecondInOneRadianPerSecond => 1E9;
        protected override double MicroradiansPerSecondInOneRadianPerSecond => 1E6;
        protected override double MilliradiansPerSecondInOneRadianPerSecond => 1E3;
        protected override double CentiradiansPerSecondInOneRadianPerSecond => 1E2;
        protected override double DeciradiansPerSecondInOneRadianPerSecond => 1E1;
        protected override double RadiansPerSecondInOneRadianPerSecond => 1;
        protected override double DecaradiansPerSecondInOneRadianPerSecond => 0.1;
        protected override double HectoradiansPerSecondInOneRadianPerSecond => 1e-2;
        protected override double KiloradiansPerSecondInOneRadianPerSecond => 1e-3;
        protected override double MegaradiansPerSecondInOneRadianPerSecond => 1e-6;
        protected override double GigaradiansPerSecondInOneRadianPerSecond => 1e-9;
        protected override double TeraradiansPerSecondInOneRadianPerSecond => 1e-12;
        protected override double PetaradiansPerSecondInOneRadianPerSecond => 1e-15;
        protected override double ExaradiansPerSecondInOneRadianPerSecond => 1e-18;
        protected override double ZettaradiansPerSecondInOneRadianPerSecond => 1e-21;
        protected override double YottaradiansPerSecondInOneRadianPerSecond => 1e-24;
        protected override double QutraradiansPerSecondInOneRadianPerSecond => 1e-27;
        protected override double VettaradiansPerSecondInOneRadianPerSecond => 1e-30;

        protected override double RevolutionsPerMinuteInOneRadianPerSecond => 9.54929659;

        protected override double RevolutionsPerSecondInOneRadianPerSecond => 0.15915494;


        protected override double FemtodegreesPerSecondInOneRadianPerSecond => 57295779513082320.87;
        protected override double PicodegreesPerSecondInOneRadianPerSecond => 57295779513082.32087;
        protected override double NanodegreesPerSecondInOneRadianPerSecond => 57295779513.08232087;
        protected override double MicrodegreesPerSecondInOneRadianPerSecond => 57295779.51308232;
        protected override double MillidegreesPerSecondInOneRadianPerSecond => 57295.77951308;
        protected override double CentidegreesPerSecondInOneRadianPerSecond => 5729.577951308;
        protected override double DecidegreesPerSecondInOneRadianPerSecond => 572.9577951308;
        protected override double DegreesPerSecondInOneRadianPerSecond => 57.29577951308;
        protected override double DecadegreesPerSecondInOneRadianPerSecond => 5.729577951308;
        protected override double HectodegreesPerSecondInOneRadianPerSecond => 0.5729577951308;
        protected override double KilodegreesPerSecondInOneRadianPerSecond => 5.729577951308e-2;
        protected override double MegadegreesPerSecondInOneRadianPerSecond => 5.729577951308e-5;
        protected override double GigadegreesPerSecondInOneRadianPerSecond => 5.729577951308e-8;
        protected override double TeradegreesPerSecondInOneRadianPerSecond => 5.729577951308e-11;
        protected override double PetadegreesPerSecondInOneRadianPerSecond => 5.729577951308e-14;
        protected override double ExadegreesPerSecondInOneRadianPerSecond => 5.729577951308e-17;
        protected override double ZettadegreesPerSecondInOneRadianPerSecond => 5.729577951308e-20;
        protected override double YottadegreesPerSecondInOneRadianPerSecond => 5.729577951308e-23;
        protected override double QutradegreesPerSecondInOneRadianPerSecond => 5.729577951308e-26;
        protected override double VettadegreesPerSecondInOneRadianPerSecond => 5.729577951308e-29;

        protected override double DegreesPerMinuteInOneRadianPerSecond => 3437.74677;


        [Fact]
        public void DurationTimesRotationalSpeedEqualsAngle()
        {
            Angle angle = Duration.FromSeconds(9.0)*RotationalSpeed.FromRadiansPerSecond(10.0);
            Assert.Equal(angle, Angle.FromRadians(90.0));
        }

        [Fact]
        public void RotationalSpeedTimesDurationEqualsAngle()
        {
            Angle angle = RotationalSpeed.FromRadiansPerSecond(10.0)*Duration.FromSeconds(9.0);
            Assert.Equal(angle, Angle.FromRadians(90.0));
        }

        [Fact]
        public void RotationalSpeedTimesTimeSpanEqualsAngle()
        {
            Angle angle = RotationalSpeed.FromRadiansPerSecond(10.0)*TimeSpan.FromSeconds(9.0);
            Assert.Equal(angle, Angle.FromRadians(90.0));
        }

        [Fact]
        public void TimeSpanTimesRotationalSpeedEqualsAngle()
        {
            Angle angle = TimeSpan.FromSeconds(9.0)*RotationalSpeed.FromRadiansPerSecond(10.0);
            Assert.Equal(angle, Angle.FromRadians(90.0));
        }
    }
}
