```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(2b8a(...)60a7) [76]** |  **0.0054 ns** | **0.0927 ns** | **0.0051 ns** |  **0.0063 ns** |  **0.0000 ns** |  **0.0101 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (2b8a(...)60a7) [76] |  0.0006 ns | 0.0203 ns | 0.0011 ns |  0.0000 ns |  0.0000 ns |  0.0019 ns |      - |         - |
| **SlowMerge** | **.NET 8.0** | **(6482(...)7909) [76]** | **31.7772 ns** | **4.1135 ns** | **0.2255 ns** | **31.7004 ns** | **31.6002 ns** | **32.0311 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (6482(...)7909) [76] | 31.3423 ns | 3.2348 ns | 0.1773 ns | 31.3976 ns | 31.1439 ns | 31.4854 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(83c6(...)bd88) [76]** | **42.9206 ns** | **2.4743 ns** | **0.1356 ns** | **42.9749 ns** | **42.7662 ns** | **43.0206 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (83c6(...)bd88) [76] | 38.2551 ns | 2.9310 ns | 0.1607 ns | 38.1881 ns | 38.1387 ns | 38.4384 ns | 0.0086 |     144 B |
