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
    /// Test of AmplitudeRatio.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AmplitudeRatioTestsBase
    {
        protected abstract double DecibelMicrovoltsInOneDecibelVolt { get; }
        protected abstract double DecibelMillivoltsInOneDecibelVolt { get; }
        protected abstract double DecibelsUnloadedInOneDecibelVolt { get; }
        protected abstract double DecibelVoltsInOneDecibelVolt { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecibelMicrovoltsTolerance { get { return 1e-5; } }
        protected virtual double DecibelMillivoltsTolerance { get { return 1e-5; } }
        protected virtual double DecibelsUnloadedTolerance { get { return 1e-5; } }
        protected virtual double DecibelVoltsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AmplitudeRatio((double)0.0, AmplitudeRatioUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AmplitudeRatio(double.PositiveInfinity, AmplitudeRatioUnit.DecibelVolt));
            Assert.Throws<ArgumentException>(() => new AmplitudeRatio(double.NegativeInfinity, AmplitudeRatioUnit.DecibelVolt));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AmplitudeRatio(double.NaN, AmplitudeRatioUnit.DecibelVolt));
        }

        [Fact]
        public void DecibelVoltToAmplitudeRatioUnits()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            AssertEx.EqualTolerance(DecibelMicrovoltsInOneDecibelVolt, decibelvolt.DecibelMicrovolts, DecibelMicrovoltsTolerance);
            AssertEx.EqualTolerance(DecibelMillivoltsInOneDecibelVolt, decibelvolt.DecibelMillivolts, DecibelMillivoltsTolerance);
            AssertEx.EqualTolerance(DecibelsUnloadedInOneDecibelVolt, decibelvolt.DecibelsUnloaded, DecibelsUnloadedTolerance);
            AssertEx.EqualTolerance(DecibelVoltsInOneDecibelVolt, decibelvolt.DecibelVolts, DecibelVoltsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, AmplitudeRatio.From(1, AmplitudeRatioUnit.DecibelMicrovolt).DecibelMicrovolts, DecibelMicrovoltsTolerance);
            AssertEx.EqualTolerance(1, AmplitudeRatio.From(1, AmplitudeRatioUnit.DecibelMillivolt).DecibelMillivolts, DecibelMillivoltsTolerance);
            AssertEx.EqualTolerance(1, AmplitudeRatio.From(1, AmplitudeRatioUnit.DecibelUnloaded).DecibelsUnloaded, DecibelsUnloadedTolerance);
            AssertEx.EqualTolerance(1, AmplitudeRatio.From(1, AmplitudeRatioUnit.DecibelVolt).DecibelVolts, DecibelVoltsTolerance);
        }

        [Fact]
        public void FromDecibelVolts_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AmplitudeRatio.FromDecibelVolts(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => AmplitudeRatio.FromDecibelVolts(double.NegativeInfinity));
        }

        [Fact]
        public void FromDecibelVolts_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AmplitudeRatio.FromDecibelVolts(double.NaN));
        }

        [Fact]
        public void As()
        {
            var decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            AssertEx.EqualTolerance(DecibelMicrovoltsInOneDecibelVolt, decibelvolt.As(AmplitudeRatioUnit.DecibelMicrovolt), DecibelMicrovoltsTolerance);
            AssertEx.EqualTolerance(DecibelMillivoltsInOneDecibelVolt, decibelvolt.As(AmplitudeRatioUnit.DecibelMillivolt), DecibelMillivoltsTolerance);
            AssertEx.EqualTolerance(DecibelsUnloadedInOneDecibelVolt, decibelvolt.As(AmplitudeRatioUnit.DecibelUnloaded), DecibelsUnloadedTolerance);
            AssertEx.EqualTolerance(DecibelVoltsInOneDecibelVolt, decibelvolt.As(AmplitudeRatioUnit.DecibelVolt), DecibelVoltsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var decibelvolt = AmplitudeRatio.FromDecibelVolts(1);

            var decibelmicrovoltQuantity = decibelvolt.ToUnit(AmplitudeRatioUnit.DecibelMicrovolt);
            AssertEx.EqualTolerance(DecibelMicrovoltsInOneDecibelVolt, (double)decibelmicrovoltQuantity.Value, DecibelMicrovoltsTolerance);
            Assert.Equal(AmplitudeRatioUnit.DecibelMicrovolt, decibelmicrovoltQuantity.Unit);

            var decibelmillivoltQuantity = decibelvolt.ToUnit(AmplitudeRatioUnit.DecibelMillivolt);
            AssertEx.EqualTolerance(DecibelMillivoltsInOneDecibelVolt, (double)decibelmillivoltQuantity.Value, DecibelMillivoltsTolerance);
            Assert.Equal(AmplitudeRatioUnit.DecibelMillivolt, decibelmillivoltQuantity.Unit);

            var decibelunloadedQuantity = decibelvolt.ToUnit(AmplitudeRatioUnit.DecibelUnloaded);
            AssertEx.EqualTolerance(DecibelsUnloadedInOneDecibelVolt, (double)decibelunloadedQuantity.Value, DecibelsUnloadedTolerance);
            Assert.Equal(AmplitudeRatioUnit.DecibelUnloaded, decibelunloadedQuantity.Unit);

            var decibelvoltQuantity = decibelvolt.ToUnit(AmplitudeRatioUnit.DecibelVolt);
            AssertEx.EqualTolerance(DecibelVoltsInOneDecibelVolt, (double)decibelvoltQuantity.Value, DecibelVoltsTolerance);
            Assert.Equal(AmplitudeRatioUnit.DecibelVolt, decibelvoltQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            AssertEx.EqualTolerance(1, AmplitudeRatio.FromDecibelMicrovolts(decibelvolt.DecibelMicrovolts).DecibelVolts, DecibelMicrovoltsTolerance);
            AssertEx.EqualTolerance(1, AmplitudeRatio.FromDecibelMillivolts(decibelvolt.DecibelMillivolts).DecibelVolts, DecibelMillivoltsTolerance);
            AssertEx.EqualTolerance(1, AmplitudeRatio.FromDecibelsUnloaded(decibelvolt.DecibelsUnloaded).DecibelVolts, DecibelsUnloadedTolerance);
            AssertEx.EqualTolerance(1, AmplitudeRatio.FromDecibelVolts(decibelvolt.DecibelVolts).DecibelVolts, DecibelVoltsTolerance);
        }

        [Fact]
        public void LogarithmicArithmeticOperators()
        {
            AmplitudeRatio v = AmplitudeRatio.FromDecibelVolts(40);
            AssertEx.EqualTolerance(-40, -v.DecibelVolts, DecibelVoltsTolerance);
            AssertLogarithmicAddition();
            AssertLogarithmicSubtraction();
            AssertEx.EqualTolerance(50, (v*10).DecibelVolts, DecibelVoltsTolerance);
            AssertEx.EqualTolerance(50, (10*v).DecibelVolts, DecibelVoltsTolerance);
            AssertEx.EqualTolerance(35, (v/5).DecibelVolts, DecibelVoltsTolerance);
            AssertEx.EqualTolerance(35, v/AmplitudeRatio.FromDecibelVolts(5), DecibelVoltsTolerance);
        }

        protected abstract void AssertLogarithmicAddition();

        protected abstract void AssertLogarithmicSubtraction();

        [Fact]
        public void ComparisonOperators()
        {
            AmplitudeRatio oneDecibelVolt = AmplitudeRatio.FromDecibelVolts(1);
            AmplitudeRatio twoDecibelVolts = AmplitudeRatio.FromDecibelVolts(2);

            Assert.True(oneDecibelVolt < twoDecibelVolts);
            Assert.True(oneDecibelVolt <= twoDecibelVolts);
            Assert.True(twoDecibelVolts > oneDecibelVolt);
            Assert.True(twoDecibelVolts >= oneDecibelVolt);

            Assert.False(oneDecibelVolt > twoDecibelVolts);
            Assert.False(oneDecibelVolt >= twoDecibelVolts);
            Assert.False(twoDecibelVolts < oneDecibelVolt);
            Assert.False(twoDecibelVolts <= oneDecibelVolt);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            Assert.Equal(0, decibelvolt.CompareTo(decibelvolt));
            Assert.True(decibelvolt.CompareTo(AmplitudeRatio.Zero) > 0);
            Assert.True(AmplitudeRatio.Zero.CompareTo(decibelvolt) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            Assert.Throws<ArgumentException>(() => decibelvolt.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            Assert.Throws<ArgumentNullException>(() => decibelvolt.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = AmplitudeRatio.FromDecibelVolts(1);
            var b = AmplitudeRatio.FromDecibelVolts(2);

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
            var a = AmplitudeRatio.FromDecibelVolts(1);
            var b = AmplitudeRatio.FromDecibelVolts(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = AmplitudeRatio.FromDecibelVolts(1);
            Assert.True(v.Equals(AmplitudeRatio.FromDecibelVolts(1), DecibelVoltsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(AmplitudeRatio.Zero, DecibelVoltsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            Assert.False(decibelvolt.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            Assert.False(decibelvolt.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(AmplitudeRatioUnit.Undefined, AmplitudeRatio.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(AmplitudeRatioUnit)).Cast<AmplitudeRatioUnit>();
            foreach(var unit in units)
            {
                if(unit == AmplitudeRatioUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(AmplitudeRatio.BaseDimensions is null);
        }
    }
}