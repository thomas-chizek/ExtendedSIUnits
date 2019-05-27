﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class AreaTests : AreaTestsBase
    {

        protected override double SquareKilometersInOneSquareMeter => 1E-6;

        protected override double SquareMetersInOneSquareMeter => 1;

        protected override double AcresInOneSquareMeter => 2.471053816137*1E-4;

        protected override double HectaresInOneSquareMeter => 1E-4;

        protected override double SquareCentimetersInOneSquareMeter => 1E4;

        protected override double SquareDecimetersInOneSquareMeter => 1E2;

        protected override double SquareMillimetersInOneSquareMeter => 1E6;

        protected override double SquareFeetInOneSquareMeter => 10.76391;

        protected override double SquareMicrometersInOneSquareMeter => 1E12;

        protected override double SquareInchesInOneSquareMeter => 1550.003100;

        protected override double SquareMilesInOneSquareMeter => 3.86102*1E-7;

        protected override double SquareYardsInOneSquareMeter => 1.19599;

        protected override double UsSurveySquareFeetInOneSquareMeter => 10.76386736111121;

        [Fact]
        public void AreaDividedByLengthEqualsLength()
        {
            Length length = Area.FromSquareMeters(50)/Length.FromMeters(5);
            Assert.Equal(length, Length.FromMeters(10));
        }

        [Fact]
        public void AreaTimesMassFluxEqualsMassFlow()
        {
            MassFlow massFlow = Area.FromSquareMeters(20) * MassFlux.FromKilogramsPerSecondPerSquareMeter(2);
            Assert.Equal(massFlow, MassFlow.FromKilogramsPerSecond(40));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0.5, 0.19634954084936208)]
        [InlineData(1, 0.7853981633974483)]
        [InlineData(2, 3.141592653589793)]
        public void AreaFromCicleDiameterCalculatedCorrectly(double diameterMeters, double expected)
        {
            Length diameter = Length.FromMeters(diameterMeters);

            double actual = Area.FromCircleDiameter(diameter).SquareMeters;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0.5, 0.7853981633974483)]
        [InlineData(1, 3.141592653589793)]
        [InlineData(2, 12.566370614359173)]
        public void AreaFromCicleRadiusCalculatedCorrectly(double radiusMeters, double expected)
        {
            Length radius = Length.FromMeters(radiusMeters);

            double actual = Area.FromCircleRadius(radius).SquareMeters;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AreaTimesSpeedEqualsVolumeFlow()
        {
            VolumeFlow volumeFlow = Area.FromSquareMeters(20) * Speed.FromMetersPerSecond(2);
            Assert.Equal(VolumeFlow.FromCubicMetersPerSecond(40), volumeFlow);
        }

        [Fact]
        public void Constructor_UnitSystemSI_AssignsSIUnit()
        {
            var area = new Area(1.0, UnitSystem.SI);
            Assert.Equal(AreaUnit.SquareMeter, area.Unit);
        }

        [Fact]
        public void As_GivenSIUnitSystem_ReturnsSIValue()
        {
            var squareInches = new Area(2.0, AreaUnit.SquareInch);
            Assert.Equal(0.00129032, squareInches.As(UnitSystem.SI));
        }

        [Fact]
        public void ToUnit_GivenSIUnitSystem_ReturnsSIQuantity()
        {
            var squareInches = new Area(2.0, AreaUnit.SquareInch);

            var inSI = squareInches.ToUnit(UnitSystem.SI);

            Assert.Equal(0.00129032, inSI.Value);
            Assert.Equal(AreaUnit.SquareMeter, inSI.Unit);
        }
    }
}
