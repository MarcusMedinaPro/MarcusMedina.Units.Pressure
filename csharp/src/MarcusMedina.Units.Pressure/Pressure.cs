using System.Globalization;

namespace MarcusMedina.Units.Pressure;

/// <summary>
/// Representerar ett tryck med Pascal som basenhet.
/// Alla konverteringar sker genom att multiplicera/dividera Pascal-värdet.
/// </summary>
public readonly struct Pressure : IComparable<Pressure>, IEquatable<Pressure>
{
    /// <summary>Värdet i Pascal (basenhet).</summary>
    public double Pascals { get; }

    public Pressure(double pascals) { Pascals = pascals; }

    public int CompareTo(Pressure other) => Pascals.CompareTo(other.Pascals);
    public bool Equals(Pressure other) => Pascals.Equals(other.Pascals);
    public override bool Equals(object? obj) => obj is Pressure p && Equals(p);
    public override int GetHashCode() => HashCode.Combine(Pascals);
    public override string ToString() => $"{Pascals.ToString("G", CultureInfo.InvariantCulture)} Pa";

    public static bool operator ==(Pressure a, Pressure b) => a.Equals(b);
    public static bool operator !=(Pressure a, Pressure b) => !(a == b);
    public static bool operator <(Pressure a, Pressure b) => a.Pascals < b.Pascals;
    public static bool operator >(Pressure a, Pressure b) => a.Pascals > b.Pascals;
    public static bool operator <=(Pressure a, Pressure b) => a.Pascals <= b.Pascals;
    public static bool operator >=(Pressure a, Pressure b) => a.Pascals >= b.Pascals;
    public static Pressure operator +(Pressure a, Pressure b) => new(a.Pascals + b.Pascals);
    public static Pressure operator -(Pressure a, Pressure b) => new(a.Pascals - b.Pascals);
    public static Pressure operator *(Pressure p, double factor) => new(p.Pascals * factor);
    public static Pressure operator /(Pressure p, double divisor) => new(p.Pascals / divisor);
    public static double operator /(Pressure a, Pressure b) => a.Pascals / b.Pascals;
}
