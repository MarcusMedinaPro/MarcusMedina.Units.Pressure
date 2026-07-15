namespace MarcusMedina.Units.Pressure.Metric;

/// <summary>
/// Metriska tryckenhetera — SI-standard med Pascal som basenhet.
/// <code>
/// 1.Bar().ToKilopascals()    // 100
/// 1013.25.Millibars().ToBar() // ≈ 1.01325
/// </code>
/// </summary>
public static class MetricPressureExtensions
{
    public static Pressure Micropascals(this int v) => new(v * 0.000001);
    public static Pressure Micropascals(this double v) => new(v * 0.000001);
    public static Pressure Millipascals(this int v) => new(v * 0.001);
    public static Pressure Millipascals(this double v) => new(v * 0.001);
    public static Pressure Pascals(this int v) => new(v);
    public static Pressure Pascals(this double v) => new(v);
    public static Pressure Hectopascals(this int v) => new(v * 100.0);
    public static Pressure Hectopascals(this double v) => new(v * 100.0);
    public static Pressure Kilopascals(this int v) => new(v * 1_000.0);
    public static Pressure Kilopascals(this double v) => new(v * 1_000.0);
    public static Pressure Megapascals(this int v) => new(v * 1_000_000.0);
    public static Pressure Megapascals(this double v) => new(v * 1_000_000.0);
    public static Pressure Gigapascals(this int v) => new(v * 1_000_000_000.0);
    public static Pressure Gigapascals(this double v) => new(v * 1_000_000_000.0);

    /// <summary>1 bar = 100 000 Pa</summary>
    public static Pressure Bar(this int v) => new(v * 100_000.0);
    public static Pressure Bar(this double v) => new(v * 100_000.0);
    /// <summary>1 millibar = 100 Pa</summary>
    public static Pressure Millibar(this int v) => new(v * 100.0);
    public static Pressure Millibar(this double v) => new(v * 100.0);
    /// <summary>1 microbar = 0.1 Pa</summary>
    public static Pressure Microbar(this int v) => new(v * 0.1);
    public static Pressure Microbar(this double v) => new(v * 0.1);

    public static double ToMicropascals(this Pressure p) => p.Pascals / 0.000001;
    public static double ToMillipascals(this Pressure p) => p.Pascals / 0.001;
    public static double ToPascals(this Pressure p) => p.Pascals;
    public static double ToHectopascals(this Pressure p) => p.Pascals / 100.0;
    public static double ToKilopascals(this Pressure p) => p.Pascals / 1_000.0;
    public static double ToMegapascals(this Pressure p) => p.Pascals / 1_000_000.0;
    public static double ToGigapascals(this Pressure p) => p.Pascals / 1_000_000_000.0;
    public static double ToBar(this Pressure p) => p.Pascals / 100_000.0;
    public static double ToMillibar(this Pressure p) => p.Pascals / 100.0;
    public static double ToMicrobar(this Pressure p) => p.Pascals / 0.1;
}
