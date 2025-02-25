```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **.NET 8.0** | **(800a(...)51a2) [76]** | **43.6033 ns** | **5.4897 ns** | **0.3009 ns** | **43.2747 ns** | **43.8654 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (800a(...)51a2) [76] | 38.8564 ns | 4.0126 ns | 0.2199 ns | 38.6437 ns | 39.0829 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(ac84(...)37b2) [76]** |  **0.0043 ns** | **0.0124 ns** | **0.0007 ns** |  **0.0035 ns** |  **0.0048 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (ac84(...)37b2) [76] |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |      - |         - |
| **SlowMerge** | **.NET 8.0** | **(b931(...)d397) [76]** | **32.0843 ns** | **2.6624 ns** | **0.1459 ns** | **31.9188 ns** | **32.1946 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (b931(...)d397) [76] | 31.5537 ns | 3.1995 ns | 0.1754 ns | 31.3596 ns | 31.7007 ns | 0.0048 |      80 B |
