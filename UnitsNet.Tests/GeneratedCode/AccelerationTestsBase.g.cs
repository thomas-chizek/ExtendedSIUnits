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
    /// Test of Acceleration.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AccelerationTestsBase
    {
        protected abstract double CentimetersPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double DecametersPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double DecimetersPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double FeetPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double InchesPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double KilometersPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double KnotsPerHourInOneMeterPerSecondSquared { get; }
        protected abstract double KnotsPerMinuteInOneMeterPerSecondSquared { get; }
        protected abstract double KnotsPerSecondInOneMeterPerSecondSquared { get; }
        protected abstract double MetersPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double MicrometersPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double MillimetersPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double NanometersPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double StandardGravityInOneMeterPerSecondSquared { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentimetersPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double DecametersPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double DecimetersPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double FeetPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double InchesPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double KilometersPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double KnotsPerHourTolerance { get { return 1e-5; } }
        protected virtual double KnotsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double KnotsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MetersPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double MicrometersPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double MillimetersPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double NanometersPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double StandardGravityTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Acceleration((double)0.0, AccelerationUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Acceleration(double.PositiveInfinity, AccelerationUnit.MeterPerSecondSquared));
            Assert.Throws<ArgumentException>(() => new Acceleration(double.NegativeInfinity, AccelerationUnit.MeterPerSecondSquared));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Acceleration(double.NaN, AccelerationUnit.MeterPerSecondSquared));
        }

        [Fact]
        public void MeterPerSecondSquaredToAccelerationUnits()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMetersPerSecondSquared(1);
            AssertEx.EqualTolerance(CentimetersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.CentimetersPerSecondSquared, CentimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(DecametersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.DecametersPerSecondSquared, DecametersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(DecimetersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.DecimetersPerSecondSquared, DecimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(FeetPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.FeetPerSecondSquared, FeetPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(InchesPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.InchesPerSecondSquared, InchesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(KilometersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.KilometersPerSecondSquared, KilometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(KnotsPerHourInOneMeterPerSecondSquared, meterpersecondsquared.KnotsPerHour, KnotsPerHourTolerance);
            AssertEx.EqualTolerance(KnotsPerMinuteInOneMeterPerSecondSquared, meterpersecondsquared.KnotsPerMinute, KnotsPerMinuteTolerance);
            AssertEx.EqualTolerance(KnotsPerSecondInOneMeterPerSecondSquared, meterpersecondsquared.KnotsPerSecond, KnotsPerSecondTolerance);
            AssertEx.EqualTolerance(MetersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.MetersPerSecondSquared, MetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(MicrometersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.MicrometersPerSecondSquared, MicrometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(MillimetersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.MillimetersPerSecondSquared, MillimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(NanometersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.NanometersPerSecondSquared, NanometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(StandardGravityInOneMeterPerSecondSquared, meterpersecondsquared.StandardGravity, StandardGravityTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.CentimeterPerSecondSquared).CentimetersPerSecondSquared, CentimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.DecameterPerSecondSquared).DecametersPerSecondSquared, DecametersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.DecimeterPerSecondSquared).DecimetersPerSecondSquared, DecimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.FootPerSecondSquared).FeetPerSecondSquared, FeetPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.InchPerSecondSquared).InchesPerSecondSquared, InchesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.KilometerPerSecondSquared).KilometersPerSecondSquared, KilometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.KnotPerHour).KnotsPerHour, KnotsPerHourTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.KnotPerMinute).KnotsPerMinute, KnotsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.KnotPerSecond).KnotsPerSecond, KnotsPerSecondTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.MeterPerSecondSquared).MetersPerSecondSquared, MetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.MicrometerPerSecondSquared).MicrometersPerSecondSquared, MicrometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.MillimeterPerSecondSquared).MillimetersPerSecondSquared, MillimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.NanometerPerSecondSquared).NanometersPerSecondSquared, NanometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.StandardGravity).StandardGravity, StandardGravityTolerance);
        }

        [Fact]
        public void FromMetersPerSecondSquared_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Acceleration.FromMetersPerSecondSquared(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Acceleration.FromMetersPerSecondSquared(double.NegativeInfinity));
        }

        [Fact]
        public void FromMetersPerSecondSquared_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Acceleration.FromMetersPerSecondSquared(double.NaN));
        }

        [Fact]
        public void As()
        {
            var meterpersecondsquared = Acceleration.FromMetersPerSecondSquared(1);
            AssertEx.EqualTolerance(CentimetersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.CentimeterPerSecondSquared), CentimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(DecametersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.DecameterPerSecondSquared), DecametersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(DecimetersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.DecimeterPerSecondSquared), DecimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(FeetPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.FootPerSecondSquared), FeetPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(InchesPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.InchPerSecondSquared), InchesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(KilometersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.KilometerPerSecondSquared), KilometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(KnotsPerHourInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.KnotPerHour), KnotsPerHourTolerance);
            AssertEx.EqualTolerance(KnotsPerMinuteInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.KnotPerMinute), KnotsPerMinuteTolerance);
            AssertEx.EqualTolerance(KnotsPerSecondInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.KnotPerSecond), KnotsPerSecondTolerance);
            AssertEx.EqualTolerance(MetersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.MeterPerSecondSquared), MetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(MicrometersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.MicrometerPerSecondSquared), MicrometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(MillimetersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.MillimeterPerSecondSquared), MillimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(NanometersPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.NanometerPerSecondSquared), NanometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(StandardGravityInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.StandardGravity), StandardGravityTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var meterpersecondsquared = Acceleration.FromMetersPerSecondSquared(1);

            var centimeterpersecondsquaredQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.CentimeterPerSecondSquared);
            AssertEx.EqualTolerance(CentimetersPerSecondSquaredInOneMeterPerSecondSquared, (double)centimeterpersecondsquaredQuantity.Value, CentimetersPerSecondSquaredTolerance);
            Assert.Equal(AccelerationUnit.CentimeterPerSecondSquared, centimeterpersecondsquaredQuantity.Unit);

            var decameterpersecondsquaredQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.DecameterPerSecondSquared);
            AssertEx.EqualTolerance(DecametersPerSecondSquaredInOneMeterPerSecondSquared, (double)decameterpersecondsquaredQuantity.Value, DecametersPerSecondSquaredTolerance);
            Assert.Equal(AccelerationUnit.DecameterPerSecondSquared, decameterpersecondsquaredQuantity.Unit);

            var decimeterpersecondsquaredQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.DecimeterPerSecondSquared);
            AssertEx.EqualTolerance(DecimetersPerSecondSquaredInOneMeterPerSecondSquared, (double)decimeterpersecondsquaredQuantity.Value, DecimetersPerSecondSquaredTolerance);
            Assert.Equal(AccelerationUnit.DecimeterPerSecondSquared, decimeterpersecondsquaredQuantity.Unit);

            var footpersecondsquaredQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.FootPerSecondSquared);
            AssertEx.EqualTolerance(FeetPerSecondSquaredInOneMeterPerSecondSquared, (double)footpersecondsquaredQuantity.Value, FeetPerSecondSquaredTolerance);
            Assert.Equal(AccelerationUnit.FootPerSecondSquared, footpersecondsquaredQuantity.Unit);

            var inchpersecondsquaredQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.InchPerSecondSquared);
            AssertEx.EqualTolerance(InchesPerSecondSquaredInOneMeterPerSecondSquared, (double)inchpersecondsquaredQuantity.Value, InchesPerSecondSquaredTolerance);
            Assert.Equal(AccelerationUnit.InchPerSecondSquared, inchpersecondsquaredQuantity.Unit);

            var kilometerpersecondsquaredQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.KilometerPerSecondSquared);
            AssertEx.EqualTolerance(KilometersPerSecondSquaredInOneMeterPerSecondSquared, (double)kilometerpersecondsquaredQuantity.Value, KilometersPerSecondSquaredTolerance);
            Assert.Equal(AccelerationUnit.KilometerPerSecondSquared, kilometerpersecondsquaredQuantity.Unit);

            var knotperhourQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.KnotPerHour);
            AssertEx.EqualTolerance(KnotsPerHourInOneMeterPerSecondSquared, (double)knotperhourQuantity.Value, KnotsPerHourTolerance);
            Assert.Equal(AccelerationUnit.KnotPerHour, knotperhourQuantity.Unit);

            var knotperminuteQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.KnotPerMinute);
            AssertEx.EqualTolerance(KnotsPerMinuteInOneMeterPerSecondSquared, (double)knotperminuteQuantity.Value, KnotsPerMinuteTolerance);
            Assert.Equal(AccelerationUnit.KnotPerMinute, knotperminuteQuantity.Unit);

            var knotpersecondQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.KnotPerSecond);
            AssertEx.EqualTolerance(KnotsPerSecondInOneMeterPerSecondSquared, (double)knotpersecondQuantity.Value, KnotsPerSecondTolerance);
            Assert.Equal(AccelerationUnit.KnotPerSecond, knotpersecondQuantity.Unit);

            var meterpersecondsquaredQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.MeterPerSecondSquared);
            AssertEx.EqualTolerance(MetersPerSecondSquaredInOneMeterPerSecondSquared, (double)meterpersecondsquaredQuantity.Value, MetersPerSecondSquaredTolerance);
            Assert.Equal(AccelerationUnit.MeterPerSecondSquared, meterpersecondsquaredQuantity.Unit);

            var micrometerpersecondsquaredQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.MicrometerPerSecondSquared);
            AssertEx.EqualTolerance(MicrometersPerSecondSquaredInOneMeterPerSecondSquared, (double)micrometerpersecondsquaredQuantity.Value, MicrometersPerSecondSquaredTolerance);
            Assert.Equal(AccelerationUnit.MicrometerPerSecondSquared, micrometerpersecondsquaredQuantity.Unit);

            var millimeterpersecondsquaredQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.MillimeterPerSecondSquared);
            AssertEx.EqualTolerance(MillimetersPerSecondSquaredInOneMeterPerSecondSquared, (double)millimeterpersecondsquaredQuantity.Value, MillimetersPerSecondSquaredTolerance);
            Assert.Equal(AccelerationUnit.MillimeterPerSecondSquared, millimeterpersecondsquaredQuantity.Unit);

            var nanometerpersecondsquaredQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.NanometerPerSecondSquared);
            AssertEx.EqualTolerance(NanometersPerSecondSquaredInOneMeterPerSecondSquared, (double)nanometerpersecondsquaredQuantity.Value, NanometersPerSecondSquaredTolerance);
            Assert.Equal(AccelerationUnit.NanometerPerSecondSquared, nanometerpersecondsquaredQuantity.Unit);

            var standardgravityQuantity = meterpersecondsquared.ToUnit(AccelerationUnit.StandardGravity);
            AssertEx.EqualTolerance(StandardGravityInOneMeterPerSecondSquared, (double)standardgravityQuantity.Value, StandardGravityTolerance);
            Assert.Equal(AccelerationUnit.StandardGravity, standardgravityQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMetersPerSecondSquared(1);
            AssertEx.EqualTolerance(1, Acceleration.FromCentimetersPerSecondSquared(meterpersecondsquared.CentimetersPerSecondSquared).MetersPerSecondSquared, CentimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromDecametersPerSecondSquared(meterpersecondsquared.DecametersPerSecondSquared).MetersPerSecondSquared, DecametersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromDecimetersPerSecondSquared(meterpersecondsquared.DecimetersPerSecondSquared).MetersPerSecondSquared, DecimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromFeetPerSecondSquared(meterpersecondsquared.FeetPerSecondSquared).MetersPerSecondSquared, FeetPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromInchesPerSecondSquared(meterpersecondsquared.InchesPerSecondSquared).MetersPerSecondSquared, InchesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromKilometersPerSecondSquared(meterpersecondsquared.KilometersPerSecondSquared).MetersPerSecondSquared, KilometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromKnotsPerHour(meterpersecondsquared.KnotsPerHour).MetersPerSecondSquared, KnotsPerHourTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromKnotsPerMinute(meterpersecondsquared.KnotsPerMinute).MetersPerSecondSquared, KnotsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromKnotsPerSecond(meterpersecondsquared.KnotsPerSecond).MetersPerSecondSquared, KnotsPerSecondTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromMetersPerSecondSquared(meterpersecondsquared.MetersPerSecondSquared).MetersPerSecondSquared, MetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromMicrometersPerSecondSquared(meterpersecondsquared.MicrometersPerSecondSquared).MetersPerSecondSquared, MicrometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromMillimetersPerSecondSquared(meterpersecondsquared.MillimetersPerSecondSquared).MetersPerSecondSquared, MillimetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromNanometersPerSecondSquared(meterpersecondsquared.NanometersPerSecondSquared).MetersPerSecondSquared, NanometersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromStandardGravity(meterpersecondsquared.StandardGravity).MetersPerSecondSquared, StandardGravityTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Acceleration v = Acceleration.FromMetersPerSecondSquared(1);
            AssertEx.EqualTolerance(-1, -v.MetersPerSecondSquared, MetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (Acceleration.FromMetersPerSecondSquared(3)-v).MetersPerSecondSquared, MetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (v + v).MetersPerSecondSquared, MetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(10, (v*10).MetersPerSecondSquared, MetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(10, (10*v).MetersPerSecondSquared, MetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (Acceleration.FromMetersPerSecondSquared(10)/5).MetersPerSecondSquared, MetersPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, Acceleration.FromMetersPerSecondSquared(10)/Acceleration.FromMetersPerSecondSquared(5), MetersPerSecondSquaredTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Acceleration oneMeterPerSecondSquared = Acceleration.FromMetersPerSecondSquared(1);
            Acceleration twoMetersPerSecondSquared = Acceleration.FromMetersPerSecondSquared(2);

            Assert.True(oneMeterPerSecondSquared < twoMetersPerSecondSquared);
            Assert.True(oneMeterPerSecondSquared <= twoMetersPerSecondSquared);
            Assert.True(twoMetersPerSecondSquared > oneMeterPerSecondSquared);
            Assert.True(twoMetersPerSecondSquared >= oneMeterPerSecondSquared);

            Assert.False(oneMeterPerSecondSquared > twoMetersPerSecondSquared);
            Assert.False(oneMeterPerSecondSquared >= twoMetersPerSecondSquared);
            Assert.False(twoMetersPerSecondSquared < oneMeterPerSecondSquared);
            Assert.False(twoMetersPerSecondSquared <= oneMeterPerSecondSquared);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMetersPerSecondSquared(1);
            Assert.Equal(0, meterpersecondsquared.CompareTo(meterpersecondsquared));
            Assert.True(meterpersecondsquared.CompareTo(Acceleration.Zero) > 0);
            Assert.True(Acceleration.Zero.CompareTo(meterpersecondsquared) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMetersPerSecondSquared(1);
            Assert.Throws<ArgumentException>(() => meterpersecondsquared.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMetersPerSecondSquared(1);
            Assert.Throws<ArgumentNullException>(() => meterpersecondsquared.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Acceleration.FromMetersPerSecondSquared(1);
            var b = Acceleration.FromMetersPerSecondSquared(2);

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
            var a = Acceleration.FromMetersPerSecondSquared(1);
            var b = Acceleration.FromMetersPerSecondSquared(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = Acceleration.FromMetersPerSecondSquared(1);
            Assert.True(v.Equals(Acceleration.FromMetersPerSecondSquared(1), MetersPerSecondSquaredTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Acceleration.Zero, MetersPerSecondSquaredTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMetersPerSecondSquared(1);
            Assert.False(meterpersecondsquared.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMetersPerSecondSquared(1);
            Assert.False(meterpersecondsquared.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(AccelerationUnit.Undefined, Acceleration.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(AccelerationUnit)).Cast<AccelerationUnit>();
            foreach(var unit in units)
            {
                if(unit == AccelerationUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Acceleration.BaseDimensions is null);
        }
    }
}
