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
| **SlowMerge** | **.NET 8.0** | **(3b34(...)e66e) [76]** | **32.2251 ns** | **5.8982 ns** | **0.3233 ns** | **32.0411 ns** | **32.0358 ns** | **32.5984 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (3b34(...)e66e) [76] | 31.3516 ns | 3.3109 ns | 0.1815 ns | 31.3105 ns | 31.1942 ns | 31.5501 ns | 0.0048 |      80 B |
| **FastMerge** | **.NET 8.0** | **(8656(...)7b93) [76]** |  **0.0024 ns** | **0.0414 ns** | **0.0023 ns** |  **0.0027 ns** |  **0.0000 ns** |  **0.0045 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (8656(...)7b93) [76] |  0.0022 ns | 0.0623 ns | 0.0034 ns |  0.0005 ns |  0.0000 ns |  0.0062 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(fc22(...)4a82) [76]** | **44.2586 ns** | **9.1903 ns** | **0.5038 ns** | **44.0885 ns** | **43.8620 ns** | **44.8254 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (fc22(...)4a82) [76] | 39.1655 ns | 6.1089 ns | 0.3348 ns | 39.0161 ns | 38.9312 ns | 39.5490 ns | 0.0086 |     144 B |
