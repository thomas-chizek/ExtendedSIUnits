// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    /// The QuantityFormatter class is responsible for formatting a quantity using the given format string.
    /// </summary>
    public class QuantityFormatter
    {
        /// <summary>
        /// Formats the given quantity using the given format string and format provider.
        /// </summary>
        /// <typeparam name="TUnitType">The quantity's unit type, for example <see cref="LengthUnit"/>.</typeparam>
        /// <param name="quantity">The quantity to format.</param>
        /// <param name="format">The format string.</param>
        /// <param name="formatProvider">The format provider to use for localization and number formatting. Defaults to
        /// <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <remarks>
        /// The valid format strings are as follows:
        /// "g": The value with 2 significant digits after the radix followed by the unit abbreviation, such as "1.23 m".
        /// "a": The default unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />, such as "m".
        /// "a0", "a1", ..., "aN": The Nth unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />. "a0" is the same as "a".
        /// A <see cref="FormatException"/> will be thrown if the requested abbreviation index does not exist.
        /// "v": String representation of <see cref="IQuantity.Value" />.
        /// "u": The enum name of <see cref="IQuantity{TUnitType}.Unit" />, such as "Meter".
        /// "q": The quantity name, such as "Length".
        /// "s1", "s2", ..., "sN": The value with N significant digits after the radix followed by the unit abbreviation. For example,
        /// "s4" would return "1.2345 m" if <see cref="IQuantity.Value" /> is 1.2345678. Trailing zeros are omitted.
        /// </remarks>
        /// <returns>The string representation.</returns>
        public static string Format<TUnitType>(IQuantity<TUnitType> quantity, string format, IFormatProvider formatProvider)
            where TUnitType : Enum
        {
            formatProvider = formatProvider ?? CultureInfo.CurrentUICulture;

            var number = 0;

            if(string.IsNullOrEmpty(format))
                format = "g";

            // as far as the .Net formatter is concerned upper and lower case formats do the same thing
            // do make this formatter as case agnostic as we can.
            var formatString = format.ToLower();

            if (formatString.Length > 1 && !int.TryParse(formatString.Substring(1), out number))
                throw new FormatException($"The {format} format string is not supported.");

            formatString = formatString.Substring(0, 1);


            switch (formatString)
            {
                case "c":
                case "d":
                case "f":
                case "n":
                case "p":
                case "s":
                case "g":
                    // Only set the format digits Number of digits for numeric values.
                    if (number == 0 && formatProvider is CultureInfo)
                    {
                        CultureInfo culture = (CultureInfo)formatProvider;
                        number = culture.NumberFormat.NumberDecimalDigits;
                    }

                    return ToStringWithSignificantDigitsAfterRadix(quantity, formatProvider, number);
                case "a":
                    var abbreviations = UnitAbbreviationsCache.Default.GetUnitAbbreviations(quantity.Unit, formatProvider);

                    if(number >= abbreviations.Length)
                        throw new FormatException($"The {format} format string is invalid because the abbreviation index does not exist.");

                    return abbreviations[number];
                case "v":
                    // Only set the format digits Number of digits for numeric values.
                    //if (number == 0 && formatProvider is CultureInfo)
                    //{
                    //    CultureInfo culture = (CultureInfo)formatProvider;
                    //    number = culture.NumberFormat.NumberDecimalDigits;
                    //}

                    return quantity.Value.ToString($"g{number}", formatProvider);
                case "u":
                    return quantity.Unit.ToString();
                case "q":
                    return quantity.QuantityInfo.Name;
                default:
                    throw new FormatException($"The {format} format string is not supported.");
            }
        }

        private static string ToStringWithSignificantDigitsAfterRadix<TUnitType>(IQuantity<TUnitType> quantity, IFormatProvider formatProvider, int number) where TUnitType : Enum
        {
            string formatForSignificantDigits = UnitFormatter.GetFormat(quantity.Value, number);
            object[] formatArgs = UnitFormatter.GetFormatArgs(quantity.Unit, quantity.Value, formatProvider, Enumerable.Empty<object>());
            return string.Format(formatProvider, formatForSignificantDigits, formatArgs);
        }
    }
}
