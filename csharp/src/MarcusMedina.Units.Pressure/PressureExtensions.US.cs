namespace MarcusMedina.Units.Pressure.US;

/// <summary>
/// Amerikanska tryckenhetera.
/// <code>
/// 14.696.Psi().ToAtm()   // ≈ 1.0
/// 1.Psi().ToKilopascals() // ≈ 6.895
/// </code>
/// </summary>
public static class USPressureExtensions
{
    /// <summary>1 PSI (pound per square inch) = 6894.757293168 Pa</summary>
    public static Pressure Psi(this int v) => new(v * 6894.757293168);
    public static Pressure Psi(this double v) => new(v * 6894.757293168);

    /// <summary>1 PSF (pound per square foot) = 47.88025898034 Pa</summary>
    public static Pressure Psf(this int v) => new(v * 47.88025898034);
    public static Pressure Psf(this double v) => new(v * 47.88025898034);

    /// <summary>1 KSI (kilopound per square inch) = 6 894 757.293 Pa</summary>
    public static Pressure Ksi(this int v) => new(v * 6_894_757.293);
    public static Pressure Ksi(this double v) => new(v * 6_894_757.293);

    public static double ToPsi(this Pressure p) => p.Pascals / 6894.757293168;
    public static double ToPsf(this Pressure p) => p.Pascals / 47.88025898034;
    public static double ToKsi(this Pressure p) => p.Pascals / 6_894_757.293;
}
