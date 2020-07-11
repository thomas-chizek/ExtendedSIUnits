// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class SpeedTests : SpeedTestsBase
    {
        protected override double FeetPerSecondInOneMeterPerSecond => 3.28084;
        protected override double KnotsInOneMeterPerSecond => 1.94384;
        protected override double MilesPerHourInOneMeterPerSecond => 2.23694;
        protected override double FeetPerHourInOneMeterPerSecond => 1.1811023622E4;
        protected override double FeetPerMinuteInOneMeterPerSecond => 1.96850393701E2;
        protected override double InchesPerHourInOneMeterPerSecond => 1.41732283465E5;
        protected override double InchesPerMinuteInOneMeterPerSecond => 2.36220472441E3;
        protected override double InchesPerSecondInOneMeterPerSecond => 3.93700787402E1;
        protected override double YardsPerHourInOneMeterPerSecond => 3.93700787402E3;
        protected override double YardsPerMinuteInOneMeterPerSecond => 6.56167979003E1;
        protected override double YardsPerSecondInOneMeterPerSecond => 1.093613298338;
        protected override double UsSurveyFeetPerSecondInOneMeterPerSecond => 3.280833333333;
        protected override double UsSurveyFeetPerMinuteInOneMeterPerSecond => 1.9685E2;
        protected override double UsSurveyFeetPerHourInOneMeterPerSecond => 1.1811E4;


        protected override double FemtometersPerMinutesInOneMeterPerSecond => 6e16;
        protected override double PicometersPerMinutesInOneMeterPerSecond => 6e13;
        protected override double NanometersPerMinutesInOneMeterPerSecond => 6E10;
        protected override double MicrometersPerMinutesInOneMeterPerSecond => 6E7;
        protected override double MillimetersPerMinutesInOneMeterPerSecond => 6E4;
        protected override double CentimetersPerMinutesInOneMeterPerSecond => 6E3;
        protected override double DecimetersPerMinutesInOneMeterPerSecond => 6E2;
        protected override double MetersPerMinutesInOneMeterPerSecond => 60;
        protected override double DecametersPerMinutesInOneMeterPerSecond => 6;
        protected override double HectometersPerMinutesInOneMeterPerSecond => .6;
        protected override double KilometersPerMinutesInOneMeterPerSecond => 6E-2;
        protected override double MegametersPerMinutesInOneMeterPerSecond => 6e-5;
        protected override double GigametersPerMinutesInOneMeterPerSecond => 6e-8;
        protected override double TerametersPerMinutesInOneMeterPerSecond => 6e-11;
        protected override double PetametersPerMinutesInOneMeterPerSecond => 6e-14;
        protected override double ExametersPerMinutesInOneMeterPerSecond => 6e-17;
        protected override double ZettametersPerMinutesInOneMeterPerSecond => 6e-20;
        protected override double YottametersPerMinutesInOneMeterPerSecond => 6e-23;
        protected override double QutrametersPerMinutesInOneMeterPerSecond => 6e-26;
        protected override double VettametersPerMinutesInOneMeterPerSecond => 6e-29;

        protected override double FemtometersPerHourInOneMeterPerSecond => 3.6e18;
        protected override double PicometersPerHourInOneMeterPerSecond => 3.6e15;
        protected override double NanometersPerHourInOneMeterPerSecond => 3.6e12;
        protected override double MicrometersPerHourInOneMeterPerSecond => 3.6e9;
        protected override double MillimetersPerHourInOneMeterPerSecond => 3.6E6;
        protected override double CentimetersPerHourInOneMeterPerSecond => 3.6E5;
        protected override double DecimetersPerHourInOneMeterPerSecond => 36000;
        protected override double MetersPerHourInOneMeterPerSecond => 3.6E3;
        protected override double DecametersPerHourInOneMeterPerSecond => 360;
        protected override double HectometersPerHourInOneMeterPerSecond => 36.0;
        protected override double KilometersPerHourInOneMeterPerSecond => 3.6;
        protected override double MegametersPerHourInOneMeterPerSecond => 3.6e-3;
        protected override double GigametersPerHourInOneMeterPerSecond => 3.6e-6;
        protected override double TerametersPerHourInOneMeterPerSecond => 3.6e-9;
        protected override double PetametersPerHourInOneMeterPerSecond => 3.6e-12;
        protected override double ExametersPerHourInOneMeterPerSecond => 3.6E-15;
        protected override double ZettametersPerHourInOneMeterPerSecond => 3.6E-18;
        protected override double YottametersPerHourInOneMeterPerSecond => 3.6E-21;
        protected override double QutrametersPerHourInOneMeterPerSecond => 3.6E-24;
        protected override double VettametersPerHourInOneMeterPerSecond => 3.6E-27;

        protected override double FemtometersPerSecondInOneMeterPerSecond => 1e15;
        protected override double PicometersPerSecondInOneMeterPerSecond => 1e12;
        protected override double NanometersPerSecondInOneMeterPerSecond => 1E9;
        protected override double MicrometersPerSecondInOneMeterPerSecond => 1E6;
        protected override double MillimetersPerSecondInOneMeterPerSecond => 1E3;
        protected override double CentimetersPerSecondInOneMeterPerSecond => 1E2;
        protected override double DecimetersPerSecondInOneMeterPerSecond => 1E1;
        protected override double MetersPerSecondInOneMeterPerSecond => 1;
        protected override double DecametersPerSecondInOneMeterPerSecond => 0.1;
        protected override double HectometersPerSecondInOneMeterPerSecond => 1e-2;
        protected override double KilometersPerSecondInOneMeterPerSecond => 1E-3;
        protected override double MegametersPerSecondInOneMeterPerSecond => 1e-6;
        protected override double GigametersPerSecondInOneMeterPerSecond => 1e-9;
        protected override double TerametersPerSecondInOneMeterPerSecond => 1e-12;
        protected override double PetametersPerSecondInOneMeterPerSecond => 1e-15;
        protected override double ExametersPerSecondInOneMeterPerSecond => 1e-18;
        protected override double ZettametersPerSecondInOneMeterPerSecond => 1e-21;
        protected override double YottametersPerSecondInOneMeterPerSecond => 1e-24;
        protected override double QutrametersPerSecondInOneMeterPerSecond =>1e-27;
        protected override double VettametersPerSecondInOneMeterPerSecond => 1e-30;

        [Fact]
        public void DurationSpeedTimesEqualsLength()
        {
            Length length = Duration.FromSeconds(2)*Speed.FromMetersPerSecond(20);
            Assert.Equal(length, Length.FromMeters(40));
        }

        [Fact]
        public void LengthDividedByDurationEqualsSpeed()
        {
            Speed speed = Length.FromMeters(20)/Duration.FromSeconds(2);
            Assert.Equal(speed, Speed.FromMetersPerSecond(10));
        }

        [Fact]
        public void LengthDividedByTimeSpanEqualsSpeed()
        {
            Speed speed = Length.FromMeters(20)/TimeSpan.FromSeconds(2);
            Assert.Equal(speed, Speed.FromMetersPerSecond(10));
        }

        [Fact]
        public void SpeedDividedByDurationEqualsAcceleration()
        {
            Acceleration acceleration = Speed.FromMetersPerSecond(20)/Duration.FromSeconds(2);
            Assert.Equal(acceleration, Acceleration.FromMetersPerSecondSquared(10));
        }

        [Fact]
        public void SpeedDividedByTimeSpanEqualsAcceleration()
        {
            Acceleration acceleration = Speed.FromMetersPerSecond(20)/TimeSpan.FromSeconds(2);
            Assert.Equal(acceleration, Acceleration.FromMetersPerSecondSquared(10));
        }

        [Fact]
        public void SpeedTimesDurationEqualsLength()
        {
            Length length = Speed.FromMetersPerSecond(20)*Duration.FromSeconds(2);
            Assert.Equal(length, Length.FromMeters(40));
        }

        [Fact]
        public void SpeedTimesTimeSpanEqualsLength()
        {
            Length length = Speed.FromMetersPerSecond(20)*TimeSpan.FromSeconds(2);
            Assert.Equal(length, Length.FromMeters(40));
        }

        [Fact]
        public void TimeSpanTimesSpeedEqualsLength()
        {
            Length length = TimeSpan.FromSeconds(2)*Speed.FromMetersPerSecond(20);
            Assert.Equal(length, Length.FromMeters(40));
        }

        [Fact]
        public void SpeedTimesLengthEqualsKinematicViscosity()
        {
            KinematicViscosity kinematicViscosity = Length.FromMeters(20) * Speed.FromMetersPerSecond(2);
            Assert.Equal(KinematicViscosity.FromSquareMetersPerSecond(40), kinematicViscosity);
        }

        [Fact]
        public void SpeedTimesSpeedEqualsSpecificEnergy()
        {
            //m^2/s^2 = kg*m*m/(s^2*kg) = J/kg
            SpecificEnergy length = Speed.FromMetersPerSecond(2) * Speed.FromMetersPerSecond(20);
            Assert.Equal(length, SpecificEnergy.FromJoulesPerKilogram(40));
        }

        [Fact]
        public void SpeedTimesDensityEqualsMassFlux()
        {
            MassFlux massFlux = Speed.FromMetersPerSecond(20) * Density.FromKilogramsPerCubicMeter(2);
            Assert.Equal(massFlux, MassFlux.FromKilogramsPerSecondPerSquareMeter(40));
        }

        [Fact]
        public void SpeedTimesAreaEqualsVolumeFlow()
        {
            VolumeFlow volumeFlow = Speed.FromMetersPerSecond(2) * Area.FromSquareMeters(20);
            Assert.Equal(VolumeFlow.FromCubicMetersPerSecond(40), volumeFlow);
        }
    }
}
