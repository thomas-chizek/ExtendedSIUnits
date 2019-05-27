﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Area.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AreaTestsBase
    {
        protected abstract double AcresInOneSquareMeter { get; }
        protected abstract double HectaresInOneSquareMeter { get; }
        protected abstract double SquareCentimetersInOneSquareMeter { get; }
        protected abstract double SquareDecimetersInOneSquareMeter { get; }
        protected abstract double SquareFeetInOneSquareMeter { get; }
        protected abstract double SquareInchesInOneSquareMeter { get; }
        protected abstract double SquareKilometersInOneSquareMeter { get; }
        protected abstract double SquareMetersInOneSquareMeter { get; }
        protected abstract double SquareMicrometersInOneSquareMeter { get; }
        protected abstract double SquareMilesInOneSquareMeter { get; }
        protected abstract double SquareMillimetersInOneSquareMeter { get; }
        protected abstract double SquareYardsInOneSquareMeter { get; }
        protected abstract double UsSurveySquareFeetInOneSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AcresTolerance { get { return 1e-5; } }
        protected virtual double HectaresTolerance { get { return 1e-5; } }
        protected virtual double SquareCentimetersTolerance { get { return 1e-5; } }
        protected virtual double SquareDecimetersTolerance { get { return 1e-5; } }
        protected virtual double SquareFeetTolerance { get { return 1e-5; } }
        protected virtual double SquareInchesTolerance { get { return 1e-5; } }
        protected virtual double SquareKilometersTolerance { get { return 1e-5; } }
        protected virtual double SquareMetersTolerance { get { return 1e-5; } }
        protected virtual double SquareMicrometersTolerance { get { return 1e-5; } }
        protected virtual double SquareMilesTolerance { get { return 1e-5; } }
        protected virtual double SquareMillimetersTolerance { get { return 1e-5; } }
        protected virtual double SquareYardsTolerance { get { return 1e-5; } }
        protected virtual double UsSurveySquareFeetTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Area((double)0.0, AreaUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Area(double.PositiveInfinity, AreaUnit.SquareMeter));
            Assert.Throws<ArgumentException>(() => new Area(double.NegativeInfinity, AreaUnit.SquareMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Area(double.NaN, AreaUnit.SquareMeter));
        }

        [Fact]
        public void SquareMeterToAreaUnits()
        {
            Area squaremeter = Area.FromSquareMeters(1);
            AssertEx.EqualTolerance(AcresInOneSquareMeter, squaremeter.Acres, AcresTolerance);
            AssertEx.EqualTolerance(HectaresInOneSquareMeter, squaremeter.Hectares, HectaresTolerance);
            AssertEx.EqualTolerance(SquareCentimetersInOneSquareMeter, squaremeter.SquareCentimeters, SquareCentimetersTolerance);
            AssertEx.EqualTolerance(SquareDecimetersInOneSquareMeter, squaremeter.SquareDecimeters, SquareDecimetersTolerance);
            AssertEx.EqualTolerance(SquareFeetInOneSquareMeter, squaremeter.SquareFeet, SquareFeetTolerance);
            AssertEx.EqualTolerance(SquareInchesInOneSquareMeter, squaremeter.SquareInches, SquareInchesTolerance);
            AssertEx.EqualTolerance(SquareKilometersInOneSquareMeter, squaremeter.SquareKilometers, SquareKilometersTolerance);
            AssertEx.EqualTolerance(SquareMetersInOneSquareMeter, squaremeter.SquareMeters, SquareMetersTolerance);
            AssertEx.EqualTolerance(SquareMicrometersInOneSquareMeter, squaremeter.SquareMicrometers, SquareMicrometersTolerance);
            AssertEx.EqualTolerance(SquareMilesInOneSquareMeter, squaremeter.SquareMiles, SquareMilesTolerance);
            AssertEx.EqualTolerance(SquareMillimetersInOneSquareMeter, squaremeter.SquareMillimeters, SquareMillimetersTolerance);
            AssertEx.EqualTolerance(SquareYardsInOneSquareMeter, squaremeter.SquareYards, SquareYardsTolerance);
            AssertEx.EqualTolerance(UsSurveySquareFeetInOneSquareMeter, squaremeter.UsSurveySquareFeet, UsSurveySquareFeetTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.Acre).Acres, AcresTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.Hectare).Hectares, HectaresTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.SquareCentimeter).SquareCentimeters, SquareCentimetersTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.SquareDecimeter).SquareDecimeters, SquareDecimetersTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.SquareFoot).SquareFeet, SquareFeetTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.SquareInch).SquareInches, SquareInchesTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.SquareKilometer).SquareKilometers, SquareKilometersTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.SquareMeter).SquareMeters, SquareMetersTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.SquareMicrometer).SquareMicrometers, SquareMicrometersTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.SquareMile).SquareMiles, SquareMilesTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.SquareMillimeter).SquareMillimeters, SquareMillimetersTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.SquareYard).SquareYards, SquareYardsTolerance);
            AssertEx.EqualTolerance(1, Area.From(1, AreaUnit.UsSurveySquareFoot).UsSurveySquareFeet, UsSurveySquareFeetTolerance);
        }

        [Fact]
        public void FromSquareMeters_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Area.FromSquareMeters(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Area.FromSquareMeters(double.NegativeInfinity));
        }

        [Fact]
        public void FromSquareMeters_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Area.FromSquareMeters(double.NaN));
        }

        [Fact]
        public void As()
        {
            var squaremeter = Area.FromSquareMeters(1);
            AssertEx.EqualTolerance(AcresInOneSquareMeter, squaremeter.As(AreaUnit.Acre), AcresTolerance);
            AssertEx.EqualTolerance(HectaresInOneSquareMeter, squaremeter.As(AreaUnit.Hectare), HectaresTolerance);
            AssertEx.EqualTolerance(SquareCentimetersInOneSquareMeter, squaremeter.As(AreaUnit.SquareCentimeter), SquareCentimetersTolerance);
            AssertEx.EqualTolerance(SquareDecimetersInOneSquareMeter, squaremeter.As(AreaUnit.SquareDecimeter), SquareDecimetersTolerance);
            AssertEx.EqualTolerance(SquareFeetInOneSquareMeter, squaremeter.As(AreaUnit.SquareFoot), SquareFeetTolerance);
            AssertEx.EqualTolerance(SquareInchesInOneSquareMeter, squaremeter.As(AreaUnit.SquareInch), SquareInchesTolerance);
            AssertEx.EqualTolerance(SquareKilometersInOneSquareMeter, squaremeter.As(AreaUnit.SquareKilometer), SquareKilometersTolerance);
            AssertEx.EqualTolerance(SquareMetersInOneSquareMeter, squaremeter.As(AreaUnit.SquareMeter), SquareMetersTolerance);
            AssertEx.EqualTolerance(SquareMicrometersInOneSquareMeter, squaremeter.As(AreaUnit.SquareMicrometer), SquareMicrometersTolerance);
            AssertEx.EqualTolerance(SquareMilesInOneSquareMeter, squaremeter.As(AreaUnit.SquareMile), SquareMilesTolerance);
            AssertEx.EqualTolerance(SquareMillimetersInOneSquareMeter, squaremeter.As(AreaUnit.SquareMillimeter), SquareMillimetersTolerance);
            AssertEx.EqualTolerance(SquareYardsInOneSquareMeter, squaremeter.As(AreaUnit.SquareYard), SquareYardsTolerance);
            AssertEx.EqualTolerance(UsSurveySquareFeetInOneSquareMeter, squaremeter.As(AreaUnit.UsSurveySquareFoot), UsSurveySquareFeetTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var squaremeter = Area.FromSquareMeters(1);

            var acreQuantity = squaremeter.ToUnit(AreaUnit.Acre);
            AssertEx.EqualTolerance(AcresInOneSquareMeter, (double)acreQuantity.Value, AcresTolerance);
            Assert.Equal(AreaUnit.Acre, acreQuantity.Unit);

            var hectareQuantity = squaremeter.ToUnit(AreaUnit.Hectare);
            AssertEx.EqualTolerance(HectaresInOneSquareMeter, (double)hectareQuantity.Value, HectaresTolerance);
            Assert.Equal(AreaUnit.Hectare, hectareQuantity.Unit);

            var squarecentimeterQuantity = squaremeter.ToUnit(AreaUnit.SquareCentimeter);
            AssertEx.EqualTolerance(SquareCentimetersInOneSquareMeter, (double)squarecentimeterQuantity.Value, SquareCentimetersTolerance);
            Assert.Equal(AreaUnit.SquareCentimeter, squarecentimeterQuantity.Unit);

            var squaredecimeterQuantity = squaremeter.ToUnit(AreaUnit.SquareDecimeter);
            AssertEx.EqualTolerance(SquareDecimetersInOneSquareMeter, (double)squaredecimeterQuantity.Value, SquareDecimetersTolerance);
            Assert.Equal(AreaUnit.SquareDecimeter, squaredecimeterQuantity.Unit);

            var squarefootQuantity = squaremeter.ToUnit(AreaUnit.SquareFoot);
            AssertEx.EqualTolerance(SquareFeetInOneSquareMeter, (double)squarefootQuantity.Value, SquareFeetTolerance);
            Assert.Equal(AreaUnit.SquareFoot, squarefootQuantity.Unit);

            var squareinchQuantity = squaremeter.ToUnit(AreaUnit.SquareInch);
            AssertEx.EqualTolerance(SquareInchesInOneSquareMeter, (double)squareinchQuantity.Value, SquareInchesTolerance);
            Assert.Equal(AreaUnit.SquareInch, squareinchQuantity.Unit);

            var squarekilometerQuantity = squaremeter.ToUnit(AreaUnit.SquareKilometer);
            AssertEx.EqualTolerance(SquareKilometersInOneSquareMeter, (double)squarekilometerQuantity.Value, SquareKilometersTolerance);
            Assert.Equal(AreaUnit.SquareKilometer, squarekilometerQuantity.Unit);

            var squaremeterQuantity = squaremeter.ToUnit(AreaUnit.SquareMeter);
            AssertEx.EqualTolerance(SquareMetersInOneSquareMeter, (double)squaremeterQuantity.Value, SquareMetersTolerance);
            Assert.Equal(AreaUnit.SquareMeter, squaremeterQuantity.Unit);

            var squaremicrometerQuantity = squaremeter.ToUnit(AreaUnit.SquareMicrometer);
            AssertEx.EqualTolerance(SquareMicrometersInOneSquareMeter, (double)squaremicrometerQuantity.Value, SquareMicrometersTolerance);
            Assert.Equal(AreaUnit.SquareMicrometer, squaremicrometerQuantity.Unit);

            var squaremileQuantity = squaremeter.ToUnit(AreaUnit.SquareMile);
            AssertEx.EqualTolerance(SquareMilesInOneSquareMeter, (double)squaremileQuantity.Value, SquareMilesTolerance);
            Assert.Equal(AreaUnit.SquareMile, squaremileQuantity.Unit);

            var squaremillimeterQuantity = squaremeter.ToUnit(AreaUnit.SquareMillimeter);
            AssertEx.EqualTolerance(SquareMillimetersInOneSquareMeter, (double)squaremillimeterQuantity.Value, SquareMillimetersTolerance);
            Assert.Equal(AreaUnit.SquareMillimeter, squaremillimeterQuantity.Unit);

            var squareyardQuantity = squaremeter.ToUnit(AreaUnit.SquareYard);
            AssertEx.EqualTolerance(SquareYardsInOneSquareMeter, (double)squareyardQuantity.Value, SquareYardsTolerance);
            Assert.Equal(AreaUnit.SquareYard, squareyardQuantity.Unit);

            var ussurveysquarefootQuantity = squaremeter.ToUnit(AreaUnit.UsSurveySquareFoot);
            AssertEx.EqualTolerance(UsSurveySquareFeetInOneSquareMeter, (double)ussurveysquarefootQuantity.Value, UsSurveySquareFeetTolerance);
            Assert.Equal(AreaUnit.UsSurveySquareFoot, ussurveysquarefootQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Area squaremeter = Area.FromSquareMeters(1);
            AssertEx.EqualTolerance(1, Area.FromAcres(squaremeter.Acres).SquareMeters, AcresTolerance);
            AssertEx.EqualTolerance(1, Area.FromHectares(squaremeter.Hectares).SquareMeters, HectaresTolerance);
            AssertEx.EqualTolerance(1, Area.FromSquareCentimeters(squaremeter.SquareCentimeters).SquareMeters, SquareCentimetersTolerance);
            AssertEx.EqualTolerance(1, Area.FromSquareDecimeters(squaremeter.SquareDecimeters).SquareMeters, SquareDecimetersTolerance);
            AssertEx.EqualTolerance(1, Area.FromSquareFeet(squaremeter.SquareFeet).SquareMeters, SquareFeetTolerance);
            AssertEx.EqualTolerance(1, Area.FromSquareInches(squaremeter.SquareInches).SquareMeters, SquareInchesTolerance);
            AssertEx.EqualTolerance(1, Area.FromSquareKilometers(squaremeter.SquareKilometers).SquareMeters, SquareKilometersTolerance);
            AssertEx.EqualTolerance(1, Area.FromSquareMeters(squaremeter.SquareMeters).SquareMeters, SquareMetersTolerance);
            AssertEx.EqualTolerance(1, Area.FromSquareMicrometers(squaremeter.SquareMicrometers).SquareMeters, SquareMicrometersTolerance);
            AssertEx.EqualTolerance(1, Area.FromSquareMiles(squaremeter.SquareMiles).SquareMeters, SquareMilesTolerance);
            AssertEx.EqualTolerance(1, Area.FromSquareMillimeters(squaremeter.SquareMillimeters).SquareMeters, SquareMillimetersTolerance);
            AssertEx.EqualTolerance(1, Area.FromSquareYards(squaremeter.SquareYards).SquareMeters, SquareYardsTolerance);
            AssertEx.EqualTolerance(1, Area.FromUsSurveySquareFeet(squaremeter.UsSurveySquareFeet).SquareMeters, UsSurveySquareFeetTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Area v = Area.FromSquareMeters(1);
            AssertEx.EqualTolerance(-1, -v.SquareMeters, SquareMetersTolerance);
            AssertEx.EqualTolerance(2, (Area.FromSquareMeters(3)-v).SquareMeters, SquareMetersTolerance);
            AssertEx.EqualTolerance(2, (v + v).SquareMeters, SquareMetersTolerance);
            AssertEx.EqualTolerance(10, (v*10).SquareMeters, SquareMetersTolerance);
            AssertEx.EqualTolerance(10, (10*v).SquareMeters, SquareMetersTolerance);
            AssertEx.EqualTolerance(2, (Area.FromSquareMeters(10)/5).SquareMeters, SquareMetersTolerance);
            AssertEx.EqualTolerance(2, Area.FromSquareMeters(10)/Area.FromSquareMeters(5), SquareMetersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Area oneSquareMeter = Area.FromSquareMeters(1);
            Area twoSquareMeters = Area.FromSquareMeters(2);

            Assert.True(oneSquareMeter < twoSquareMeters);
            Assert.True(oneSquareMeter <= twoSquareMeters);
            Assert.True(twoSquareMeters > oneSquareMeter);
            Assert.True(twoSquareMeters >= oneSquareMeter);

            Assert.False(oneSquareMeter > twoSquareMeters);
            Assert.False(oneSquareMeter >= twoSquareMeters);
            Assert.False(twoSquareMeters < oneSquareMeter);
            Assert.False(twoSquareMeters <= oneSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Area squaremeter = Area.FromSquareMeters(1);
            Assert.Equal(0, squaremeter.CompareTo(squaremeter));
            Assert.True(squaremeter.CompareTo(Area.Zero) > 0);
            Assert.True(Area.Zero.CompareTo(squaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Area squaremeter = Area.FromSquareMeters(1);
            Assert.Throws<ArgumentException>(() => squaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Area squaremeter = Area.FromSquareMeters(1);
            Assert.Throws<ArgumentNullException>(() => squaremeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Area.FromSquareMeters(1);
            var b = Area.FromSquareMeters(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = Area.FromSquareMeters(1);
            var b = Area.FromSquareMeters(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = Area.FromSquareMeters(1);
            Assert.True(v.Equals(Area.FromSquareMeters(1), SquareMetersTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Area.Zero, SquareMetersTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Area squaremeter = Area.FromSquareMeters(1);
            Assert.False(squaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Area squaremeter = Area.FromSquareMeters(1);
            Assert.False(squaremeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(AreaUnit.Undefined, Area.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(AreaUnit)).Cast<AreaUnit>();
            foreach(var unit in units)
            {
                if(unit == AreaUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Area.BaseDimensions is null);
        }
    }
}