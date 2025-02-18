```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **.NET 8.0** | **(45ef(...)1628) [76]** | **33.9974 ns** |  **3.6755 ns** | **0.2015 ns** | **33.8819 ns** | **33.8802 ns** | **34.2300 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (45ef(...)1628) [76] | 33.8184 ns | 16.4893 ns | 0.9038 ns | 33.5735 ns | 33.0623 ns | 34.8195 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(a72f(...)350f) [76]** | **43.0446 ns** |  **3.7398 ns** | **0.2050 ns** | **43.0266 ns** | **42.8492 ns** | **43.2580 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (a72f(...)350f) [76] | 39.1391 ns |  9.8230 ns | 0.5384 ns | 38.9296 ns | 38.7369 ns | 39.7508 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(dda3(...)70d1) [76]** |  **0.0002 ns** |  **0.0050 ns** | **0.0003 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0005 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (dda3(...)70d1) [76] |  0.0000 ns |  0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |  0.0000 ns |      - |         - |
