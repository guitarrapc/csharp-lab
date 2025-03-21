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
| **FairMerge** | **.NET 8.0** | **(7e0a(...)7b54) [76]** | **45.5001 ns** | **8.0727 ns** | **0.4425 ns** | **45.7443 ns** | **44.9893 ns** | **45.7667 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (7e0a(...)7b54) [76] | 40.4051 ns | 5.2970 ns | 0.2903 ns | 40.5534 ns | 40.0706 ns | 40.5914 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(c544(...)ca94) [76]** | **33.5152 ns** | **3.6972 ns** | **0.2027 ns** | **33.4201 ns** | **33.3776 ns** | **33.7479 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (c544(...)ca94) [76] | 33.0414 ns | 1.9915 ns | 0.1092 ns | 33.0757 ns | 32.9193 ns | 33.1293 ns | 0.0048 |      80 B |
| **FastMerge** | **.NET 8.0** | **(f066(...)d7bb) [76]** |  **0.0013 ns** | **0.0421 ns** | **0.0023 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0040 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (f066(...)d7bb) [76] |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |  0.0000 ns |      - |         - |
