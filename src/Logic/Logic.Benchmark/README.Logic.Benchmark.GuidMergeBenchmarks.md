```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **.NET 8.0** | **(0c33(...)1a70) [76]** | **32.3190 ns** | **4.0659 ns** | **0.2229 ns** | **32.2481 ns** | **32.1401 ns** | **32.5686 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (0c33(...)1a70) [76] | 32.0247 ns | 9.9137 ns | 0.5434 ns | 31.9074 ns | 31.5496 ns | 32.6172 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(b5db(...)fd3c) [76]** | **43.6575 ns** | **6.1897 ns** | **0.3393 ns** | **43.5581 ns** | **43.3790 ns** | **44.0354 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (b5db(...)fd3c) [76] | 39.4504 ns | 5.9118 ns | 0.3240 ns | 39.5060 ns | 39.1021 ns | 39.7430 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(c286(...)c9af) [76]** |  **0.0036 ns** | **0.0361 ns** | **0.0020 ns** |  **0.0043 ns** |  **0.0013 ns** |  **0.0051 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (c286(...)c9af) [76] |  0.0163 ns | 0.4410 ns | 0.0242 ns |  0.0045 ns |  0.0003 ns |  0.0441 ns |      - |         - |
