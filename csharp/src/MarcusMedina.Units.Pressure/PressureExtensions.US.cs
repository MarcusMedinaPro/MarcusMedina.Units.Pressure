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
    extension(int v)
    {
        /// <summary>1 PSI (pound per square inch) = 6894.757293168 Pa</summary>
        public Pressure Psi() => new(v * 6894.757293168);
        /// <summary>1 PSF (pound per square foot) = 47.88025898034 Pa</summary>
        public Pressure Psf() => new(v * 47.88025898034);
        /// <summary>1 KSI (kilopound per square inch) = 6 894 757.293 Pa</summary>
        public Pressure Ksi() => new(v * 6_894_757.293);
    }

    extension(double v)
    {
        public Pressure Psi() => new(v * 6894.757293168);
        public Pressure Psf() => new(v * 47.88025898034);
        public Pressure Ksi() => new(v * 6_894_757.293);
    }

    extension(Pressure p)
    {
        public double ToPsi() => p.Pascals / 6894.757293168;
        public double ToPsf() => p.Pascals / 47.88025898034;
        public double ToKsi() => p.Pascals / 6_894_757.293;
    }
}
