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
    /// Test of ElectricConductance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricConductanceTestsBase
    {
        protected abstract double MicrosiemensInOneSiemens { get; }
        protected abstract double MillisiemensInOneSiemens { get; }
        protected abstract double SiemensInOneSiemens { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double MicrosiemensTolerance { get { return 1e-5; } }
        protected virtual double MillisiemensTolerance { get { return 1e-5; } }
        protected virtual double SiemensTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricConductance((double)0.0, ElectricConductanceUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricConductance(double.PositiveInfinity, ElectricConductanceUnit.Siemens));
            Assert.Throws<ArgumentException>(() => new ElectricConductance(double.NegativeInfinity, ElectricConductanceUnit.Siemens));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricConductance(double.NaN, ElectricConductanceUnit.Siemens));
        }

        [Fact]
        public void SiemensToElectricConductanceUnits()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            AssertEx.EqualTolerance(MicrosiemensInOneSiemens, siemens.Microsiemens, MicrosiemensTolerance);
            AssertEx.EqualTolerance(MillisiemensInOneSiemens, siemens.Millisiemens, MillisiemensTolerance);
            AssertEx.EqualTolerance(SiemensInOneSiemens, siemens.Siemens, SiemensTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricConductance.From(1, ElectricConductanceUnit.Microsiemens).Microsiemens, MicrosiemensTolerance);
            AssertEx.EqualTolerance(1, ElectricConductance.From(1, ElectricConductanceUnit.Millisiemens).Millisiemens, MillisiemensTolerance);
            AssertEx.EqualTolerance(1, ElectricConductance.From(1, ElectricConductanceUnit.Siemens).Siemens, SiemensTolerance);
        }

        [Fact]
        public void FromSiemens_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricConductance.FromSiemens(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricConductance.FromSiemens(double.NegativeInfinity));
        }

        [Fact]
        public void FromSiemens_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricConductance.FromSiemens(double.NaN));
        }

        [Fact]
        public void As()
        {
            var siemens = ElectricConductance.FromSiemens(1);
            AssertEx.EqualTolerance(MicrosiemensInOneSiemens, siemens.As(ElectricConductanceUnit.Microsiemens), MicrosiemensTolerance);
            AssertEx.EqualTolerance(MillisiemensInOneSiemens, siemens.As(ElectricConductanceUnit.Millisiemens), MillisiemensTolerance);
            AssertEx.EqualTolerance(SiemensInOneSiemens, siemens.As(ElectricConductanceUnit.Siemens), SiemensTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var siemens = ElectricConductance.FromSiemens(1);

            var microsiemensQuantity = siemens.ToUnit(ElectricConductanceUnit.Microsiemens);
            AssertEx.EqualTolerance(MicrosiemensInOneSiemens, (double)microsiemensQuantity.Value, MicrosiemensTolerance);
            Assert.Equal(ElectricConductanceUnit.Microsiemens, microsiemensQuantity.Unit);

            var millisiemensQuantity = siemens.ToUnit(ElectricConductanceUnit.Millisiemens);
            AssertEx.EqualTolerance(MillisiemensInOneSiemens, (double)millisiemensQuantity.Value, MillisiemensTolerance);
            Assert.Equal(ElectricConductanceUnit.Millisiemens, millisiemensQuantity.Unit);

            var siemensQuantity = siemens.ToUnit(ElectricConductanceUnit.Siemens);
            AssertEx.EqualTolerance(SiemensInOneSiemens, (double)siemensQuantity.Value, SiemensTolerance);
            Assert.Equal(ElectricConductanceUnit.Siemens, siemensQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            AssertEx.EqualTolerance(1, ElectricConductance.FromMicrosiemens(siemens.Microsiemens).Siemens, MicrosiemensTolerance);
            AssertEx.EqualTolerance(1, ElectricConductance.FromMillisiemens(siemens.Millisiemens).Siemens, MillisiemensTolerance);
            AssertEx.EqualTolerance(1, ElectricConductance.FromSiemens(siemens.Siemens).Siemens, SiemensTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricConductance v = ElectricConductance.FromSiemens(1);
            AssertEx.EqualTolerance(-1, -v.Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(2, (ElectricConductance.FromSiemens(3)-v).Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(2, (v + v).Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(10, (v*10).Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(10, (10*v).Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(2, (ElectricConductance.FromSiemens(10)/5).Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(2, ElectricConductance.FromSiemens(10)/ElectricConductance.FromSiemens(5), SiemensTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricConductance oneSiemens = ElectricConductance.FromSiemens(1);
            ElectricConductance twoSiemens = ElectricConductance.FromSiemens(2);

            Assert.True(oneSiemens < twoSiemens);
            Assert.True(oneSiemens <= twoSiemens);
            Assert.True(twoSiemens > oneSiemens);
            Assert.True(twoSiemens >= oneSiemens);

            Assert.False(oneSiemens > twoSiemens);
            Assert.False(oneSiemens >= twoSiemens);
            Assert.False(twoSiemens < oneSiemens);
            Assert.False(twoSiemens <= oneSiemens);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            Assert.Equal(0, siemens.CompareTo(siemens));
            Assert.True(siemens.CompareTo(ElectricConductance.Zero) > 0);
            Assert.True(ElectricConductance.Zero.CompareTo(siemens) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            Assert.Throws<ArgumentException>(() => siemens.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            Assert.Throws<ArgumentNullException>(() => siemens.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricConductance.FromSiemens(1);
            var b = ElectricConductance.FromSiemens(2);

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
            var a = ElectricConductance.FromSiemens(1);
            var b = ElectricConductance.FromSiemens(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = ElectricConductance.FromSiemens(1);
            Assert.True(v.Equals(ElectricConductance.FromSiemens(1), SiemensTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricConductance.Zero, SiemensTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            Assert.False(siemens.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            Assert.False(siemens.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricConductanceUnit.Undefined, ElectricConductance.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricConductanceUnit)).Cast<ElectricConductanceUnit>();
            foreach(var unit in units)
            {
                if(unit == ElectricConductanceUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricConductance.BaseDimensions is null);
        }
    }
}
