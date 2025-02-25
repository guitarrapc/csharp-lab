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
| **FastMerge** | **.NET 8.0** | **(6291(...)7a90) [76]** |  **0.0099 ns** | **0.2998 ns** | **0.0164 ns** |  **0.0008 ns** |  **0.0000 ns** |  **0.0289 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (6291(...)7a90) [76] |  0.0035 ns | 0.0905 ns | 0.0050 ns |  0.0013 ns |  0.0000 ns |  0.0092 ns |      - |         - |
| **SlowMerge** | **.NET 8.0** | **(ce7c(...)ad0a) [76]** | **32.3502 ns** | **6.3982 ns** | **0.3507 ns** | **32.4178 ns** | **31.9706 ns** | **32.6622 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (ce7c(...)ad0a) [76] | 32.1107 ns | 2.4439 ns | 0.1340 ns | 32.0824 ns | 31.9931 ns | 32.2565 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(e807(...)6246) [76]** | **44.6563 ns** | **5.6347 ns** | **0.3089 ns** | **44.5700 ns** | **44.3997 ns** | **44.9991 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (e807(...)6246) [76] | 38.9337 ns | 5.2701 ns | 0.2889 ns | 39.0496 ns | 38.6049 ns | 39.1466 ns | 0.0086 |     144 B |
