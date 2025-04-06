```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **.NET 8.0** | **(14f0(...)cce1) [76]** | **43.6520 ns** | **4.6497 ns** | **0.2549 ns** | **43.7973 ns** | **43.3578 ns** | **43.8011 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (14f0(...)cce1) [76] | 38.7922 ns | 3.7683 ns | 0.2066 ns | 38.8948 ns | 38.5544 ns | 38.9273 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(ab4e(...)2269) [76]** |  **0.0003 ns** | **0.0097 ns** | **0.0005 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0009 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (ab4e(...)2269) [76] |  0.0009 ns | 0.0290 ns | 0.0016 ns |  0.0000 ns |  0.0000 ns |  0.0028 ns |      - |         - |
| **SlowMerge** | **.NET 8.0** | **(f3f0(...)8995) [76]** | **32.3889 ns** | **5.7291 ns** | **0.3140 ns** | **32.3310 ns** | **32.1079 ns** | **32.7279 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (f3f0(...)8995) [76] | 31.5740 ns | 4.6981 ns | 0.2575 ns | 31.6789 ns | 31.2806 ns | 31.7625 ns | 0.0048 |      80 B |
