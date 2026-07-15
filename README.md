# MarcusMedina.Units.Pressure

[![NuGet](https://img.shields.io/nuget/v/MarcusMedina.Units.Pressure.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Units.Pressure/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/MarcusMedina.Units.Pressure.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Units.Pressure/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=for-the-badge&logo=csharp&logoColor=white)](#)
[![.NET](https://img.shields.io/badge/.NET-10.0+-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)
[![Open Source](https://raw.githubusercontent.com/MarcusMedinaPro/MarcusMedina.Units.Pressure/main/assets/open-source.svg)](https://opensource.org)
[![Build](https://img.shields.io/github/actions/workflow/status/MarcusMedinaPro/MarcusMedina.Units.Pressure/release.yml?branch=main&label=Build&style=for-the-badge&logo=github)](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Pressure/actions)
[![Signed](https://img.shields.io/badge/Signed-Sigstore-green?style=for-the-badge&logo=linux)](https://docs.sigstore.dev)
[![Wiki](https://img.shields.io/badge/docs-wiki-blue?style=for-the-badge&logo=github)](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Pressure/wiki)

**Fluent pressure unit conversion for .NET 10+** — metric, scientific, and US customary units.

Convert between pascals, bar, psi, atmospheres and more with a strongly-typed `Pressure` struct — no more guessing which raw `double` means what.

> This one also came from students — physics, this time. I remembered sitting through pressure units myself back in upper-secondary school and understanding absolutely nothing. Years later I was the one explaining it, and the memory of my own confusion was still very much alive. Coding explains everything to me, so I coded and tested until I could actually explain the exercises to my students the next day.
>
> In this case, I wanted each unit conversion to be broken into the same small, obvious steps — the explanation I wished someone had coded up for me back then.

---

## Features

- ✅ **Metric** — µPa, mPa, Pa, hPa, kPa, MPa, GPa, bar, millibar, microbar
- ✅ **Scientific** — atmosphere, torr, mmHg, cmH₂O, inHg, inH₂O
- ✅ **US customary** — psi, psf, ksi
- ✅ **Strongly typed** — `Pressure` struct instead of a raw `double`, so units can't be mixed up by accident
- ✅ **Fluent API** — `14.7.Psi().ToBar()`
- ✅ **Comparable & arithmetic** — `+`, `-`, `*`, `/`, and full comparison operators
- ✅ **Zero dependencies** — pure .NET, no external packages

---

## Installation

```bash
dotnet add package MarcusMedina.Units.Pressure
```

**Requirements:** .NET 10.0+, C# 14.0+

---

## Quick Start

```csharp
using MarcusMedina.Units.Pressure.Metric;
using MarcusMedina.Units.Pressure.US;

// Create a Pressure from any supported unit
Pressure tire  = 32.Psi();
Pressure storm = 980.Hectopascals();

// Convert to whatever unit you need
double bar         = tire.ToBar();          // ≈ 2.21
double atmospheres = storm.ToAtm();         // ≈ 0.967

// Arithmetic works directly on Pressure values
Pressure total = tire + 1.Bar();

// Comparisons
bool higher = tire > storm;
```

---

## API Overview

| Namespace | Unit family |
|-----------|-------------|
| `MarcusMedina.Units.Pressure.Metric` | µPa, mPa, Pa, hPa, kPa, MPa, GPa, bar, millibar, microbar |
| `MarcusMedina.Units.Pressure.Scientific` | atmosphere, torr, mmHg, cmH₂O, inHg, inH₂O |
| `MarcusMedina.Units.Pressure.US` | psi, psf, ksi |

Every unit exposes a creation extension (`1.Bar()`) and a conversion extension
(`pressure.ToBar()`). The `Pressure` struct itself always stores the value in pascals,
so mixing units in the same expression is always safe.

---

## Testing

```bash
cd csharp
dotnet test --configuration Release
```

Tests: **12 passed** — covering all unit families, arithmetic operators, and edge cases.

---

## License

MIT — see [LICENSE](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Pressure/blob/main/LICENSE) for details.

---

## Built with Human + AI Collaboration

This library was written by **Marcus Medina** together with **Claude Code** (Anthropic) — not through "vibe coding" where you just describe and accept, but through genuine collaboration: planning together, reviewing each other's decisions, pushing back when something felt wrong, and iterating until the result felt right.

The goal was always to write code worth reading and code worth using — the kind a student can open, understand, and learn from, and the kind any programmer can drop into real, professional work without wanting to rewrite it from scratch. AI was a partner in that process, not a shortcut around it.

If you're curious about this way of working, the source code and git history are open. Every decision has a reason behind it.

## Made for Curious Minds

This library was built with students in mind — not as a black box to copy and paste, but as a real-world example of how clean, purposeful code is written and shared.

Whether you're discovering C# for the first time, need a reliable helper for your school project, or are simply trying to fall in love with writing code — you're exactly who this was made for.

The source is open. Read it, fork it, break it, improve it. That's the whole point.

And if this library saved you an afternoon, or made something click that didn't before — that's everything.

*Non-students are equally welcome. Good code doesn't care about your diploma.*

⭐ If this helped you, consider starring the project on GitHub — it helps other students find it too.

💬 Have an idea, a feature request, or just want to say hi? Open an issue on GitHub — I'd love to hear from you.

## Package Integrity

All releases are signed with [cosign](https://docs.sigstore.dev) (Sigstore keyless signing).

To verify a downloaded package, download both the `.nupkg` and its `.sigstore.json` bundle from the [GitHub Release](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Pressure/releases), then run:

```bash
cosign verify-blob <package.nupkg> \
  --bundle <package.nupkg.sigstore.json> \
  --certificate-identity-regexp "https://github.com/MarcusMedinaPro/.*/release.yml" \
  --certificate-oidc-issuer https://token.actions.githubusercontent.com
```

Expected output: `Verified OK`

## Related Projects

- [MarcusMedina.Units.Area](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Area) — Fluent area unit conversion
- [MarcusMedina.Units.Volume](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Volume) — Fluent volume unit conversion
- [MarcusMedina.Units.Weight](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Weight) — Fluent weight unit conversion
- [MarcusMedina.Units.Math](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Math) — Unit-aware mathematical operations
- [MarcusMedina.Maths.Algebra](https://github.com/MarcusMedinaPro/MarcusMedina.Maths.Algebra) — Algebraic expressions and symbolic math
