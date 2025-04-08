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
| **SlowMerge** | **.NET 8.0** | **(2b97(...)69c2) [76]** | **31.8460 ns** | **0.7783 ns** | **0.0427 ns** | **31.8606 ns** | **31.7980 ns** | **31.8795 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (2b97(...)69c2) [76] | 31.4689 ns | 6.4103 ns | 0.3514 ns | 31.3563 ns | 31.1876 ns | 31.8627 ns | 0.0048 |      80 B |
| **FastMerge** | **.NET 8.0** | **(3d99(...)4842) [76]** |  **0.0015 ns** | **0.0484 ns** | **0.0027 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0046 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (3d99(...)4842) [76] |  0.0123 ns | 0.2293 ns | 0.0126 ns |  0.0117 ns |  0.0000 ns |  0.0251 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(9868(...)4395) [76]** | **44.2681 ns** | **1.1678 ns** | **0.0640 ns** | **44.2972 ns** | **44.1947 ns** | **44.3123 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (9868(...)4395) [76] | 38.4981 ns | 4.6642 ns | 0.2557 ns | 38.4125 ns | 38.2963 ns | 38.7856 ns | 0.0086 |     144 B |
