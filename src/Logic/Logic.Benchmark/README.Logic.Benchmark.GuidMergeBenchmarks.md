```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **.NET 8.0** | **(0433(...)cdbd) [76]** | **31.8345 ns** | **4.8082 ns** | **0.2636 ns** | **31.6919 ns** | **31.6730 ns** | **32.1386 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (0433(...)cdbd) [76] | 31.4261 ns | 5.5094 ns | 0.3020 ns | 31.2883 ns | 31.2177 ns | 31.7724 ns | 0.0048 |      80 B |
| **FastMerge** | **.NET 8.0** | **(7899(...)5b23) [76]** |  **0.0221 ns** | **0.6050 ns** | **0.0332 ns** |  **0.0061 ns** |  **0.0000 ns** |  **0.0603 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (7899(...)5b23) [76] |  0.0017 ns | 0.0540 ns | 0.0030 ns |  0.0000 ns |  0.0000 ns |  0.0051 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(f8d4(...)8841) [76]** | **43.3096 ns** | **7.6808 ns** | **0.4210 ns** | **43.3562 ns** | **42.8672 ns** | **43.7054 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (f8d4(...)8841) [76] | 38.1912 ns | 1.5051 ns | 0.0825 ns | 38.1572 ns | 38.1311 ns | 38.2853 ns | 0.0086 |     144 B |
