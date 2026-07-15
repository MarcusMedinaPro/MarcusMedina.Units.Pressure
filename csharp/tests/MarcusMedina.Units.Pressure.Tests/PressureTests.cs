using FluentAssertions;
using MarcusMedina.Units.Pressure.Metric;
using MarcusMedina.Units.Pressure.US;
using MarcusMedina.Units.Pressure.Scientific;
using Xunit;

namespace MarcusMedina.Units.Pressure.Tests;

public class MetricPressureTests
{
    [Fact]
    public void OnePascal_ToPascals_IsOne()
        => 1.Pascals().ToPascals().Should().BeApproximately(1, 0.0001);

    [Fact]
    public void OneBar_ToKilopascals_Is100()
        => 1.Bar().ToKilopascals().Should().BeApproximately(100, 0.0001);

    [Fact]
    public void OneBar_ToMillibar_Is1000()
        => 1.Bar().ToMillibar().Should().BeApproximately(1000, 0.0001);

    [Fact]
    public void OneHectopascal_ToPascals_Is100()
        => 1.Hectopascals().ToPascals().Should().BeApproximately(100, 0.0001);

    [Fact]
    public void RoundTrip_Bar()
        => 2.5.Bar().ToBar().Should().BeApproximately(2.5, 0.0001);
}

public class USPressureTests
{
    [Fact]
    public void OnePsi_ToPascals_Is6894()
        => 1.Psi().ToPascals().Should().BeApproximately(6894.757, 0.001);

    [Fact]
    public void RoundTrip_Psi()
        => 14.7.Psi().ToPsi().Should().BeApproximately(14.7, 0.0001);
}

public class ScientificPressureTests
{
    [Fact]
    public void OneAtm_ToPascals_Is101325()
        => 1.Atm().ToPascals().Should().BeApproximately(101_325, 0.001);

    [Fact]
    public void OneAtm_ToTorr_Is760()
        => 1.Atm().ToTorr().Should().BeApproximately(760, 0.001);

    [Fact]
    public void SevenSixtyTorr_ToPascals_Is101325()
        => 760.Torr().ToPascals().Should().BeApproximately(101_325, 1);

    [Fact]
    public void StandardPressure_PsiEquivalent()
        => 14.696.Psi().ToAtm().Should().BeApproximately(1.0, 0.001);

    [Fact]
    public void RoundTrip_Atm()
        => 1.5.Atm().ToAtm().Should().BeApproximately(1.5, 0.0001);
}
