// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class TorqueTests : TorqueTestsBase
    {
        protected override double KilogramForceCentimetersInOneNewtonMeter => 10.1971621;
        protected override double KilogramForceMetersInOneNewtonMeter => 0.101971621;
        protected override double KilogramForceMillimetersInOneNewtonMeter => 101.971621;
        protected override double TonneForceCentimetersInOneNewtonMeter => 1.01972e-2;
        protected override double TonneForceMetersInOneNewtonMeter => 1.01972e-4;
        protected override double TonneForceMillimetersInOneNewtonMeter => 1.01972e-1;

        protected override double FemtonewtonCentimetersInOneNewtonMeter => 1e17;
        protected override double PiconewtonCentimetersInOneNewtonMeter => 1e14;
        protected override double NanonewtonCentimetersInOneNewtonMeter => 1e11;
        protected override double MicronewtonCentimetersInOneNewtonMeter => 1e8;
        protected override double MillinewtonCentimetersInOneNewtonMeter => 1e5;
        protected override double CentinewtonCentimetersInOneNewtonMeter => 1e4;
        protected override double DecinewtonCentimetersInOneNewtonMeter => 1e3;
        protected override double NewtonCentimetersInOneNewtonMeter => 100;
        protected override double DecanewtonCentimetersInOneNewtonMeter => 10;
        protected override double HectonewtonCentimetersInOneNewtonMeter => 1;
        protected override double KilonewtonCentimetersInOneNewtonMeter => 0.1;
        protected override double MeganewtonCentimetersInOneNewtonMeter => 1E-4;
        protected override double GiganewtonCentimetersInOneNewtonMeter => 1E-7;
        protected override double TeranewtonCentimetersInOneNewtonMeter => 1E-10;
        protected override double PetanewtonCentimetersInOneNewtonMeter => 1E-13;
        protected override double ExanewtonCentimetersInOneNewtonMeter => 1E-16;
        protected override double ZettanewtonCentimetersInOneNewtonMeter => 1E-19;
        protected override double YottanewtonCentimetersInOneNewtonMeter => 1E-22;
        protected override double QutranewtonCentimetersInOneNewtonMeter => 1E-25;
        protected override double VettanewtonCentimetersInOneNewtonMeter => 1E-28;


        protected override double FemtonewtonMetersInOneNewtonMeter =>  1e15;
        protected override double PiconewtonMetersInOneNewtonMeter  =>  1e12;
        protected override double NanonewtonMetersInOneNewtonMeter  =>  1e9;
        protected override double MicronewtonMetersInOneNewtonMeter =>  1e6;
        protected override double MillinewtonMetersInOneNewtonMeter =>  1e3;
        protected override double CentinewtonMetersInOneNewtonMeter =>  1e2;
        protected override double DecinewtonMetersInOneNewtonMeter  =>  1e1;
        protected override double NewtonMetersInOneNewtonMeter => 1;
        protected override double DecanewtonMetersInOneNewtonMeter  =>  1e-1;
        protected override double HectonewtonMetersInOneNewtonMeter =>  1e-2;
        protected override double KilonewtonMetersInOneNewtonMeter  =>  1e-3;
        protected override double MeganewtonMetersInOneNewtonMeter  =>  1e-6;
        protected override double GiganewtonMetersInOneNewtonMeter  =>  1e-9;
        protected override double TeranewtonMetersInOneNewtonMeter  =>  1e-12;
        protected override double PetanewtonMetersInOneNewtonMeter  =>  1e-15;
        protected override double ExanewtonMetersInOneNewtonMeter   =>  1e-18;
        protected override double ZettanewtonMetersInOneNewtonMeter =>  1e-21;
        protected override double YottanewtonMetersInOneNewtonMeter =>  1e-24;
        protected override double QutranewtonMetersInOneNewtonMeter =>  1e-27;
        protected override double VettanewtonMetersInOneNewtonMeter =>  1e-30;

        protected override double FemtopoundForceInchesInOneNewtonMeter => 8.85074579e15;
        protected override double PicopoundForceInchesInOneNewtonMeter => 8.85074579e12;
        protected override double NanopoundForceInchesInOneNewtonMeter => 8.85074579e9;
        protected override double MicropoundForceInchesInOneNewtonMeter => 8.85074579e6;
        protected override double MillipoundForceInchesInOneNewtonMeter => 8.85074579e3;
        protected override double CentipoundForceInchesInOneNewtonMeter => 8.85074579e2;
        protected override double DecipoundForceInchesInOneNewtonMeter => 8.85074579e1;
        protected override double PoundForceInchesInOneNewtonMeter => 8.85074579;
        protected override double DecapoundForceInchesInOneNewtonMeter => 8.850745791327184e-1;
        protected override double HectopoundForceInchesInOneNewtonMeter => 8.850745791327184e-2;
        protected override double KilopoundForceInchesInOneNewtonMeter => 8.850745791327184e-3;
        protected override double MegapoundForceInchesInOneNewtonMeter => 8.850745791327184e-6;
        protected override double GigapoundForceInchesInOneNewtonMeter => 8.850745791327184e-9;
        protected override double TerapoundForceInchesInOneNewtonMeter => 8.850745791327184e-12;
        protected override double PetapoundForceInchesInOneNewtonMeter => 8.850745791327184e-15;
        protected override double ExapoundForceInchesInOneNewtonMeter => 8.850745791327184e-18;
        protected override double ZettapoundForceInchesInOneNewtonMeter => 8.850745791327184e-21;
        protected override double YottapoundForceInchesInOneNewtonMeter => 8.850745791327184e-24;
        protected override double QutrapoundForceInchesInOneNewtonMeter => 8.850745791327184e-27;
        protected override double VettapoundForceInchesInOneNewtonMeter => 8.850745791327184e-30;

        protected override double FemtonewtonMillimetersInOneNewtonMeter => 1e18;
        protected override double PiconewtonMillimetersInOneNewtonMeter => 1e15;
        protected override double NanonewtonMillimetersInOneNewtonMeter => 1e12;
        protected override double MicronewtonMillimetersInOneNewtonMeter => 1e9;
        protected override double MillinewtonMillimetersInOneNewtonMeter => 1e6;
        protected override double CentinewtonMillimetersInOneNewtonMeter => 1e5;
        protected override double DecinewtonMillimetersInOneNewtonMeter => 1e4;
        protected override double NewtonMillimetersInOneNewtonMeter => 1e3;
        protected override double DecanewtonMillimetersInOneNewtonMeter => 1e2;
        protected override double HectonewtonMillimetersInOneNewtonMeter => 1e1;
        protected override double KilonewtonMillimetersInOneNewtonMeter => 1;
        protected override double MeganewtonMillimetersInOneNewtonMeter => 1E-3;
        protected override double GiganewtonMillimetersInOneNewtonMeter => 1e-6;
        protected override double TeranewtonMillimetersInOneNewtonMeter => 1e-9;
        protected override double PetanewtonMillimetersInOneNewtonMeter => 1e-12;
        protected override double ExanewtonMillimetersInOneNewtonMeter => 1e-15;
        protected override double ZettanewtonMillimetersInOneNewtonMeter => 1e-18;
        protected override double YottanewtonMillimetersInOneNewtonMeter => 1e-21;
        protected override double QutranewtonMillimetersInOneNewtonMeter => 1e-24;
        protected override double VettanewtonMillimetersInOneNewtonMeter => 1e-27;

        protected override double FemtopoundForceFeetInOneNewtonMeter => 7.37562149277e14;
        protected override double PicopoundForceFeetInOneNewtonMeter => 7.37562149277e11;
        protected override double NanopoundForceFeetInOneNewtonMeter => 7.37562149277e8;
        protected override double MicropoundForceFeetInOneNewtonMeter => 7.37562149277e5;
        protected override double MillipoundForceFeetInOneNewtonMeter => 7.37562149277e2;
        protected override double CentipoundForceFeetInOneNewtonMeter => 7.37562149277e1;
        protected override double DecipoundForceFeetInOneNewtonMeter => 7.37562149277;
        protected override double PoundForceFeetInOneNewtonMeter => 7.37562149277e-1;
        protected override double DecapoundForceFeetInOneNewtonMeter => 7.37562149277e-2;
        protected override double HectopoundForceFeetInOneNewtonMeter => 7.37562149277e-3;
        protected override double KilopoundForceFeetInOneNewtonMeter => 7.375621492772654e-4;
        protected override double MegapoundForceFeetInOneNewtonMeter => 7.375621492772654e-7;
        protected override double GigapoundForceFeetInOneNewtonMeter => 7.37562149277e-10;
        protected override double TerapoundForceFeetInOneNewtonMeter => 7.37562149277e-13;
        protected override double PetapoundForceFeetInOneNewtonMeter => 7.37562149277e-16;
        protected override double ExapoundForceFeetInOneNewtonMeter => 7.37562149277e-19;
        protected override double ZettapoundForceFeetInOneNewtonMeter => 7.37562149277e-22;
        protected override double YottapoundForceFeetInOneNewtonMeter => 7.37562149277e-25;
        protected override double QutrapoundForceFeetInOneNewtonMeter => 7.37562149277e-28;
        protected override double VettapoundForceFeetInOneNewtonMeter => 7.37562149277e-31;

        [Fact]
        public void TorqueDividedByForceEqualsLength()
        {
            Length length = Torque.FromNewtonMeters(4)/Force.FromNewtons(2);
            Assert.Equal(length, Length.FromMeters(2));
        }

        [Fact]
        public void TorqueDividedByLengthEqualsForce()
        {
            Force force = Torque.FromNewtonMeters(4)/Length.FromMeters(2);
            Assert.Equal(force, Force.FromNewtons(2));
        }
    }
}
