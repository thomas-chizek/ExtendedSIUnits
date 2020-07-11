// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using Xunit;
using UnitsNet.Units;
using System;

namespace UnitsNet.Tests.CustomCode
{
    // Avoid accessing static prop DefaultToString in parallel from multiple tests:
    // UnitSystemTests.DefaultToStringFormatting()
    // LengthTests.ToStringReturnsCorrectNumberAndUnitWithCentimeterAsDefualtUnit()
    [Collection(nameof(UnitAbbreviationsCacheFixture))]
    public class LengthTests : LengthTestsBase
    {

        protected override double DtpPicasInOneMeter => 236.22047244;
        protected override double DtpPointsInOneMeter => 2834.6456693;

        protected override double FeetInOneMeter => 3.28084;

        protected override double HectometersInOneMeter => 1E-2;

        protected override double TwipsInOneMeter => 56692.913386;
        protected override double UsSurveyFeetInOneMeter => 3.280833333333333;

        protected override double InchesInOneMeter => 39.37007874;



        protected override double FemtometersInOneMeter => 1e15;
        protected override double PicometersInOneMeter => 1e12;
        protected override double NanometersInOneMeter => 1E9;
        protected override double MicrometersInOneMeter => 1E6;
        protected override double MillimetersInOneMeter => 1E3;
        protected override double CentimetersInOneMeter => 100;
        protected override double DecimetersInOneMeter => 10;
        protected override double MetersInOneMeter => 1;
        protected override double DecametersInOneMeter => 0.1;
        protected override double KilometersInOneMeter => 1E-3;
        protected override double MegametersInOneMeter => 1e-6;
        protected override double GigametersInOneMeter => 1e-9;
        protected override double TerametersInOneMeter => 1e-12;
        protected override double PetametersInOneMeter => 1e-15;
        protected override double ExametersInOneMeter => 1e-18;
        protected override double ZettametersInOneMeter => 1e-21;
        protected override double YottametersInOneMeter => 1e-24;
        protected override double QutrametersInOneMeter => 1e-27;
        protected override double VettametersInOneMeter => 1e-30;


        protected override double MicrolightSecondsInOneMeter => 3.33564e-3;
        protected override double MillilightSecondsInOneMeter => 3.33564e-6;
        protected override double LightSecondsInOneMeter => 3.33564e-9;
        protected override double DecalightSecondsInOneMeter => 3.33564e-10;
        protected override double KilolightSecondsInOneMeter => 3.33564e-12;
        protected override double MegalightSecondsInOneMeter => 3.33564e-15;
        protected override double GigalightSecondsInOneMeter => 3.33564e-18;
        protected override double TeralightSecondsInOneMeter => 3.33564e-21;

        protected override double MicroinchesInOneMeter => 39370078.74015748;


        protected override double MilsInOneMeter => 39370.07874015;

        protected override double MilesInOneMeter => 0.000621371;
        protected override double YardsInOneMeter => 1.09361;

        protected override double FathomsInOneMeter => 0.546806649;

        protected override double PrinterPicasInOneMeter => 237.10630158;
        protected override double PrinterPointsInOneMeter => 2845.2755906;

        protected override double ShacklesInOneMeter => 0.0364538;

        protected override double NauticalMilesInOneMeter => 1.0/1852.0;

        protected override double HandsInOneMeter => 9.8425196850393701;




        protected override double MicrolightYearsInOneMeter => 1.057e-10;
        protected override double MillilightYearsInOneMeter => 1.057e-13;
        protected override double LightYearsInOneMeter => 1.057e-16;
        protected override double DecalightYearsInOneMeter => 1.057e-17;
        protected override double KilolightYearsInOneMeter => 1.057e-19;
        protected override double MegalightYearsInOneMeter => 1.057e-22;
        protected override double GigalightYearsInOneMeter => 1.057e-25;
        protected override double TeralightYearsInOneMeter => 1.057e-28;
        protected override double PetalightYearsInOneMeter => 1.057e-31;
        protected override double ExalightYearsInOneMeter => 1.057e-34;
        protected override double ZettalightYearsInOneMeter => 1.057e-37;
        protected override double YottalightYearsInOneMeter => 1.057e-40;




        protected override double MicroaUsInOneMeter => 6.6844919e-6;
        protected override double MilliaUsInOneMeter => 6.6844919e-9;
        protected override double AUsInOneMeter => 6.6844919e-12;
        protected override double DecaaUsInOneMeter => 6.6844919e-13;
        protected override double KiloaUsInOneMeter => 6.6844919e-15;
        protected override double MegaaUsInOneMeter => 6.6844919e-18;
        protected override double GigaaUsInOneMeter => 6.6844919e-21;
        protected override double TeraaUsInOneMeter => 6.6844919e-24;


        protected override double MicrolightMinutesInOneMeter => 5.5586436909e-5;
        protected override double MillilightMinutesInOneMeter => 5.5586436909e-8;
        protected override double LightMinutesInOneMeter => 5.5586436909e-11;
        protected override double DecalightMinutesInOneMeter => 5.5586436909e-12;
        protected override double KilolightMinutesInOneMeter => 5.5586436909e-14;
        protected override double MegalightMinutesInOneMeter => 5.5586436909e-17;
        protected override double GigalightMinutesInOneMeter => 5.5586436909e-20;
        protected override double TeralightMinutesInOneMeter => 5.5586436909e-23;


        protected override double MicrolightHoursInOneMeter => 9.26784059e-7;
        protected override double MillilightHoursInOneMeter => 9.26784059e-10;
        protected override double LightHoursInOneMeter => 9.26784059e-13;
        protected override double DecalightHoursInOneMeter => 9.26784059e-14;
        protected override double KilolightHoursInOneMeter => 9.26784059e-16;
        protected override double MegalightHoursInOneMeter => 9.26784059e-19;
        protected override double GigalightHoursInOneMeter => 9.26784059e-22;
        protected override double TeralightHoursInOneMeter => 9.26784059e-25;


        protected override double MicrolightDaysInOneMeter => 3.8610038e-8;
        protected override double MillilightDaysInOneMeter => 3.8610038e-11;
        protected override double LightDaysInOneMeter => 3.8610038e-14;
        protected override double DecalightDaysInOneMeter => 3.8610038e-15;
        protected override double KilolightDaysInOneMeter => 3.8610038e-17;
        protected override double MegalightDaysInOneMeter => 3.8610038e-20;
        protected override double GigalightDaysInOneMeter => 3.8610038e-23;
        protected override double TeralightDaysInOneMeter => 3.8610038e-26;



        [ Fact]
        public void AreaTimesLengthEqualsVolume()
        {
            Volume volume = Area.FromSquareMeters(10)*Length.FromMeters(3);
            Assert.Equal(volume, Volume.FromCubicMeters(30));
        }

        [Fact]
        public void ForceTimesLengthEqualsTorque()
        {
            Torque torque = Force.FromNewtons(1)*Length.FromMeters(3);
            Assert.Equal(torque, Torque.FromNewtonMeters(3));
        }

        [Fact]
        public void LengthTimesAreaEqualsVolume()
        {
            Volume volume = Length.FromMeters(3)*Area.FromSquareMeters(9);
            Assert.Equal(volume, Volume.FromCubicMeters(27));
        }

        [Fact]
        public void LengthTimesForceEqualsTorque()
        {
            Torque torque = Length.FromMeters(3)*Force.FromNewtons(1);
            Assert.Equal(torque, Torque.FromNewtonMeters(3));
        }

        [Fact]
        public void LengthTimesLengthEqualsArea()
        {
            Area area = Length.FromMeters(10)*Length.FromMeters(2);
            Assert.Equal(area, Area.FromSquareMeters(20));
        }

        [Fact]
        public void LengthDividedBySpeedEqualsDuration()
        {
            Duration duration = Length.FromMeters(20) / Speed.FromMetersPerSecond(2);
            Assert.Equal(Duration.FromSeconds(10), duration);
        }

        [Fact]
        public void LengthTimesSpeedEqualsKinematicViscosity()
        {
            KinematicViscosity kinematicViscosity = Length.FromMeters(20) * Speed.FromMetersPerSecond(2);
            Assert.Equal(KinematicViscosity.FromSquareMetersPerSecond(40), kinematicViscosity);
        }

        [Fact]
        public void LengthTimesSpecificWeightEqualsPressure()
        {
            Pressure pressure = Length.FromMeters(2) * SpecificWeight.FromNewtonsPerCubicMeter(10);
            Assert.Equal(Pressure.FromPascals(20), pressure);
        }

        [Fact]
        public void ToStringReturnsCorrectNumberAndUnitWithDefaultUnitWhichIsMeter()
        {
            var meter = Length.FromMeters(5);
            string meterString = meter.ToString();
            Assert.Equal("5 m", meterString);
        }

        [Fact]
        public void ToStringReturnsCorrectNumberAndUnitWithCentimeterAsDefualtUnit()
        {
            var value = Length.From(2, LengthUnit.Centimeter);
            string valueString = value.ToString();
            Assert.Equal("2 cm", valueString);
        }

        [Fact]
        public void MaxValueIsCorrectForUnitWithBaseTypeDouble()
        {
            Assert.Equal(double.MaxValue, Length.MaxValue.Meters);
        }

        [Fact]
        public void MinValueIsCorrectForUnitWithBaseTypeDouble()
        {
            Assert.Equal(double.MinValue, Length.MinValue.Meters);
        }

        [Fact]
        public void NegativeLengthToStonePoundsReturnsCorrectValues()
        {
            var negativeLength = Length.FromInches(-1.0);
            var feetInches = negativeLength.FeetInches;

            Assert.Equal(0, feetInches.Feet);
            Assert.Equal(-1.0, feetInches.Inches);

            negativeLength = Length.FromInches(-25.0);
            feetInches = negativeLength.FeetInches;

            Assert.Equal(-2.0, feetInches.Feet);
            Assert.Equal(-1.0, feetInches.Inches);
        }

        [Fact]
        public void Constructor_UnitSystemNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Length(1.0, (UnitSystem)null));
        }

        [Fact]
        public void Constructor_UnitSystemSI_AssignsSIUnit()
        {
            var length = new Length(1.0, UnitSystem.SI);
            Assert.Equal(LengthUnit.Meter, length.Unit);
        }

        [Fact]
        public void Constructor_UnitSystemWithNoMatchingBaseUnits_ThrowsArgumentException()
        {
            // AmplitudeRatio is unitless. Can't have any matches :)
            Assert.Throws<ArgumentException>(() => new AmplitudeRatio(1.0, UnitSystem.SI));
        }

        [Fact]
        public void As_GivenSIUnitSystem_ReturnsSIValue()
        {
            var inches = new Length(2.0, LengthUnit.Inch);
            Assert.Equal(0.0508, inches.As(UnitSystem.SI));
        }

        [Fact]
        public void ToUnit_GivenSIUnitSystem_ReturnsSIQuantity()
        {
            var inches = new Length(2.0, LengthUnit.Inch);

            var inSI = inches.ToUnit(UnitSystem.SI);

            Assert.Equal(0.0508, inSI.Value);
            Assert.Equal(LengthUnit.Meter, inSI.Unit);
        }

        [Fact]
        public void EarlyAccessLengthObjects()
        {
            LengthUnit b = Length.BaseUnit;
            Length l = new Length(-1, b);
            Length expected = new Length(-1, Length.BaseUnit);
            Assert.Equal(expected, l);
            Assert.Equal(Length.BaseUnit, b);
        }
    }
}
