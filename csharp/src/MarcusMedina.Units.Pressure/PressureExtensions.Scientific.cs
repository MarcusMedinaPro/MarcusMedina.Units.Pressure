namespace MarcusMedina.Units.Pressure.Scientific;

/// <summary>
/// Vetenskapliga och meteorologiska tryckenhetera.
/// <code>
/// 1.Atm().ToTorr()        // 760
/// 760.Torr().ToPascals()  // ≈ 101 325
/// </code>
/// </summary>
public static class ScientificPressureExtensions
{
    /// <summary>1 standardatmosfär (atm) = 101 325 Pa (exakt)</summary>
    public static Pressure Atm(this int v) => new(v * 101_325.0);
    public static Pressure Atm(this double v) => new(v * 101_325.0);

    /// <summary>1 Torr = 1 mmHg = 133.3223684 Pa</summary>
    public static Pressure Torr(this int v) => new(v * 133.3223684);
    public static Pressure Torr(this double v) => new(v * 133.3223684);

    /// <summary>1 mmHg = 133.3223684 Pa</summary>
    public static Pressure MmHg(this int v) => new(v * 133.3223684);
    public static Pressure MmHg(this double v) => new(v * 133.3223684);

    /// <summary>1 cmH₂O = 98.0665 Pa</summary>
    public static Pressure CmH2O(this int v) => new(v * 98.0665);
    public static Pressure CmH2O(this double v) => new(v * 98.0665);

    /// <summary>1 inHg (tum kvicksilver) = 3386.388640341 Pa</summary>
    public static Pressure InHg(this int v) => new(v * 3386.388640341);
    public static Pressure InHg(this double v) => new(v * 3386.388640341);

    /// <summary>1 inH₂O (tum vatten) = 249.0889083 Pa</summary>
    public static Pressure InH2O(this int v) => new(v * 249.0889083);
    public static Pressure InH2O(this double v) => new(v * 249.0889083);

    public static double ToAtm(this Pressure p) => p.Pascals / 101_325.0;
    public static double ToTorr(this Pressure p) => p.Pascals / 133.3223684;
    public static double ToMmHg(this Pressure p) => p.Pascals / 133.3223684;
    public static double ToCmH2O(this Pressure p) => p.Pascals / 98.0665;
    public static double ToInHg(this Pressure p) => p.Pascals / 3386.388640341;
    public static double ToInH2O(this Pressure p) => p.Pascals / 249.0889083;
}
