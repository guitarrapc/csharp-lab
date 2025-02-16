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
| **SlowMerge** | **.NET 8.0** | **(12a4(...)799d) [76]** | **32.2307 ns** |  **2.9900 ns** | **0.1639 ns** | **32.1864 ns** | **32.0935 ns** | **32.4122 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (12a4(...)799d) [76] | 31.9311 ns |  4.6939 ns | 0.2573 ns | 31.9660 ns | 31.6581 ns | 32.1691 ns | 0.0048 |      80 B |
| **FastMerge** | **.NET 8.0** | **(3691(...)63b6) [76]** |  **0.0043 ns** |  **0.0675 ns** | **0.0037 ns** |  **0.0061 ns** |  **0.0000 ns** |  **0.0067 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (3691(...)63b6) [76] |  0.0063 ns |  0.1126 ns | 0.0062 ns |  0.0066 ns |  0.0000 ns |  0.0123 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(6955(...)b6a3) [76]** | **55.1954 ns** |  **3.5073 ns** | **0.1922 ns** | **55.2563 ns** | **54.9800 ns** | **55.3497 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (6955(...)b6a3) [76] | 39.5954 ns | 10.9068 ns | 0.5978 ns | 39.5978 ns | 38.9963 ns | 40.1920 ns | 0.0086 |     144 B |
