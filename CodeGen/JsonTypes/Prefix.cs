namespace CodeGen.JsonTypes
{
    internal enum Prefix
    {
        // SI prefixes
        Femto,
        Pico,
        Nano,
        Micro,
        Milli,
        Centi,
        Deci,
        Deca,
        Hecto,
        Kilo,
        Mega,
        Giga,
        Tera,
        Peta,
        Exa,
        Zetta,
        Yotta,
        Qutra, // Non-SI 10^27 - larger units for cosmic distances
        Vetta, // Non-SI 10^30 - larger units for cosmic distances

        // Binary prefixes
        Kibi,
        Mebi,
        Gibi,
        Tebi,
        Pebi,
        Exbi
    }
}
