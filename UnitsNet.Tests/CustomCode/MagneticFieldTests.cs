﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make
//     it easier to remember to implement all the unit conversion test cases.
//
//     Whenever a new unit is added to this quantity and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.


using System;

namespace UnitsNet.Tests.CustomCode
{
    public class MagneticFieldTests : MagneticFieldTestsBase
    {
        protected override double TeslasInOneTesla => 1;
        protected override double NanoteslasInOneTesla => 1e9;
        protected override double MicroteslasInOneTesla => 1e6;
        protected override double MilliteslasInOneTesla => 1e3;

        protected override double DecateslasInOneTesla => 1e-1;

        protected override double GigateslasInOneTesla => 1e-9;

        protected override double KiloteslasInOneTesla => 1e-3;

        protected override double MegateslasInOneTesla => 1e-6;

        protected override double TerateslasInOneTesla => 1e-12;
    }
}
