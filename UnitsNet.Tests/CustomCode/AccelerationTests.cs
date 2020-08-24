// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.Tests.Helpers;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class AccelerationTests : AccelerationTestsBase
    {
        protected override double FemtometersPerSecondSquaredInOneMeterPerSecondSquared => 1e15;
        protected override double PicometersPerSecondSquaredInOneMeterPerSecondSquared => 1e12;
        protected override double NanometersPerSecondSquaredInOneMeterPerSecondSquared => 1E9;
        protected override double MicrometersPerSecondSquaredInOneMeterPerSecondSquared => 1E6;
        protected override double MillimetersPerSecondSquaredInOneMeterPerSecondSquared => 1E3;
        protected override double CentimetersPerSecondSquaredInOneMeterPerSecondSquared => 1E2;
        protected override double DecimetersPerSecondSquaredInOneMeterPerSecondSquared => 1E1;

        protected override double MetersPerSecondSquaredInOneMeterPerSecondSquared => 1;
        protected override double DecametersPerSecondSquaredInOneMeterPerSecondSquared => 0.1;
        protected override double HectometersPerSecondSquaredInOneMeterPerSecondSquared => 1e-2;
        protected override double KilometersPerSecondSquaredInOneMeterPerSecondSquared => 1E-3;
        protected override double MegametersPerSecondSquaredInOneMeterPerSecondSquared => 1E-6;
        protected override double GigametersPerSecondSquaredInOneMeterPerSecondSquared => 1E-9;
        protected override double TerametersPerSecondSquaredInOneMeterPerSecondSquared => 1E-12;
        protected override double PetametersPerSecondSquaredInOneMeterPerSecondSquared => 1E-15;
        protected override double ExametersPerSecondSquaredInOneMeterPerSecondSquared => 1E-18;
        protected override double ZettametersPerSecondSquaredInOneMeterPerSecondSquared => 1E-21;
        protected override double YottametersPerSecondSquaredInOneMeterPerSecondSquared => 1E-24;
        protected override double QutrametersPerSecondSquaredInOneMeterPerSecondSquared => 1E-27;
        protected override double VettametersPerSecondSquaredInOneMeterPerSecondSquared => 1E-30;



        protected override double InchesPerSecondSquaredInOneMeterPerSecondSquared => 39.3700787;

        protected override double FeetPerSecondSquaredInOneMeterPerSecondSquared => 3.28084;
        protected override double MilesPerHourSquaredInOneMeterPerSecondSquared => 2.23694;
        protected override double KnotsPerHourInOneMeterPerSecondSquared => 6.99784017278618E3;
        protected override double KnotsPerMinuteInOneMeterPerSecondSquared => 1.16630669546436E2;
        protected override double KnotsPerSecondInOneMeterPerSecondSquared => 1.94384449244060;


        protected override double NanolightsecondsPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(LightsecondsPerHourSquaredInOneMeterPerSecondSquared, Prefix.nano);
        protected override double MicrolightsecondsPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(LightsecondsPerHourSquaredInOneMeterPerSecondSquared, Prefix.micro);
        protected override double MillilightsecondsPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(LightsecondsPerHourSquaredInOneMeterPerSecondSquared, Prefix.milli);
        protected override double CentilightsecondsPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(LightsecondsPerHourSquaredInOneMeterPerSecondSquared, Prefix.ceni);
        protected override double DecilightsecondsPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(LightsecondsPerHourSquaredInOneMeterPerSecondSquared, Prefix.deci);
        protected override double LightsecondsPerHourSquaredInOneMeterPerSecondSquared => 83277.8147901399;
        protected override double DecalightsecondsPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(LightsecondsPerHourSquaredInOneMeterPerSecondSquared, Prefix.deca);
        protected override double KilolightsecondsPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(LightsecondsPerHourSquaredInOneMeterPerSecondSquared, Prefix.kilo);

        protected override double PicometersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.pico);
        protected override double FemtometersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.femto);
        protected override double NanometersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.nano);
        protected override double MicrometersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.micro);
        protected override double MillimetersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.milli);
        protected override double CentimetersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.ceni);
        protected override double DecimetersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.deci);
        protected override double MetersPerHourSquaredInOneMeterPerSecondSquared => 3600;
        protected override double DecametersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.deca);
        protected override double HectometersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.hecto);
        protected override double KilometersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.kilo);
        protected override double GigametersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.giga);
        protected override double MegametersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.mega);
        protected override double TerametersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.tera);
        protected override double PetametersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.peta);
        protected override double ExametersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.exa);
        protected override double ZettametersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.zetta);
        protected override double YottametersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.yotta);
        protected override double QutrametersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.qutra);
        protected override double VettametersPerHourSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerHourSquaredInOneMeterPerSecondSquared, Prefix.vetta);



        protected override double FemtometersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.femto);
        protected override double PicometersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.pico);
        protected override double NanometersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.nano);
        protected override double MicrometersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.micro);
        protected override double MillimetersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.milli);
        protected override double CentimetersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.ceni);
        protected override double DecimetersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.deci);
        protected override double MetersPerMinutesSquaredInOneMeterPerSecondSquared => 60;
        protected override double DecametersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.deca);
        protected override double HectometersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.hecto);
        protected override double KilometersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.kilo);
        protected override double MegametersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.mega);
        protected override double GigametersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.giga);
        protected override double TerametersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.tera);
        protected override double PetametersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.peta);
        protected override double ExametersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.exa);
        protected override double ZettametersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.zetta);
        protected override double YottametersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.yotta);
        protected override double QutrametersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.qutra);
        protected override double VettametersPerMinutesSquaredInOneMeterPerSecondSquared => PrefixMultipliers.Apply(MetersPerMinutesSquaredInOneMeterPerSecondSquared, Prefix.vetta);



        protected override double NanostandardGravityInOneMeterPerSecondSquared => PrefixMultipliers.Apply(StandardGravityInOneMeterPerSecondSquared, Prefix.nano);
        protected override double MicrostandardGravityInOneMeterPerSecondSquared => PrefixMultipliers.Apply(StandardGravityInOneMeterPerSecondSquared, Prefix.micro);
        protected override double MillistandardGravityInOneMeterPerSecondSquared => PrefixMultipliers.Apply(StandardGravityInOneMeterPerSecondSquared, Prefix.milli);
        protected override double CentistandardGravityInOneMeterPerSecondSquared => PrefixMultipliers.Apply(StandardGravityInOneMeterPerSecondSquared, Prefix.ceni);
        protected override double DecistandardGravityInOneMeterPerSecondSquared => PrefixMultipliers.Apply(StandardGravityInOneMeterPerSecondSquared, Prefix.deci);
        protected override double StandardGravityInOneMeterPerSecondSquared => 0.101971621297793;
        protected override double DecastandardGravityInOneMeterPerSecondSquared => PrefixMultipliers.Apply(StandardGravityInOneMeterPerSecondSquared, Prefix.deca);
        protected override double HectostandardGravityInOneMeterPerSecondSquared => PrefixMultipliers.Apply(StandardGravityInOneMeterPerSecondSquared, Prefix.hecto);
        protected override double KilostandardGravityInOneMeterPerSecondSquared => PrefixMultipliers.Apply(StandardGravityInOneMeterPerSecondSquared, Prefix.kilo);
        protected override double MegastandardGravityInOneMeterPerSecondSquared => PrefixMultipliers.Apply(StandardGravityInOneMeterPerSecondSquared, Prefix.mega);
        protected override double GigastandardGravityInOneMeterPerSecondSquared => PrefixMultipliers.Apply(StandardGravityInOneMeterPerSecondSquared, Prefix.giga);
        protected override double TerastandardGravityInOneMeterPerSecondSquared => PrefixMultipliers.Apply(StandardGravityInOneMeterPerSecondSquared, Prefix.tera);

        [Fact]
        public void AccelerationTimesDensityEqualsSpecificWeight()
        {
            SpecificWeight specificWeight = Acceleration.FromMetersPerSecondSquared(10) * Density.FromKilogramsPerCubicMeter(2);
            Assert.Equal(SpecificWeight.FromNewtonsPerCubicMeter(20), specificWeight);
        }

        [Fact]
        public void EarlyAccessOfAccelerationStatics()
        {
            AccelerationUnit b = Acceleration.BaseUnit;
            Acceleration o = Acceleration.One;
            Acceleration a = new Acceleration(-1, b);
            Acceleration expected = new Acceleration(-1, Acceleration.BaseUnit);
            Assert.Equal(Acceleration.One, o);
            Assert.Equal(expected, a);
            Assert.Equal(Acceleration.BaseUnit, b);
        }
    }
}
