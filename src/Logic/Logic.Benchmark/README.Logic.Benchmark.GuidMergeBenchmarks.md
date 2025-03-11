```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(6461(...)0f06) [76]** |  **0.0000 ns** |  **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (6461(...)0f06) [76] |  0.0035 ns |  0.0784 ns | 0.0043 ns |  0.0020 ns |  0.0002 ns |  0.0084 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(78f8(...)465b) [76]** | **43.2881 ns** |  **1.9522 ns** | **0.1070 ns** | **43.3034 ns** | **43.1743 ns** | **43.3867 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (78f8(...)465b) [76] | 38.3799 ns | 19.4860 ns | 1.0681 ns | 37.7634 ns | 37.7630 ns | 39.6132 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(ac65(...)b7ba) [76]** | **31.9441 ns** |  **2.3421 ns** | **0.1284 ns** | **32.0054 ns** | **31.7965 ns** | **32.0303 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (ac65(...)b7ba) [76] | 31.4405 ns |  3.1460 ns | 0.1724 ns | 31.4122 ns | 31.2839 ns | 31.6253 ns | 0.0048 |      80 B |
