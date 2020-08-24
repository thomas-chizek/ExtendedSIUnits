// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Tests.Helpers;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class MassTests : MassTestsBase
    {



        protected override double FemtogramsInOneKilogram => 1e18;
        protected override double PicogramsInOneKilogram => 1e15;
        protected override double NanogramsInOneKilogram => 1E12;
        protected override double MicrogramsInOneKilogram => 1E9;
        protected override double MilligramsInOneKilogram => 1E6;
        protected override double CentigramsInOneKilogram => 1E5;
        protected override double DecigramsInOneKilogram => 1E4;
        protected override double GramsInOneKilogram => 1E3;
        protected override double DecagramsInOneKilogram => 1E2;
        protected override double HectogramsInOneKilogram => 10;
        protected override double KilogramsInOneKilogram => 1;
        protected override double MegagramsInOneKilogram => 1e-3;
        protected override double GigagramsInOneKilogram => 1e-6;
        protected override double TeragramsInOneKilogram => 1e-9;
        protected override double PetagramsInOneKilogram => 1e-12;
        protected override double ExagramsInOneKilogram => 1e-15;
        protected override double ZettagramsInOneKilogram => 1e-18;
        protected override double YottagramsInOneKilogram => 1e-21;
        protected override double QutragramsInOneKilogram => 1e-24;
        protected override double VettagramsInOneKilogram => 1e-27;



        protected override double TonnesInOneKilogram => 1E-3;
        protected override double KilotonnesInOneKilogram => 1E-6;
        protected override double MegatonnesInOneKilogram => 1E-9;
        protected override double GigatonnesInOneKilogram => 1E-12;
        protected override double TeratonnesInOneKilogram => 1E-15;
        protected override double PetatonnesInOneKilogram => 1E-18;
        protected override double ExatonnesInOneKilogram => 1E-21;
        protected override double ZettatonnesInOneKilogram => 1E-24;
        protected override double YottatonnesInOneKilogram => 1E-27;
        protected override double QutratonnesInOneKilogram => 1E-30;
        protected override double VettatonnesInOneKilogram => 1e-33;


        protected override double GrainsInOneKilogram => 15432.358352941431d;
        protected override double KilopoundsInOneKilogram => 2.2046226218487757e-3;
        protected override double LongTonsInOneKilogram => 9.842065276110606e-4;
        protected override double MegapoundsInOneKilogram => 2.2046226218487757e-6;
        protected override double NanogramsTolerance => 1E-3;
        protected override double OuncesInOneKilogram => 35.2739619;
        protected override double PoundsInOneKilogram => 2.2046226218487757d;
        protected override double ShortTonsInOneKilogram => 1.102311310924388e-3;
        protected override double SlugsInOneKilogram => 6.852176556196105e-2;
        protected override double StoneInOneKilogram => 0.1574731728702698;
        protected override double LongHundredweightInOneKilogram => 0.01968413055222121;
        protected override double ShortHundredweightInOneKilogram => 0.022046226218487758;



        protected override double MicroearthMassInOneKilogram => PrefixMultipliers.Apply(EarthMassInOneKilogram, Prefix.micro);
        protected override double MilliearthMassInOneKilogram => PrefixMultipliers.Apply(EarthMassInOneKilogram, Prefix.milli);
        protected override double CentiearthMassInOneKilogram => PrefixMultipliers.Apply(EarthMassInOneKilogram, Prefix.ceni);
        protected override double DeciearthMassInOneKilogram => PrefixMultipliers.Apply(EarthMassInOneKilogram, Prefix.deci);
        protected override double EarthMassInOneKilogram => 1.67442763877238E-25;
        protected override double DecaearthMassInOneKilogram => PrefixMultipliers.Apply(EarthMassInOneKilogram, Prefix.deca);
        protected override double HectoearthMassInOneKilogram => PrefixMultipliers.Apply(EarthMassInOneKilogram, Prefix.hecto);
        protected override double KiloearthMassInOneKilogram => PrefixMultipliers.Apply(EarthMassInOneKilogram, Prefix.kilo);
        protected override double MegaearthMassInOneKilogram => PrefixMultipliers.Apply(EarthMassInOneKilogram, Prefix.mega);


        protected override double CentijupiterMassInOneKilogram => PrefixMultipliers.Apply(JupiterMassInOneKilogram, Prefix.ceni);
        protected override double DecijupiterMassInOneKilogram => PrefixMultipliers.Apply(JupiterMassInOneKilogram, Prefix.deci);
        protected override double JupiterMassInOneKilogram => 5.26703887074687E-28;
        protected override double DecajupiterMassInOneKilogram => PrefixMultipliers.Apply(JupiterMassInOneKilogram, Prefix.deca);
        protected override double HectojupiterMassInOneKilogram => PrefixMultipliers.Apply(JupiterMassInOneKilogram, Prefix.hecto);
        protected override double KilojupiterMassInOneKilogram => PrefixMultipliers.Apply(JupiterMassInOneKilogram, Prefix.kilo);
        protected override double MegajupiterMassInOneKilogram => PrefixMultipliers.Apply(JupiterMassInOneKilogram, Prefix.mega);
        protected override double GigajupiterMassInOneKilogram => PrefixMultipliers.Apply(JupiterMassInOneKilogram, Prefix.giga);
        protected override double TerajupiterMassInOneKilogram => PrefixMultipliers.Apply(JupiterMassInOneKilogram, Prefix.tera);


        protected override double MicrosolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.micro);
        protected override double MillisolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.milli);
        protected override double CentisolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.ceni);
        protected override double DecisolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.deci);
        protected override double SolarMassInOneKilogram => 5.0278543101127E-31;
        protected override double DecasolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.deca);
        protected override double HectosolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.hecto);
        protected override double KilosolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.kilo);
        protected override double MegasolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.mega);
        protected override double GigasolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.giga);
        protected override double TerasolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.tera);
        protected override double PetasolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.peta);
        protected override double ExasolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.exa);
        protected override double ZettasolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.zetta);
        protected override double YottasolarMassInOneKilogram => PrefixMultipliers.Apply(SolarMassInOneKilogram, Prefix.yotta);


        [Fact]
        public void AccelerationTimesMassEqualsForce()
        {
            Force force = Acceleration.FromMetersPerSecondSquared(3)*Mass.FromKilograms(18);
            Assert.Equal(force, Force.FromNewtons(54));
        }

        [Fact]
        public void MassDividedByDurationEqualsMassFlow()
        {
            MassFlow massFlow = Mass.FromKilograms(18.0)/Duration.FromSeconds(6);
            Assert.Equal(massFlow, MassFlow.FromKilogramsPerSecond(3.0));
        }

        [Fact]
        public void MassDividedByTimeSpanEqualsMassFlow()
        {
            MassFlow massFlow = Mass.FromKilograms(18.0)/TimeSpan.FromSeconds(6);
            Assert.Equal(massFlow, MassFlow.FromKilogramsPerSecond(3.0));
        }

        [Fact]
        public void MassDividedByVolumeEqualsDensity()
        {
            Density density = Mass.FromKilograms(18)/Volume.FromCubicMeters(3);
            Assert.Equal(density, Density.FromKilogramsPerCubicMeter(6));
        }

        [Fact]
        public void MassTimesAccelerationEqualsForce()
        {
            Force force = Mass.FromKilograms(18)*Acceleration.FromMetersPerSecondSquared(3);
            Assert.Equal(force, Force.FromNewtons(54));
        }

        [Fact]
        public void NegativeMassToStonePoundsReturnsCorrectValues()
        {
            var negativeMass = Mass.FromPounds(-1.0);
            var stonePounds = negativeMass.StonePounds;

            Assert.Equal(0, stonePounds.Stone);
            Assert.Equal(-1.0, stonePounds.Pounds);

            negativeMass = Mass.FromPounds(-25.0);
            stonePounds = negativeMass.StonePounds;

            Assert.Equal(-1.0, stonePounds.Stone);
            Assert.Equal(-11.0, stonePounds.Pounds);
        }

        [Theory]
        [InlineData(10, MassUnit.Gram,
                    KnownQuantities.MolarMassOfOxygen, MolarMassUnit.GramPerMole,
                    0.625023438378939, AmountOfSubstanceUnit.Mole)]     // 10 grams Of Oxygen contain 0.625023438378939 Moles
        public void AmountOfSubstanceFromMassAndMolarMass(
            double massValue, MassUnit massUnit,
            double molarMassValue, MolarMassUnit molarMassUnit,
            double expectedAmountOfSubstanceValue, AmountOfSubstanceUnit expectedAmountOfSubstanceUnit, double tolerence = 1e-5)
        {
            var mass = new Mass(massValue, massUnit);
            var molarMass = new MolarMass(molarMassValue, molarMassUnit);

            AmountOfSubstance amountOfSubstance = mass / molarMass;

            AssertEx.EqualTolerance(expectedAmountOfSubstanceValue, amountOfSubstance.As(expectedAmountOfSubstanceUnit), tolerence);
        }
    }
}
