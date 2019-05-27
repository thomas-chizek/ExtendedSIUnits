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
    /// Test of ReactivePower.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ReactivePowerTestsBase
    {
        protected abstract double AttovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double CentivoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double DecavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double DecivoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double ExavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double FemtovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double GigavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double HectovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double KilovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double MegavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double MicrovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double MillivoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double NanovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double PetavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double PicovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double QutravoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double TeravoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double VettavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double VoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double YoctovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double YottavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double ZeptovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double ZettavoltamperesReactiveInOneVoltampereReactive { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AttovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double CentivoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double DecavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double DecivoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double ExavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double FemtovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double GigavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double HectovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double KilovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double MegavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double MicrovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double MillivoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double NanovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double PetavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double PicovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double QutravoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double TeravoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double VettavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double VoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double YoctovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double YottavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double ZeptovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double ZettavoltamperesReactiveTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactivePower((double)0.0, ReactivePowerUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactivePower(double.PositiveInfinity, ReactivePowerUnit.VoltampereReactive));
            Assert.Throws<ArgumentException>(() => new ReactivePower(double.NegativeInfinity, ReactivePowerUnit.VoltampereReactive));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactivePower(double.NaN, ReactivePowerUnit.VoltampereReactive));
        }

        [Fact]
        public void VoltampereReactiveToReactivePowerUnits()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(AttovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.AttovoltamperesReactive, AttovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(CentivoltamperesReactiveInOneVoltampereReactive, voltamperereactive.CentivoltamperesReactive, CentivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(DecavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.DecavoltamperesReactive, DecavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(DecivoltamperesReactiveInOneVoltampereReactive, voltamperereactive.DecivoltamperesReactive, DecivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(ExavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.ExavoltamperesReactive, ExavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(FemtovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.FemtovoltamperesReactive, FemtovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(GigavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.GigavoltamperesReactive, GigavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(HectovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.HectovoltamperesReactive, HectovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(KilovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.KilovoltamperesReactive, KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MegavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.MegavoltamperesReactive, MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MicrovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.MicrovoltamperesReactive, MicrovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MillivoltamperesReactiveInOneVoltampereReactive, voltamperereactive.MillivoltamperesReactive, MillivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(NanovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.NanovoltamperesReactive, NanovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(PetavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.PetavoltamperesReactive, PetavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(PicovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.PicovoltamperesReactive, PicovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(QutravoltamperesReactiveInOneVoltampereReactive, voltamperereactive.QutravoltamperesReactive, QutravoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(TeravoltamperesReactiveInOneVoltampereReactive, voltamperereactive.TeravoltamperesReactive, TeravoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(VettavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.VettavoltamperesReactive, VettavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(VoltamperesReactiveInOneVoltampereReactive, voltamperereactive.VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(YoctovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.YoctovoltamperesReactive, YoctovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(YottavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.YottavoltamperesReactive, YottavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(ZeptovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.ZeptovoltamperesReactive, ZeptovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(ZettavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.ZettavoltamperesReactive, ZettavoltamperesReactiveTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.AttovoltampereReactive).AttovoltamperesReactive, AttovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.CentivoltampereReactive).CentivoltamperesReactive, CentivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.DecavoltampereReactive).DecavoltamperesReactive, DecavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.DecivoltampereReactive).DecivoltamperesReactive, DecivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.ExavoltampereReactive).ExavoltamperesReactive, ExavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.FemtovoltampereReactive).FemtovoltamperesReactive, FemtovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.GigavoltampereReactive).GigavoltamperesReactive, GigavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.HectovoltampereReactive).HectovoltamperesReactive, HectovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.KilovoltampereReactive).KilovoltamperesReactive, KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.MegavoltampereReactive).MegavoltamperesReactive, MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.MicrovoltampereReactive).MicrovoltamperesReactive, MicrovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.MillivoltampereReactive).MillivoltamperesReactive, MillivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.NanovoltampereReactive).NanovoltamperesReactive, NanovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.PetavoltampereReactive).PetavoltamperesReactive, PetavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.PicovoltampereReactive).PicovoltamperesReactive, PicovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.QutravoltampereReactive).QutravoltamperesReactive, QutravoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.TeravoltampereReactive).TeravoltamperesReactive, TeravoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.VettavoltampereReactive).VettavoltamperesReactive, VettavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.VoltampereReactive).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.YoctovoltampereReactive).YoctovoltamperesReactive, YoctovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.YottavoltampereReactive).YottavoltamperesReactive, YottavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.ZeptovoltampereReactive).ZeptovoltamperesReactive, ZeptovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.ZettavoltampereReactive).ZettavoltamperesReactive, ZettavoltamperesReactiveTolerance);
        }

        [Fact]
        public void FromVoltamperesReactive_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReactivePower.FromVoltamperesReactive(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ReactivePower.FromVoltamperesReactive(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltamperesReactive_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReactivePower.FromVoltamperesReactive(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(AttovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.AttovoltampereReactive), AttovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(CentivoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.CentivoltampereReactive), CentivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(DecavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.DecavoltampereReactive), DecavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(DecivoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.DecivoltampereReactive), DecivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(ExavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.ExavoltampereReactive), ExavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(FemtovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.FemtovoltampereReactive), FemtovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(GigavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.GigavoltampereReactive), GigavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(HectovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.HectovoltampereReactive), HectovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(KilovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.KilovoltampereReactive), KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MegavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.MegavoltampereReactive), MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MicrovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.MicrovoltampereReactive), MicrovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MillivoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.MillivoltampereReactive), MillivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(NanovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.NanovoltampereReactive), NanovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(PetavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.PetavoltampereReactive), PetavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(PicovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.PicovoltampereReactive), PicovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(QutravoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.QutravoltampereReactive), QutravoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(TeravoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.TeravoltampereReactive), TeravoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(VettavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.VettavoltampereReactive), VettavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(VoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.VoltampereReactive), VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(YoctovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.YoctovoltampereReactive), YoctovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(YottavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.YottavoltampereReactive), YottavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(ZeptovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.ZeptovoltampereReactive), ZeptovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(ZettavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.ZettavoltampereReactive), ZettavoltamperesReactiveTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var voltamperereactive = ReactivePower.FromVoltamperesReactive(1);

            var attovoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.AttovoltampereReactive);
            AssertEx.EqualTolerance(AttovoltamperesReactiveInOneVoltampereReactive, (double)attovoltamperereactiveQuantity.Value, AttovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.AttovoltampereReactive, attovoltamperereactiveQuantity.Unit);

            var centivoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.CentivoltampereReactive);
            AssertEx.EqualTolerance(CentivoltamperesReactiveInOneVoltampereReactive, (double)centivoltamperereactiveQuantity.Value, CentivoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.CentivoltampereReactive, centivoltamperereactiveQuantity.Unit);

            var decavoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.DecavoltampereReactive);
            AssertEx.EqualTolerance(DecavoltamperesReactiveInOneVoltampereReactive, (double)decavoltamperereactiveQuantity.Value, DecavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.DecavoltampereReactive, decavoltamperereactiveQuantity.Unit);

            var decivoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.DecivoltampereReactive);
            AssertEx.EqualTolerance(DecivoltamperesReactiveInOneVoltampereReactive, (double)decivoltamperereactiveQuantity.Value, DecivoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.DecivoltampereReactive, decivoltamperereactiveQuantity.Unit);

            var exavoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.ExavoltampereReactive);
            AssertEx.EqualTolerance(ExavoltamperesReactiveInOneVoltampereReactive, (double)exavoltamperereactiveQuantity.Value, ExavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.ExavoltampereReactive, exavoltamperereactiveQuantity.Unit);

            var femtovoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.FemtovoltampereReactive);
            AssertEx.EqualTolerance(FemtovoltamperesReactiveInOneVoltampereReactive, (double)femtovoltamperereactiveQuantity.Value, FemtovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.FemtovoltampereReactive, femtovoltamperereactiveQuantity.Unit);

            var gigavoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.GigavoltampereReactive);
            AssertEx.EqualTolerance(GigavoltamperesReactiveInOneVoltampereReactive, (double)gigavoltamperereactiveQuantity.Value, GigavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.GigavoltampereReactive, gigavoltamperereactiveQuantity.Unit);

            var hectovoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.HectovoltampereReactive);
            AssertEx.EqualTolerance(HectovoltamperesReactiveInOneVoltampereReactive, (double)hectovoltamperereactiveQuantity.Value, HectovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.HectovoltampereReactive, hectovoltamperereactiveQuantity.Unit);

            var kilovoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.KilovoltampereReactive);
            AssertEx.EqualTolerance(KilovoltamperesReactiveInOneVoltampereReactive, (double)kilovoltamperereactiveQuantity.Value, KilovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.KilovoltampereReactive, kilovoltamperereactiveQuantity.Unit);

            var megavoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.MegavoltampereReactive);
            AssertEx.EqualTolerance(MegavoltamperesReactiveInOneVoltampereReactive, (double)megavoltamperereactiveQuantity.Value, MegavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.MegavoltampereReactive, megavoltamperereactiveQuantity.Unit);

            var microvoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.MicrovoltampereReactive);
            AssertEx.EqualTolerance(MicrovoltamperesReactiveInOneVoltampereReactive, (double)microvoltamperereactiveQuantity.Value, MicrovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.MicrovoltampereReactive, microvoltamperereactiveQuantity.Unit);

            var millivoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.MillivoltampereReactive);
            AssertEx.EqualTolerance(MillivoltamperesReactiveInOneVoltampereReactive, (double)millivoltamperereactiveQuantity.Value, MillivoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.MillivoltampereReactive, millivoltamperereactiveQuantity.Unit);

            var nanovoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.NanovoltampereReactive);
            AssertEx.EqualTolerance(NanovoltamperesReactiveInOneVoltampereReactive, (double)nanovoltamperereactiveQuantity.Value, NanovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.NanovoltampereReactive, nanovoltamperereactiveQuantity.Unit);

            var petavoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.PetavoltampereReactive);
            AssertEx.EqualTolerance(PetavoltamperesReactiveInOneVoltampereReactive, (double)petavoltamperereactiveQuantity.Value, PetavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.PetavoltampereReactive, petavoltamperereactiveQuantity.Unit);

            var picovoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.PicovoltampereReactive);
            AssertEx.EqualTolerance(PicovoltamperesReactiveInOneVoltampereReactive, (double)picovoltamperereactiveQuantity.Value, PicovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.PicovoltampereReactive, picovoltamperereactiveQuantity.Unit);

            var qutravoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.QutravoltampereReactive);
            AssertEx.EqualTolerance(QutravoltamperesReactiveInOneVoltampereReactive, (double)qutravoltamperereactiveQuantity.Value, QutravoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.QutravoltampereReactive, qutravoltamperereactiveQuantity.Unit);

            var teravoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.TeravoltampereReactive);
            AssertEx.EqualTolerance(TeravoltamperesReactiveInOneVoltampereReactive, (double)teravoltamperereactiveQuantity.Value, TeravoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.TeravoltampereReactive, teravoltamperereactiveQuantity.Unit);

            var vettavoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.VettavoltampereReactive);
            AssertEx.EqualTolerance(VettavoltamperesReactiveInOneVoltampereReactive, (double)vettavoltamperereactiveQuantity.Value, VettavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.VettavoltampereReactive, vettavoltamperereactiveQuantity.Unit);

            var voltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.VoltampereReactive);
            AssertEx.EqualTolerance(VoltamperesReactiveInOneVoltampereReactive, (double)voltamperereactiveQuantity.Value, VoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.VoltampereReactive, voltamperereactiveQuantity.Unit);

            var yoctovoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.YoctovoltampereReactive);
            AssertEx.EqualTolerance(YoctovoltamperesReactiveInOneVoltampereReactive, (double)yoctovoltamperereactiveQuantity.Value, YoctovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.YoctovoltampereReactive, yoctovoltamperereactiveQuantity.Unit);

            var yottavoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.YottavoltampereReactive);
            AssertEx.EqualTolerance(YottavoltamperesReactiveInOneVoltampereReactive, (double)yottavoltamperereactiveQuantity.Value, YottavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.YottavoltampereReactive, yottavoltamperereactiveQuantity.Unit);

            var zeptovoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.ZeptovoltampereReactive);
            AssertEx.EqualTolerance(ZeptovoltamperesReactiveInOneVoltampereReactive, (double)zeptovoltamperereactiveQuantity.Value, ZeptovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.ZeptovoltampereReactive, zeptovoltamperereactiveQuantity.Unit);

            var zettavoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.ZettavoltampereReactive);
            AssertEx.EqualTolerance(ZettavoltamperesReactiveInOneVoltampereReactive, (double)zettavoltamperereactiveQuantity.Value, ZettavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.ZettavoltampereReactive, zettavoltamperereactiveQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(1, ReactivePower.FromAttovoltamperesReactive(voltamperereactive.AttovoltamperesReactive).VoltamperesReactive, AttovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromCentivoltamperesReactive(voltamperereactive.CentivoltamperesReactive).VoltamperesReactive, CentivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromDecavoltamperesReactive(voltamperereactive.DecavoltamperesReactive).VoltamperesReactive, DecavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromDecivoltamperesReactive(voltamperereactive.DecivoltamperesReactive).VoltamperesReactive, DecivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromExavoltamperesReactive(voltamperereactive.ExavoltamperesReactive).VoltamperesReactive, ExavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromFemtovoltamperesReactive(voltamperereactive.FemtovoltamperesReactive).VoltamperesReactive, FemtovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromGigavoltamperesReactive(voltamperereactive.GigavoltamperesReactive).VoltamperesReactive, GigavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromHectovoltamperesReactive(voltamperereactive.HectovoltamperesReactive).VoltamperesReactive, HectovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromKilovoltamperesReactive(voltamperereactive.KilovoltamperesReactive).VoltamperesReactive, KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromMegavoltamperesReactive(voltamperereactive.MegavoltamperesReactive).VoltamperesReactive, MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromMicrovoltamperesReactive(voltamperereactive.MicrovoltamperesReactive).VoltamperesReactive, MicrovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromMillivoltamperesReactive(voltamperereactive.MillivoltamperesReactive).VoltamperesReactive, MillivoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromNanovoltamperesReactive(voltamperereactive.NanovoltamperesReactive).VoltamperesReactive, NanovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromPetavoltamperesReactive(voltamperereactive.PetavoltamperesReactive).VoltamperesReactive, PetavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromPicovoltamperesReactive(voltamperereactive.PicovoltamperesReactive).VoltamperesReactive, PicovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromQutravoltamperesReactive(voltamperereactive.QutravoltamperesReactive).VoltamperesReactive, QutravoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromTeravoltamperesReactive(voltamperereactive.TeravoltamperesReactive).VoltamperesReactive, TeravoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromVettavoltamperesReactive(voltamperereactive.VettavoltamperesReactive).VoltamperesReactive, VettavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromVoltamperesReactive(voltamperereactive.VoltamperesReactive).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromYoctovoltamperesReactive(voltamperereactive.YoctovoltamperesReactive).VoltamperesReactive, YoctovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromYottavoltamperesReactive(voltamperereactive.YottavoltamperesReactive).VoltamperesReactive, YottavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromZeptovoltamperesReactive(voltamperereactive.ZeptovoltamperesReactive).VoltamperesReactive, ZeptovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromZettavoltamperesReactive(voltamperereactive.ZettavoltamperesReactive).VoltamperesReactive, ZettavoltamperesReactiveTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ReactivePower v = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(-1, -v.VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (ReactivePower.FromVoltamperesReactive(3)-v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (ReactivePower.FromVoltamperesReactive(10)/5).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, ReactivePower.FromVoltamperesReactive(10)/ReactivePower.FromVoltamperesReactive(5), VoltamperesReactiveTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ReactivePower oneVoltampereReactive = ReactivePower.FromVoltamperesReactive(1);
            ReactivePower twoVoltamperesReactive = ReactivePower.FromVoltamperesReactive(2);

            Assert.True(oneVoltampereReactive < twoVoltamperesReactive);
            Assert.True(oneVoltampereReactive <= twoVoltamperesReactive);
            Assert.True(twoVoltamperesReactive > oneVoltampereReactive);
            Assert.True(twoVoltamperesReactive >= oneVoltampereReactive);

            Assert.False(oneVoltampereReactive > twoVoltamperesReactive);
            Assert.False(oneVoltampereReactive >= twoVoltamperesReactive);
            Assert.False(twoVoltamperesReactive < oneVoltampereReactive);
            Assert.False(twoVoltamperesReactive <= oneVoltampereReactive);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Equal(0, voltamperereactive.CompareTo(voltamperereactive));
            Assert.True(voltamperereactive.CompareTo(ReactivePower.Zero) > 0);
            Assert.True(ReactivePower.Zero.CompareTo(voltamperereactive) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Throws<ArgumentException>(() => voltamperereactive.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Throws<ArgumentNullException>(() => voltamperereactive.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ReactivePower.FromVoltamperesReactive(1);
            var b = ReactivePower.FromVoltamperesReactive(2);

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
            var a = ReactivePower.FromVoltamperesReactive(1);
            var b = ReactivePower.FromVoltamperesReactive(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = ReactivePower.FromVoltamperesReactive(1);
            Assert.True(v.Equals(ReactivePower.FromVoltamperesReactive(1), VoltamperesReactiveTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ReactivePower.Zero, VoltamperesReactiveTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.False(voltamperereactive.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.False(voltamperereactive.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ReactivePowerUnit.Undefined, ReactivePower.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ReactivePowerUnit)).Cast<ReactivePowerUnit>();
            foreach(var unit in units)
            {
                if(unit == ReactivePowerUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ReactivePower.BaseDimensions is null);
        }
    }
}
