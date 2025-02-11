```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(0ed0(...)7c06) [76]** |  **0.0024 ns** | **0.0384 ns** | **0.0021 ns** |  **0.0034 ns** |  **0.0000 ns** |  **0.0038 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (0ed0(...)7c06) [76] |  0.0000 ns | 0.0014 ns | 0.0001 ns |  0.0000 ns |  0.0000 ns |  0.0001 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(b001(...)28df) [76]** | **44.0057 ns** | **2.7105 ns** | **0.1486 ns** | **44.0800 ns** | **43.8346 ns** | **44.1025 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (b001(...)28df) [76] | 38.7621 ns | 6.7132 ns | 0.3680 ns | 38.5746 ns | 38.5255 ns | 39.1860 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(c40f(...)f053) [76]** | **32.3887 ns** | **4.7977 ns** | **0.2630 ns** | **32.5312 ns** | **32.0853 ns** | **32.5497 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (c40f(...)f053) [76] | 31.8417 ns | 2.9509 ns | 0.1618 ns | 31.7695 ns | 31.7287 ns | 32.0270 ns | 0.0048 |      80 B |
