﻿using System;
using System.Collections.Generic;
using System.Linq;
using CodeGen.JsonTypes;

namespace CodeGen
{
    /// <summary>
    ///     Information about a unit prefix and a static dictionary to look up prefixes.
    /// </summary>
    internal class PrefixInfo
    {
        private const string Russian = "ru-RU";

        public static readonly IReadOnlyDictionary<Prefix, PrefixInfo> Entries = new[]
        {
            // Need to append 'd' suffix for double in order to later search/replace "d" with "m"
            // when creating decimal conversion functions in CodeGen.Generator.FixConversionFunctionsForDecimalValueTypes.

            // SI prefixes
            new PrefixInfo(Prefix.Yocto, "1e-24d", "y"),
            new PrefixInfo(Prefix.Zepto, "1e-21d", "z"),
            new PrefixInfo(Prefix.Atto, "1e-18d", "a", (Russian, "а")),
            new PrefixInfo(Prefix.Femto, "1e-15d", "f", (Russian, "ф")),
            new PrefixInfo(Prefix.Pico, "1e-12d", "p", (Russian, "п")),
            new PrefixInfo(Prefix.Nano, "1e-9d", "n", (Russian, "н")),
            new PrefixInfo(Prefix.Micro, "1e-6d", "µ", (Russian, "мк")),
            new PrefixInfo(Prefix.Milli, "1e-3d", "m", (Russian, "м")),
            new PrefixInfo(Prefix.Centi, "1e-2d", "c", (Russian, "с")),
            new PrefixInfo(Prefix.Deci, "1e-1d", "d", (Russian, "д")),
            new PrefixInfo(Prefix.Deca, "1e1d", "da", (Russian, "да")),
            new PrefixInfo(Prefix.Hecto, "1e2d", "h", (Russian, "г")),
            new PrefixInfo(Prefix.Kilo, "1e3d", "k", (Russian, "к")),
            new PrefixInfo(Prefix.Mega, "1e6d", "M", (Russian, "М")),
            new PrefixInfo(Prefix.Giga, "1e9d", "G", (Russian, "Г")),
            new PrefixInfo(Prefix.Tera, "1e12d", "T", (Russian, "Т")),
            new PrefixInfo(Prefix.Peta, "1e15d", "P", (Russian, "П")),
            new PrefixInfo(Prefix.Exa, "1e18d", "E", (Russian, "Э")),
            new PrefixInfo(Prefix.Zetta, "1e21d", "Z"),
            new PrefixInfo(Prefix.Yotta, "1e24d", "Y"),
            new PrefixInfo(Prefix.Qutra, "1e27d", "Q"),
            new PrefixInfo(Prefix.Vetta, "1e30d", "V"),

            // Binary prefixes
            new PrefixInfo(Prefix.Kibi, "1024d", "Ki"),
            new PrefixInfo(Prefix.Mebi, "(1024d * 1024)", "Mi"),
            new PrefixInfo(Prefix.Gibi, "(1024d * 1024 * 1024)", "Gi"),
            new PrefixInfo(Prefix.Tebi, "(1024d * 1024 * 1024 * 1024)", "Ti"),
            new PrefixInfo(Prefix.Pebi, "(1024d * 1024 * 1024 * 1024 * 1024)", "Pi"),
            new PrefixInfo(Prefix.Exbi, "(1024d * 1024 * 1024 * 1024 * 1024 * 1024)", "Ei")
        }.ToDictionary(prefixInfo => prefixInfo.Prefix);

        private PrefixInfo(Prefix prefix, string factor, string siPrefix, params (string cultureName, string prefix)[] cultureToPrefix)
        {
            Prefix = prefix;
            SiPrefix = siPrefix;
            CultureToPrefix = cultureToPrefix;
            Factor = factor;
        }

        /// <summary>
        ///     The unit prefix.
        /// </summary>
        public Prefix Prefix { get; }

        /// <summary>
        ///     C# expression for the multiplier to prefix the conversion function.
        /// </summary>
        /// <example>Kilo has "1e3" in order to multiply by 1000.</example>
        public string Factor { get; }

        /// <summary>
        ///     The unit prefix abbreviation, such as "k" for kilo or "m" for milli.
        /// </summary>
        private string SiPrefix { get; }

        /// <summary>
        ///     Mapping from culture name to localized prefix abbreviation.
        /// </summary>
        private (string cultureName, string prefix)[] CultureToPrefix { get; }

        /// <summary>
        ///     Gets the localized prefix if configured, otherwise <see cref="SiPrefix" />.
        /// </summary>
        /// <param name="cultureName">Culture name, such as "en-US" or "ru-RU".</param>
        public string GetPrefixForCultureOrSiPrefix(string cultureName)
        {
            if (cultureName == null) throw new ArgumentNullException(nameof(cultureName));

            var localizedPrefix = CultureToPrefix
                .Where(x => string.Equals(x.cultureName, cultureName, StringComparison.OrdinalIgnoreCase))
                .Select(x => x.prefix).FirstOrDefault();

            return localizedPrefix ?? SiPrefix;
        }
    }
}
