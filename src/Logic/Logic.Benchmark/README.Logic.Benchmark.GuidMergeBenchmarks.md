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
| **SlowMerge** | **.NET 8.0** | **(3ad4(...)118c) [76]** | **31.9840 ns** |  **4.6005 ns** | **0.2522 ns** | **31.8396 ns** | **31.8372 ns** | **32.2752 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (3ad4(...)118c) [76] | 32.0607 ns |  7.8812 ns | 0.4320 ns | 32.0156 ns | 31.6530 ns | 32.5134 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(6686(...)3abd) [76]** | **43.7061 ns** | **12.5494 ns** | **0.6879 ns** | **43.7004 ns** | **43.0210 ns** | **44.3968 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (6686(...)3abd) [76] | 39.1181 ns | 10.1519 ns | 0.5565 ns | 38.9910 ns | 38.6362 ns | 39.7271 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(ae47(...)92ce) [76]** |  **0.0006 ns** |  **0.0182 ns** | **0.0010 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0017 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (ae47(...)92ce) [76] |  0.0197 ns |  0.6218 ns | 0.0341 ns |  0.0000 ns |  0.0000 ns |  0.0590 ns |      - |         - |
