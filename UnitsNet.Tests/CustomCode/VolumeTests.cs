// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class VolumeTests : VolumeTestsBase
    {

        protected override double CubicCentimetersInOneCubicMeter => 1E6;
        protected override double CubicDecimetersInOneCubicMeter => 1E3;

        protected override double FemtocubicFeetInOneCubicMeter => 3.531472e16;
        protected override double PicocubicFeetInOneCubicMeter => 3.531472e13;
        protected override double NanocubicFeetInOneCubicMeter => 3.531472e10;
        protected override double MicrocubicFeetInOneCubicMeter => 3.531472e7;
        protected override double MillicubicFeetInOneCubicMeter => 3.531472e4;
        protected override double CenticubicFeetInOneCubicMeter => 3.531472e3;
        protected override double DecicubicFeetInOneCubicMeter => 3.531472e2;
        protected override double CubicFeetInOneCubicMeter => 35.31472;
        protected override double DecacubicFeetInOneCubicMeter => 3.531472;
        protected override double HectocubicFeetInOneCubicMeter => 3.531472e-1;
        protected override double KilocubicFeetInOneCubicMeter => 3.531472e-2;
        protected override double MegacubicFeetInOneCubicMeter => 3.531472e-5;
        protected override double GigacubicFeetInOneCubicMeter => 3.531472e-8;
        protected override double TeracubicFeetInOneCubicMeter => 3.531472e-11;
        protected override double PetacubicFeetInOneCubicMeter => 3.531472e-14;
        protected override double ExacubicFeetInOneCubicMeter => 3.531472e-17;
        protected override double ZettacubicFeetInOneCubicMeter => 3.531472e-20;
        protected override double YottacubicFeetInOneCubicMeter => 3.531472e-23;
        protected override double QutracubicFeetInOneCubicMeter => 3.531472e-26;
        protected override double VettacubicFeetInOneCubicMeter => 3.531472e-29;

        protected override double CubicInchesInOneCubicMeter => 61023.98242;
        protected override double CubicKilometersInOneCubicMeter => 1E-9;
        protected override double CubicHectometersInOneCubicMeter => 1E-6;

        protected override double FemtocubicMetersInOneCubicMeter => 1e15;
        protected override double PicocubicMetersInOneCubicMeter => 1e12;
        protected override double NanocubicMetersInOneCubicMeter => 1e9;
        protected override double MicrocubicMetersInOneCubicMeter => 1e6;
        protected override double MillicubicMetersInOneCubicMeter => 1e3;
        protected override double CenticubicMetersInOneCubicMeter => 1e2;
        protected override double DecicubicMetersInOneCubicMeter => 1e1;
        protected override double CubicMetersInOneCubicMeter => 1;
        protected override double DecacubicMetersInOneCubicMeter => 0.1;
        protected override double HectocubicMetersInOneCubicMeter => 0.01;
        protected override double KilocubicMetersInOneCubicMeter => 0.001;
        protected override double MegacubicMetersInOneCubicMeter => 1e-6;
        protected override double GigacubicMetersInOneCubicMeter => 1e-9;
        protected override double TeracubicMetersInOneCubicMeter => 1e-12;
        protected override double PetacubicMetersInOneCubicMeter => 1e-15;
        protected override double ExacubicMetersInOneCubicMeter => 1e-18;
        protected override double ZettacubicMetersInOneCubicMeter => 1e-21;
        protected override double YottacubicMetersInOneCubicMeter => 1e-24;
        protected override double QutracubicMetersInOneCubicMeter => 1e-27;
        protected override double VettacubicMetersInOneCubicMeter => 1e-30;


        protected override double CubicMilesInOneCubicMeter => 2.399127585789277e-10;
        protected override double CubicMillimetersInOneCubicMeter => 1E9;
        protected override double CubicMicrometersInOneCubicMeter => 1E18;
        protected override double CubicYardsInOneCubicMeter => 1.30795062;
        protected override double ImperialGallonsInOneCubicMeter => 219.96924;
        protected override double ImperialOuncesInOneCubicMeter => 35195.07972;
        protected override double KiloimperialGallonsInOneCubicMeter => 2.1996924e-1;
        protected override double KilousGallonsInOneCubicMeter => 2.6417217e-1;
        protected override double FemtolitersInOneCubicMeter => 1e18;
        protected override double PicolitersInOneCubicMeter => 1e15;
        protected override double NanolitersInOneCubicMeter => 1e12;
        protected override double MicrolitersInOneCubicMeter => 1E9;
        protected override double MillilitersInOneCubicMeter => 1E6;
        protected override double CentilitersInOneCubicMeter => 1E5;
        protected override double DecilitersInOneCubicMeter => 1E4;
        protected override double LitersInOneCubicMeter => 1E3;
        protected override double DecalitersInOneCubicMeter => 1e2;
        protected override double HectolitersInOneCubicMeter => 1E1;
        protected override double KilolitersInOneCubicMeter => 1;
        protected override double MegalitersInOneCubicMeter => 1e-3;
        protected override double GigalitersInOneCubicMeter => 1e-6;
        protected override double TeralitersInOneCubicMeter => 1e-9;
        protected override double PetalitersInOneCubicMeter => 1e-12;
        protected override double ExalitersInOneCubicMeter => 1e-15;
        protected override double ZettalitersInOneCubicMeter => 1e-18;
        protected override double YottalitersInOneCubicMeter => 1e-21;
        protected override double QutralitersInOneCubicMeter => 1e-24;
        protected override double VettalitersInOneCubicMeter => 1e-27;
        protected override double MegaimperialGallonsInOneCubicMeter => 2.1996924e-4;
        protected override double MegausGallonsInOneCubicMeter => 2.6417217e-4;
        protected override double AuTablespoonsInOneCubicMeter => 50000;
        protected override double UsTablespoonsInOneCubicMeter => 67628.0454;
        protected override double MetricTeaspoonsInOneCubicMeter => 200000;
        protected override double UsTeaspoonsInOneCubicMeter => 202884.13621105801;
        protected override double ImperialBeerBarrelsInOneCubicMeter => 6.1102568972;
        protected override double UkTablespoonsInOneCubicMeter => 66666.6666667;
        protected override double UsBeerBarrelsInOneCubicMeter => 8.5216790723083;
        protected override double UsGallonsInOneCubicMeter => 264.17217;
        protected override double UsOuncesInOneCubicMeter => 33814.02270;
        protected override double MetricCupsInOneCubicMeter => 4000;
        protected override double UsCustomaryCupsInOneCubicMeter => 4226.75283773;

        protected override double UsLegalCupsInOneCubicMeter => 4166.666666667;

        protected override double OilBarrelsInOneCubicMeter => 6.2898107704321051280928552764086;

        protected override double UsPintsInOneCubicMeter => 2113.3764188652;

        protected override double UsQuartsInOneCubicMeter => 1056.6882094326;

        protected override double AcreFeetInOneCubicMeter => 0.000810714;

        protected override double ImperialPintsInOneCubicMeter => 1.7597539863927023e3;

        [ Fact]
        public void VolumeDividedByAreaEqualsLength()
        {
            Length length = Volume.FromCubicMeters(15)/Area.FromSquareMeters(5);
            Assert.Equal(length, Length.FromMeters(3));
        }

        [Fact]
        public void VolumeDividedByLengthEqualsArea()
        {
            Area area = Volume.FromCubicMeters(15)/Length.FromMeters(5);
            Assert.Equal(area, Area.FromSquareMeters(3));
        }

        [Fact]
        public void VolumeTimesDensityEqualsMass()
        {
            Mass mass = Volume.FromCubicMeters(2)*Density.FromKilogramsPerCubicMeter(3);
            Assert.Equal(mass, Mass.FromKilograms(6));
        }

        [Theory]
        [InlineData(20, 2, 10)]
        [InlineData(20, 80, 0.25)]
        public void VolumeDividedByTimeSpanEqualsVolumeFlow(double cubicMeters, double seconds, double expectedCubicMetersPerSecond)
        {
            VolumeFlow volumeFlow = Volume.FromCubicMeters(cubicMeters) / TimeSpan.FromSeconds(seconds);
            Assert.Equal(VolumeFlow.FromCubicMetersPerSecond(expectedCubicMetersPerSecond), volumeFlow);
        }

        [Fact]
        public void VolumeDividedByDurationEqualsVolumeFlow()
        {
            VolumeFlow volumeFlow = Volume.FromCubicMeters(20) / Duration.FromSeconds(2);
            Assert.Equal(VolumeFlow.FromCubicMetersPerSecond(10), volumeFlow);
        }

        [Fact]
        public void VolumeDividedByVolumeFlowEqualsTimeSpan()
        {
            TimeSpan timeSpan = Volume.FromCubicMeters(20) / VolumeFlow.FromCubicMetersPerSecond(2);
            Assert.Equal(TimeSpan.FromSeconds(10), timeSpan);
        }
    }
}
