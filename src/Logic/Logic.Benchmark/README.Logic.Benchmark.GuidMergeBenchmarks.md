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
| **FastMerge** | **.NET 8.0** | **(571d(...)6eea) [76]** |  **0.0063 ns** | **0.1108 ns** | **0.0061 ns** |  **0.0000 ns** |  **0.0121 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (571d(...)6eea) [76] |  0.0007 ns | 0.0117 ns | 0.0006 ns |  0.0000 ns |  0.0013 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(5b6b(...)362c) [76]** | **47.2936 ns** | **2.4084 ns** | **0.1320 ns** | **47.1586 ns** | **47.4224 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (5b6b(...)362c) [76] | 41.1142 ns | 8.7385 ns | 0.4790 ns | 40.6541 ns | 41.6101 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(b0d1(...)6f28) [76]** | **32.6427 ns** | **9.0358 ns** | **0.4953 ns** | **32.3249 ns** | **33.2134 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (b0d1(...)6f28) [76] | 32.3246 ns | 1.1092 ns | 0.0608 ns | 32.2597 ns | 32.3802 ns | 0.0048 |      80 B |
