// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class EnergyTests : EnergyTestsBase
    {
        protected override double ThermsImperialInOneJoule => 9.4781712e-9;

        protected override double JoulesInOneJoule => 1;

        protected override double KilobritishThermalUnitsInOneJoule => 9.4781712e-7;

        protected override double KilojoulesInOneJoule => 1E-3;

        protected override double MegabritishThermalUnitsInOneJoule =>9.4781712e-10;

        protected override double GigabritishThermalUnitsInOneJoule => 9.4781712e-13;

        protected override double TerabritishThermalUnitsInOneJoule => 9.4781712e-16;

        protected override double PetabritishThermalUnitsInOneJoule => 9.4781712e-19;

        protected override double ExabritishThermalUnitsInOneJoule => 9.4781712e-22;

        protected override double ZettabritishThermalUnitsInOneJoule => 9.4781712e-25;

        protected override double YottabritishThermalUnitsInOneJoule => 9.4781712e-28;

        protected override double QutrabritishThermalUnitsInOneJoule => 9.4781712e-31;

        protected override double VettabritishThermalUnitsInOneJoule => 9.4781712e-34;

        protected override double MegajoulesInOneJoule => 1E-6;
        protected override double GigajoulesInOneJoule => 1E-9;
        protected override double TerajoulesInOneJoule => 1E-12;
        protected override double PetajoulesInOneJoule => 1E-15;
        protected override double ExajoulesInOneJoule => 1E-18;
        protected override double ZettajoulesInOneJoule => 1E-21;
        protected override double YottajoulesInOneJoule => 1E-24;
        protected override double QutrajoulesInOneJoule => 1E-27;
        protected override double VettajoulesInOneJoule => 1E-30;

        protected override double BritishThermalUnitsInOneJoule => 0.00094781712;

        protected override double CaloriesInOneJoule => 0.239005736;

        protected override double DecathermsEcInOneJoule => 9.478171203133172e-10;

        protected override double DecathermsImperialInOneJoule => 9.478171203551087813109937767482e-10;

        protected override double DecathermsUsInOneJoule => 9.480434279733486e-10;

        protected override double ElectronVoltsInOneJoule => 6.241509343260179e18;

        protected override double ErgsInOneJoule => 10000000;

        protected override double TerawattHoursInOneJoule => 2.77777778e-16;
        protected override double PetawattHoursInOneJoule => 2.77777778e-19;
        protected override double ExawattHoursInOneJoule => 2.77777778e-22;
        protected override double ZettawattHoursInOneJoule => 2.77777778e-25;
        protected override double YottawattHoursInOneJoule => 2.77777778e-28;
        protected override double QutrawattHoursInOneJoule => 2.77777778e-31;
        protected override double VettawattHoursInOneJoule => 2.77777778e-34;

        protected override double ThermsEcInOneJoule => 9.4781712031331720001278504447561e-9;

        protected override double FootPoundsInOneJoule => 0.737562149;

        protected override double GigawattHoursInOneJoule => 2.77777778e-13;

        protected override double KilocaloriesInOneJoule => 0.00023900573614;

        protected override double KilowattHoursInOneJoule => 2.77777778e-7;

        protected override double MegawattHoursInOneJoule => 2.77777778e-10;

        protected override double ThermsUsInOneJoule => 9.4804342797334860315281322406817e-9;

        protected override double WattHoursInOneJoule => 0.000277777778;

        [Fact]
        public void Constructor_UnitSystemSI_AssignsSIUnit()
        {
            var energy = new Energy(1.0, UnitSystem.SI);
            Assert.Equal(EnergyUnit.Joule, energy.Unit);
        }

        [Fact]
        public void As_GivenSIUnitSystem_ReturnsSIValue()
        {
            var btus = new Energy(2.0, EnergyUnit.BritishThermalUnit);
            Assert.Equal(2110.11170524, btus.As(UnitSystem.SI));
        }

        [Fact]
        public void ToUnit_GivenSIUnitSystem_ReturnsSIQuantity()
        {
            var btus = new Energy(2.0, EnergyUnit.BritishThermalUnit);

            var inSI = btus.ToUnit(UnitSystem.SI);

            Assert.Equal(2110.11170524, inSI.Value);
            Assert.Equal(EnergyUnit.Joule, inSI.Unit);
        }
    }
}
