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
    /// Test of LuminousIntensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LuminousIntensityTestsBase
    {
        protected abstract double CandelaInOneCandela { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CandelaTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LuminousIntensity((double)0.0, LuminousIntensityUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LuminousIntensity(double.PositiveInfinity, LuminousIntensityUnit.Candela));
            Assert.Throws<ArgumentException>(() => new LuminousIntensity(double.NegativeInfinity, LuminousIntensityUnit.Candela));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LuminousIntensity(double.NaN, LuminousIntensityUnit.Candela));
        }

        [Fact]
        public void CandelaToLuminousIntensityUnits()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(CandelaInOneCandela, candela.Candela, CandelaTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, LuminousIntensity.From(1, LuminousIntensityUnit.Candela).Candela, CandelaTolerance);
        }

        [Fact]
        public void FromCandela_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LuminousIntensity.FromCandela(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => LuminousIntensity.FromCandela(double.NegativeInfinity));
        }

        [Fact]
        public void FromCandela_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LuminousIntensity.FromCandela(double.NaN));
        }

        [Fact]
        public void As()
        {
            var candela = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(CandelaInOneCandela, candela.As(LuminousIntensityUnit.Candela), CandelaTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var candela = LuminousIntensity.FromCandela(1);

            var candelaQuantity = candela.ToUnit(LuminousIntensityUnit.Candela);
            AssertEx.EqualTolerance(CandelaInOneCandela, (double)candelaQuantity.Value, CandelaTolerance);
            Assert.Equal(LuminousIntensityUnit.Candela, candelaQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(1, LuminousIntensity.FromCandela(candela.Candela).Candela, CandelaTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            LuminousIntensity v = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(-1, -v.Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, (LuminousIntensity.FromCandela(3)-v).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, (v + v).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(10, (v*10).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(10, (10*v).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, (LuminousIntensity.FromCandela(10)/5).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, LuminousIntensity.FromCandela(10)/LuminousIntensity.FromCandela(5), CandelaTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            LuminousIntensity oneCandela = LuminousIntensity.FromCandela(1);
            LuminousIntensity twoCandela = LuminousIntensity.FromCandela(2);

            Assert.True(oneCandela < twoCandela);
            Assert.True(oneCandela <= twoCandela);
            Assert.True(twoCandela > oneCandela);
            Assert.True(twoCandela >= oneCandela);

            Assert.False(oneCandela > twoCandela);
            Assert.False(oneCandela >= twoCandela);
            Assert.False(twoCandela < oneCandela);
            Assert.False(twoCandela <= oneCandela);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.Equal(0, candela.CompareTo(candela));
            Assert.True(candela.CompareTo(LuminousIntensity.Zero) > 0);
            Assert.True(LuminousIntensity.Zero.CompareTo(candela) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.Throws<ArgumentException>(() => candela.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.Throws<ArgumentNullException>(() => candela.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = LuminousIntensity.FromCandela(1);
            var b = LuminousIntensity.FromCandela(2);

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
            var a = LuminousIntensity.FromCandela(1);
            var b = LuminousIntensity.FromCandela(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = LuminousIntensity.FromCandela(1);
            Assert.True(v.Equals(LuminousIntensity.FromCandela(1), CandelaTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(LuminousIntensity.Zero, CandelaTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.False(candela.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.False(candela.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(LuminousIntensityUnit.Undefined, LuminousIntensity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(LuminousIntensityUnit)).Cast<LuminousIntensityUnit>();
            foreach(var unit in units)
            {
                if(unit == LuminousIntensityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(LuminousIntensity.BaseDimensions is null);
        }
    }
}
