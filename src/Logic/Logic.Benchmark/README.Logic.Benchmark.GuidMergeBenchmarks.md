```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(4611(...)bf86) [76]** |  **0.0017 ns** | **0.0326 ns** | **0.0018 ns** |  **0.0000 ns** |  **0.0036 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (4611(...)bf86) [76] |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |      - |         - |
| **SlowMerge** | **.NET 8.0** | **(7a41(...)faa5) [76]** | **31.9652 ns** | **3.7582 ns** | **0.2060 ns** | **31.8211 ns** | **32.2012 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (7a41(...)faa5) [76] | 31.5714 ns | 3.7852 ns | 0.2075 ns | 31.3496 ns | 31.7607 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(bdbb(...)3e17) [76]** | **43.2597 ns** | **1.9143 ns** | **0.1049 ns** | **43.1936 ns** | **43.3807 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (bdbb(...)3e17) [76] | 39.0571 ns | 6.3075 ns | 0.3457 ns | 38.7469 ns | 39.4298 ns | 0.0086 |     144 B |
