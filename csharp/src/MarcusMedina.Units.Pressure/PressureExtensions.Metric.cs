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
    extension(int v)
    {
        public Pressure Micropascals() => new(v * 0.000001);
        public Pressure Millipascals() => new(v * 0.001);
        public Pressure Pascals() => new(v);
        public Pressure Hectopascals() => new(v * 100.0);
        public Pressure Kilopascals() => new(v * 1_000.0);
        public Pressure Megapascals() => new(v * 1_000_000.0);
        public Pressure Gigapascals() => new(v * 1_000_000_000.0);
        /// <summary>1 bar = 100 000 Pa</summary>
        public Pressure Bar() => new(v * 100_000.0);
        /// <summary>1 millibar = 100 Pa</summary>
        public Pressure Millibar() => new(v * 100.0);
        /// <summary>1 microbar = 0.1 Pa</summary>
        public Pressure Microbar() => new(v * 0.1);
    }

    extension(double v)
    {
        public Pressure Micropascals() => new(v * 0.000001);
        public Pressure Millipascals() => new(v * 0.001);
        public Pressure Pascals() => new(v);
        public Pressure Hectopascals() => new(v * 100.0);
        public Pressure Kilopascals() => new(v * 1_000.0);
        public Pressure Megapascals() => new(v * 1_000_000.0);
        public Pressure Gigapascals() => new(v * 1_000_000_000.0);
        public Pressure Bar() => new(v * 100_000.0);
        public Pressure Millibar() => new(v * 100.0);
        public Pressure Microbar() => new(v * 0.1);
    }

    extension(Pressure p)
    {
        public double ToMicropascals() => p.Pascals / 0.000001;
        public double ToMillipascals() => p.Pascals / 0.001;
        public double ToPascals() => p.Pascals;
        public double ToHectopascals() => p.Pascals / 100.0;
        public double ToKilopascals() => p.Pascals / 1_000.0;
        public double ToMegapascals() => p.Pascals / 1_000_000.0;
        public double ToGigapascals() => p.Pascals / 1_000_000_000.0;
        public double ToBar() => p.Pascals / 100_000.0;
        public double ToMillibar() => p.Pascals / 100.0;
        public double ToMicrobar() => p.Pascals / 0.1;
    }
}
