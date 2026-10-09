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
    extension(int v)
    {
        /// <summary>1 standardatmosfär (atm) = 101 325 Pa (exakt)</summary>
        public Pressure Atm() => new(v * 101_325.0);
        /// <summary>1 Torr = 1 mmHg = 133.3223684 Pa</summary>
        public Pressure Torr() => new(v * 133.3223684);
        /// <summary>1 mmHg = 133.3223684 Pa</summary>
        public Pressure MmHg() => new(v * 133.3223684);
        /// <summary>1 cmH₂O = 98.0665 Pa</summary>
        public Pressure CmH2O() => new(v * 98.0665);
        /// <summary>1 inHg (tum kvicksilver) = 3386.388640341 Pa</summary>
        public Pressure InHg() => new(v * 3386.388640341);
        /// <summary>1 inH₂O (tum vatten) = 249.0889083 Pa</summary>
        public Pressure InH2O() => new(v * 249.0889083);
    }

    extension(double v)
    {
        public Pressure Atm() => new(v * 101_325.0);
        public Pressure Torr() => new(v * 133.3223684);
        public Pressure MmHg() => new(v * 133.3223684);
        public Pressure CmH2O() => new(v * 98.0665);
        public Pressure InHg() => new(v * 3386.388640341);
        public Pressure InH2O() => new(v * 249.0889083);
    }

    extension(Pressure p)
    {
        public double ToAtm() => p.Pascals / 101_325.0;
        public double ToTorr() => p.Pascals / 133.3223684;
        public double ToMmHg() => p.Pascals / 133.3223684;
        public double ToCmH2O() => p.Pascals / 98.0665;
        public double ToInHg() => p.Pascals / 3386.388640341;
        public double ToInH2O() => p.Pascals / 249.0889083;
    }
}
