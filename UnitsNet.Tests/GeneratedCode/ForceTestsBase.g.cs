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
    /// Test of Force.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ForceTestsBase
    {
        protected abstract double CentinewtonsInOneNewton { get; }
        protected abstract double DecanewtonsInOneNewton { get; }
        protected abstract double DecinewtonsInOneNewton { get; }
        protected abstract double DyneInOneNewton { get; }
        protected abstract double ExanewtonsInOneNewton { get; }
        protected abstract double FemtonewtonsInOneNewton { get; }
        protected abstract double GiganewtonsInOneNewton { get; }
        protected abstract double HectonewtonsInOneNewton { get; }
        protected abstract double KilogramsForceInOneNewton { get; }
        protected abstract double KilonewtonsInOneNewton { get; }
        protected abstract double KiloPondsInOneNewton { get; }
        protected abstract double MeganewtonsInOneNewton { get; }
        protected abstract double MicronewtonsInOneNewton { get; }
        protected abstract double MillinewtonsInOneNewton { get; }
        protected abstract double NanonewtonsInOneNewton { get; }
        protected abstract double NewtonsInOneNewton { get; }
        protected abstract double OunceForceInOneNewton { get; }
        protected abstract double PetanewtonsInOneNewton { get; }
        protected abstract double PiconewtonsInOneNewton { get; }
        protected abstract double PoundalsInOneNewton { get; }
        protected abstract double PoundsForceInOneNewton { get; }
        protected abstract double QutranewtonsInOneNewton { get; }
        protected abstract double TeranewtonsInOneNewton { get; }
        protected abstract double TonnesForceInOneNewton { get; }
        protected abstract double VettanewtonsInOneNewton { get; }
        protected abstract double YottanewtonsInOneNewton { get; }
        protected abstract double ZettanewtonsInOneNewton { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentinewtonsTolerance { get { return 1e-5; } }
        protected virtual double DecanewtonsTolerance { get { return 1e-5; } }
        protected virtual double DecinewtonsTolerance { get { return 1e-5; } }
        protected virtual double DyneTolerance { get { return 1e-5; } }
        protected virtual double ExanewtonsTolerance { get { return 1e-5; } }
        protected virtual double FemtonewtonsTolerance { get { return 1e-5; } }
        protected virtual double GiganewtonsTolerance { get { return 1e-5; } }
        protected virtual double HectonewtonsTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForceTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsTolerance { get { return 1e-5; } }
        protected virtual double KiloPondsTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonsTolerance { get { return 1e-5; } }
        protected virtual double MicronewtonsTolerance { get { return 1e-5; } }
        protected virtual double MillinewtonsTolerance { get { return 1e-5; } }
        protected virtual double NanonewtonsTolerance { get { return 1e-5; } }
        protected virtual double NewtonsTolerance { get { return 1e-5; } }
        protected virtual double OunceForceTolerance { get { return 1e-5; } }
        protected virtual double PetanewtonsTolerance { get { return 1e-5; } }
        protected virtual double PiconewtonsTolerance { get { return 1e-5; } }
        protected virtual double PoundalsTolerance { get { return 1e-5; } }
        protected virtual double PoundsForceTolerance { get { return 1e-5; } }
        protected virtual double QutranewtonsTolerance { get { return 1e-5; } }
        protected virtual double TeranewtonsTolerance { get { return 1e-5; } }
        protected virtual double TonnesForceTolerance { get { return 1e-5; } }
        protected virtual double VettanewtonsTolerance { get { return 1e-5; } }
        protected virtual double YottanewtonsTolerance { get { return 1e-5; } }
        protected virtual double ZettanewtonsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Force((double)0.0, ForceUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Force(double.PositiveInfinity, ForceUnit.Newton));
            Assert.Throws<ArgumentException>(() => new Force(double.NegativeInfinity, ForceUnit.Newton));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Force(double.NaN, ForceUnit.Newton));
        }

        [Fact]
        public void NewtonToForceUnits()
        {
            Force newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(CentinewtonsInOneNewton, newton.Centinewtons, CentinewtonsTolerance);
            AssertEx.EqualTolerance(DecanewtonsInOneNewton, newton.Decanewtons, DecanewtonsTolerance);
            AssertEx.EqualTolerance(DecinewtonsInOneNewton, newton.Decinewtons, DecinewtonsTolerance);
            AssertEx.EqualTolerance(DyneInOneNewton, newton.Dyne, DyneTolerance);
            AssertEx.EqualTolerance(ExanewtonsInOneNewton, newton.Exanewtons, ExanewtonsTolerance);
            AssertEx.EqualTolerance(FemtonewtonsInOneNewton, newton.Femtonewtons, FemtonewtonsTolerance);
            AssertEx.EqualTolerance(GiganewtonsInOneNewton, newton.Giganewtons, GiganewtonsTolerance);
            AssertEx.EqualTolerance(HectonewtonsInOneNewton, newton.Hectonewtons, HectonewtonsTolerance);
            AssertEx.EqualTolerance(KilogramsForceInOneNewton, newton.KilogramsForce, KilogramsForceTolerance);
            AssertEx.EqualTolerance(KilonewtonsInOneNewton, newton.Kilonewtons, KilonewtonsTolerance);
            AssertEx.EqualTolerance(KiloPondsInOneNewton, newton.KiloPonds, KiloPondsTolerance);
            AssertEx.EqualTolerance(MeganewtonsInOneNewton, newton.Meganewtons, MeganewtonsTolerance);
            AssertEx.EqualTolerance(MicronewtonsInOneNewton, newton.Micronewtons, MicronewtonsTolerance);
            AssertEx.EqualTolerance(MillinewtonsInOneNewton, newton.Millinewtons, MillinewtonsTolerance);
            AssertEx.EqualTolerance(NanonewtonsInOneNewton, newton.Nanonewtons, NanonewtonsTolerance);
            AssertEx.EqualTolerance(NewtonsInOneNewton, newton.Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(OunceForceInOneNewton, newton.OunceForce, OunceForceTolerance);
            AssertEx.EqualTolerance(PetanewtonsInOneNewton, newton.Petanewtons, PetanewtonsTolerance);
            AssertEx.EqualTolerance(PiconewtonsInOneNewton, newton.Piconewtons, PiconewtonsTolerance);
            AssertEx.EqualTolerance(PoundalsInOneNewton, newton.Poundals, PoundalsTolerance);
            AssertEx.EqualTolerance(PoundsForceInOneNewton, newton.PoundsForce, PoundsForceTolerance);
            AssertEx.EqualTolerance(QutranewtonsInOneNewton, newton.Qutranewtons, QutranewtonsTolerance);
            AssertEx.EqualTolerance(TeranewtonsInOneNewton, newton.Teranewtons, TeranewtonsTolerance);
            AssertEx.EqualTolerance(TonnesForceInOneNewton, newton.TonnesForce, TonnesForceTolerance);
            AssertEx.EqualTolerance(VettanewtonsInOneNewton, newton.Vettanewtons, VettanewtonsTolerance);
            AssertEx.EqualTolerance(YottanewtonsInOneNewton, newton.Yottanewtons, YottanewtonsTolerance);
            AssertEx.EqualTolerance(ZettanewtonsInOneNewton, newton.Zettanewtons, ZettanewtonsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Centinewton).Centinewtons, CentinewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Decanewton).Decanewtons, DecanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Decinewton).Decinewtons, DecinewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Dyn).Dyne, DyneTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Exanewton).Exanewtons, ExanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Femtonewton).Femtonewtons, FemtonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Giganewton).Giganewtons, GiganewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Hectonewton).Hectonewtons, HectonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.KilogramForce).KilogramsForce, KilogramsForceTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Kilonewton).Kilonewtons, KilonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.KiloPond).KiloPonds, KiloPondsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Meganewton).Meganewtons, MeganewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Micronewton).Micronewtons, MicronewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Millinewton).Millinewtons, MillinewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Nanonewton).Nanonewtons, NanonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Newton).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.OunceForce).OunceForce, OunceForceTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Petanewton).Petanewtons, PetanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Piconewton).Piconewtons, PiconewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Poundal).Poundals, PoundalsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.PoundForce).PoundsForce, PoundsForceTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Qutranewton).Qutranewtons, QutranewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Teranewton).Teranewtons, TeranewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.TonneForce).TonnesForce, TonnesForceTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Vettanewton).Vettanewtons, VettanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Yottanewton).Yottanewtons, YottanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Zettanewton).Zettanewtons, ZettanewtonsTolerance);
        }

        [Fact]
        public void FromNewtons_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Force.FromNewtons(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Force.FromNewtons(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtons_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Force.FromNewtons(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(CentinewtonsInOneNewton, newton.As(ForceUnit.Centinewton), CentinewtonsTolerance);
            AssertEx.EqualTolerance(DecanewtonsInOneNewton, newton.As(ForceUnit.Decanewton), DecanewtonsTolerance);
            AssertEx.EqualTolerance(DecinewtonsInOneNewton, newton.As(ForceUnit.Decinewton), DecinewtonsTolerance);
            AssertEx.EqualTolerance(DyneInOneNewton, newton.As(ForceUnit.Dyn), DyneTolerance);
            AssertEx.EqualTolerance(ExanewtonsInOneNewton, newton.As(ForceUnit.Exanewton), ExanewtonsTolerance);
            AssertEx.EqualTolerance(FemtonewtonsInOneNewton, newton.As(ForceUnit.Femtonewton), FemtonewtonsTolerance);
            AssertEx.EqualTolerance(GiganewtonsInOneNewton, newton.As(ForceUnit.Giganewton), GiganewtonsTolerance);
            AssertEx.EqualTolerance(HectonewtonsInOneNewton, newton.As(ForceUnit.Hectonewton), HectonewtonsTolerance);
            AssertEx.EqualTolerance(KilogramsForceInOneNewton, newton.As(ForceUnit.KilogramForce), KilogramsForceTolerance);
            AssertEx.EqualTolerance(KilonewtonsInOneNewton, newton.As(ForceUnit.Kilonewton), KilonewtonsTolerance);
            AssertEx.EqualTolerance(KiloPondsInOneNewton, newton.As(ForceUnit.KiloPond), KiloPondsTolerance);
            AssertEx.EqualTolerance(MeganewtonsInOneNewton, newton.As(ForceUnit.Meganewton), MeganewtonsTolerance);
            AssertEx.EqualTolerance(MicronewtonsInOneNewton, newton.As(ForceUnit.Micronewton), MicronewtonsTolerance);
            AssertEx.EqualTolerance(MillinewtonsInOneNewton, newton.As(ForceUnit.Millinewton), MillinewtonsTolerance);
            AssertEx.EqualTolerance(NanonewtonsInOneNewton, newton.As(ForceUnit.Nanonewton), NanonewtonsTolerance);
            AssertEx.EqualTolerance(NewtonsInOneNewton, newton.As(ForceUnit.Newton), NewtonsTolerance);
            AssertEx.EqualTolerance(OunceForceInOneNewton, newton.As(ForceUnit.OunceForce), OunceForceTolerance);
            AssertEx.EqualTolerance(PetanewtonsInOneNewton, newton.As(ForceUnit.Petanewton), PetanewtonsTolerance);
            AssertEx.EqualTolerance(PiconewtonsInOneNewton, newton.As(ForceUnit.Piconewton), PiconewtonsTolerance);
            AssertEx.EqualTolerance(PoundalsInOneNewton, newton.As(ForceUnit.Poundal), PoundalsTolerance);
            AssertEx.EqualTolerance(PoundsForceInOneNewton, newton.As(ForceUnit.PoundForce), PoundsForceTolerance);
            AssertEx.EqualTolerance(QutranewtonsInOneNewton, newton.As(ForceUnit.Qutranewton), QutranewtonsTolerance);
            AssertEx.EqualTolerance(TeranewtonsInOneNewton, newton.As(ForceUnit.Teranewton), TeranewtonsTolerance);
            AssertEx.EqualTolerance(TonnesForceInOneNewton, newton.As(ForceUnit.TonneForce), TonnesForceTolerance);
            AssertEx.EqualTolerance(VettanewtonsInOneNewton, newton.As(ForceUnit.Vettanewton), VettanewtonsTolerance);
            AssertEx.EqualTolerance(YottanewtonsInOneNewton, newton.As(ForceUnit.Yottanewton), YottanewtonsTolerance);
            AssertEx.EqualTolerance(ZettanewtonsInOneNewton, newton.As(ForceUnit.Zettanewton), ZettanewtonsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newton = Force.FromNewtons(1);

            var centinewtonQuantity = newton.ToUnit(ForceUnit.Centinewton);
            AssertEx.EqualTolerance(CentinewtonsInOneNewton, (double)centinewtonQuantity.Value, CentinewtonsTolerance);
            Assert.Equal(ForceUnit.Centinewton, centinewtonQuantity.Unit);

            var decanewtonQuantity = newton.ToUnit(ForceUnit.Decanewton);
            AssertEx.EqualTolerance(DecanewtonsInOneNewton, (double)decanewtonQuantity.Value, DecanewtonsTolerance);
            Assert.Equal(ForceUnit.Decanewton, decanewtonQuantity.Unit);

            var decinewtonQuantity = newton.ToUnit(ForceUnit.Decinewton);
            AssertEx.EqualTolerance(DecinewtonsInOneNewton, (double)decinewtonQuantity.Value, DecinewtonsTolerance);
            Assert.Equal(ForceUnit.Decinewton, decinewtonQuantity.Unit);

            var dynQuantity = newton.ToUnit(ForceUnit.Dyn);
            AssertEx.EqualTolerance(DyneInOneNewton, (double)dynQuantity.Value, DyneTolerance);
            Assert.Equal(ForceUnit.Dyn, dynQuantity.Unit);

            var exanewtonQuantity = newton.ToUnit(ForceUnit.Exanewton);
            AssertEx.EqualTolerance(ExanewtonsInOneNewton, (double)exanewtonQuantity.Value, ExanewtonsTolerance);
            Assert.Equal(ForceUnit.Exanewton, exanewtonQuantity.Unit);

            var femtonewtonQuantity = newton.ToUnit(ForceUnit.Femtonewton);
            AssertEx.EqualTolerance(FemtonewtonsInOneNewton, (double)femtonewtonQuantity.Value, FemtonewtonsTolerance);
            Assert.Equal(ForceUnit.Femtonewton, femtonewtonQuantity.Unit);

            var giganewtonQuantity = newton.ToUnit(ForceUnit.Giganewton);
            AssertEx.EqualTolerance(GiganewtonsInOneNewton, (double)giganewtonQuantity.Value, GiganewtonsTolerance);
            Assert.Equal(ForceUnit.Giganewton, giganewtonQuantity.Unit);

            var hectonewtonQuantity = newton.ToUnit(ForceUnit.Hectonewton);
            AssertEx.EqualTolerance(HectonewtonsInOneNewton, (double)hectonewtonQuantity.Value, HectonewtonsTolerance);
            Assert.Equal(ForceUnit.Hectonewton, hectonewtonQuantity.Unit);

            var kilogramforceQuantity = newton.ToUnit(ForceUnit.KilogramForce);
            AssertEx.EqualTolerance(KilogramsForceInOneNewton, (double)kilogramforceQuantity.Value, KilogramsForceTolerance);
            Assert.Equal(ForceUnit.KilogramForce, kilogramforceQuantity.Unit);

            var kilonewtonQuantity = newton.ToUnit(ForceUnit.Kilonewton);
            AssertEx.EqualTolerance(KilonewtonsInOneNewton, (double)kilonewtonQuantity.Value, KilonewtonsTolerance);
            Assert.Equal(ForceUnit.Kilonewton, kilonewtonQuantity.Unit);

            var kilopondQuantity = newton.ToUnit(ForceUnit.KiloPond);
            AssertEx.EqualTolerance(KiloPondsInOneNewton, (double)kilopondQuantity.Value, KiloPondsTolerance);
            Assert.Equal(ForceUnit.KiloPond, kilopondQuantity.Unit);

            var meganewtonQuantity = newton.ToUnit(ForceUnit.Meganewton);
            AssertEx.EqualTolerance(MeganewtonsInOneNewton, (double)meganewtonQuantity.Value, MeganewtonsTolerance);
            Assert.Equal(ForceUnit.Meganewton, meganewtonQuantity.Unit);

            var micronewtonQuantity = newton.ToUnit(ForceUnit.Micronewton);
            AssertEx.EqualTolerance(MicronewtonsInOneNewton, (double)micronewtonQuantity.Value, MicronewtonsTolerance);
            Assert.Equal(ForceUnit.Micronewton, micronewtonQuantity.Unit);

            var millinewtonQuantity = newton.ToUnit(ForceUnit.Millinewton);
            AssertEx.EqualTolerance(MillinewtonsInOneNewton, (double)millinewtonQuantity.Value, MillinewtonsTolerance);
            Assert.Equal(ForceUnit.Millinewton, millinewtonQuantity.Unit);

            var nanonewtonQuantity = newton.ToUnit(ForceUnit.Nanonewton);
            AssertEx.EqualTolerance(NanonewtonsInOneNewton, (double)nanonewtonQuantity.Value, NanonewtonsTolerance);
            Assert.Equal(ForceUnit.Nanonewton, nanonewtonQuantity.Unit);

            var newtonQuantity = newton.ToUnit(ForceUnit.Newton);
            AssertEx.EqualTolerance(NewtonsInOneNewton, (double)newtonQuantity.Value, NewtonsTolerance);
            Assert.Equal(ForceUnit.Newton, newtonQuantity.Unit);

            var ounceforceQuantity = newton.ToUnit(ForceUnit.OunceForce);
            AssertEx.EqualTolerance(OunceForceInOneNewton, (double)ounceforceQuantity.Value, OunceForceTolerance);
            Assert.Equal(ForceUnit.OunceForce, ounceforceQuantity.Unit);

            var petanewtonQuantity = newton.ToUnit(ForceUnit.Petanewton);
            AssertEx.EqualTolerance(PetanewtonsInOneNewton, (double)petanewtonQuantity.Value, PetanewtonsTolerance);
            Assert.Equal(ForceUnit.Petanewton, petanewtonQuantity.Unit);

            var piconewtonQuantity = newton.ToUnit(ForceUnit.Piconewton);
            AssertEx.EqualTolerance(PiconewtonsInOneNewton, (double)piconewtonQuantity.Value, PiconewtonsTolerance);
            Assert.Equal(ForceUnit.Piconewton, piconewtonQuantity.Unit);

            var poundalQuantity = newton.ToUnit(ForceUnit.Poundal);
            AssertEx.EqualTolerance(PoundalsInOneNewton, (double)poundalQuantity.Value, PoundalsTolerance);
            Assert.Equal(ForceUnit.Poundal, poundalQuantity.Unit);

            var poundforceQuantity = newton.ToUnit(ForceUnit.PoundForce);
            AssertEx.EqualTolerance(PoundsForceInOneNewton, (double)poundforceQuantity.Value, PoundsForceTolerance);
            Assert.Equal(ForceUnit.PoundForce, poundforceQuantity.Unit);

            var qutranewtonQuantity = newton.ToUnit(ForceUnit.Qutranewton);
            AssertEx.EqualTolerance(QutranewtonsInOneNewton, (double)qutranewtonQuantity.Value, QutranewtonsTolerance);
            Assert.Equal(ForceUnit.Qutranewton, qutranewtonQuantity.Unit);

            var teranewtonQuantity = newton.ToUnit(ForceUnit.Teranewton);
            AssertEx.EqualTolerance(TeranewtonsInOneNewton, (double)teranewtonQuantity.Value, TeranewtonsTolerance);
            Assert.Equal(ForceUnit.Teranewton, teranewtonQuantity.Unit);

            var tonneforceQuantity = newton.ToUnit(ForceUnit.TonneForce);
            AssertEx.EqualTolerance(TonnesForceInOneNewton, (double)tonneforceQuantity.Value, TonnesForceTolerance);
            Assert.Equal(ForceUnit.TonneForce, tonneforceQuantity.Unit);

            var vettanewtonQuantity = newton.ToUnit(ForceUnit.Vettanewton);
            AssertEx.EqualTolerance(VettanewtonsInOneNewton, (double)vettanewtonQuantity.Value, VettanewtonsTolerance);
            Assert.Equal(ForceUnit.Vettanewton, vettanewtonQuantity.Unit);

            var yottanewtonQuantity = newton.ToUnit(ForceUnit.Yottanewton);
            AssertEx.EqualTolerance(YottanewtonsInOneNewton, (double)yottanewtonQuantity.Value, YottanewtonsTolerance);
            Assert.Equal(ForceUnit.Yottanewton, yottanewtonQuantity.Unit);

            var zettanewtonQuantity = newton.ToUnit(ForceUnit.Zettanewton);
            AssertEx.EqualTolerance(ZettanewtonsInOneNewton, (double)zettanewtonQuantity.Value, ZettanewtonsTolerance);
            Assert.Equal(ForceUnit.Zettanewton, zettanewtonQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Force newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(1, Force.FromCentinewtons(newton.Centinewtons).Newtons, CentinewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromDecanewtons(newton.Decanewtons).Newtons, DecanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromDecinewtons(newton.Decinewtons).Newtons, DecinewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromDyne(newton.Dyne).Newtons, DyneTolerance);
            AssertEx.EqualTolerance(1, Force.FromExanewtons(newton.Exanewtons).Newtons, ExanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromFemtonewtons(newton.Femtonewtons).Newtons, FemtonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromGiganewtons(newton.Giganewtons).Newtons, GiganewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromHectonewtons(newton.Hectonewtons).Newtons, HectonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromKilogramsForce(newton.KilogramsForce).Newtons, KilogramsForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromKilonewtons(newton.Kilonewtons).Newtons, KilonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromKiloPonds(newton.KiloPonds).Newtons, KiloPondsTolerance);
            AssertEx.EqualTolerance(1, Force.FromMeganewtons(newton.Meganewtons).Newtons, MeganewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromMicronewtons(newton.Micronewtons).Newtons, MicronewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromMillinewtons(newton.Millinewtons).Newtons, MillinewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromNanonewtons(newton.Nanonewtons).Newtons, NanonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromNewtons(newton.Newtons).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromOunceForce(newton.OunceForce).Newtons, OunceForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromPetanewtons(newton.Petanewtons).Newtons, PetanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromPiconewtons(newton.Piconewtons).Newtons, PiconewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromPoundals(newton.Poundals).Newtons, PoundalsTolerance);
            AssertEx.EqualTolerance(1, Force.FromPoundsForce(newton.PoundsForce).Newtons, PoundsForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromQutranewtons(newton.Qutranewtons).Newtons, QutranewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromTeranewtons(newton.Teranewtons).Newtons, TeranewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromTonnesForce(newton.TonnesForce).Newtons, TonnesForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromVettanewtons(newton.Vettanewtons).Newtons, VettanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromYottanewtons(newton.Yottanewtons).Newtons, YottanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromZettanewtons(newton.Zettanewtons).Newtons, ZettanewtonsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Force v = Force.FromNewtons(1);
            AssertEx.EqualTolerance(-1, -v.Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (Force.FromNewtons(3)-v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (Force.FromNewtons(10)/5).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, Force.FromNewtons(10)/Force.FromNewtons(5), NewtonsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Force oneNewton = Force.FromNewtons(1);
            Force twoNewtons = Force.FromNewtons(2);

            Assert.True(oneNewton < twoNewtons);
            Assert.True(oneNewton <= twoNewtons);
            Assert.True(twoNewtons > oneNewton);
            Assert.True(twoNewtons >= oneNewton);

            Assert.False(oneNewton > twoNewtons);
            Assert.False(oneNewton >= twoNewtons);
            Assert.False(twoNewtons < oneNewton);
            Assert.False(twoNewtons <= oneNewton);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Equal(0, newton.CompareTo(newton));
            Assert.True(newton.CompareTo(Force.Zero) > 0);
            Assert.True(Force.Zero.CompareTo(newton) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Throws<ArgumentException>(() => newton.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Throws<ArgumentNullException>(() => newton.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Force.FromNewtons(1);
            var b = Force.FromNewtons(2);

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
            var a = Force.FromNewtons(1);
            var b = Force.FromNewtons(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = Force.FromNewtons(1);
            Assert.True(v.Equals(Force.FromNewtons(1), NewtonsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Force.Zero, NewtonsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Force newton = Force.FromNewtons(1);
            Assert.False(newton.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Force newton = Force.FromNewtons(1);
            Assert.False(newton.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ForceUnit.Undefined, Force.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ForceUnit)).Cast<ForceUnit>();
            foreach(var unit in units)
            {
                if(unit == ForceUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Force.BaseDimensions is null);
        }
    }
}
