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
| **SlowMerge** | **.NET 8.0** | **(6d0a(...)6842) [76]** | **33.3061 ns** | **4.9803 ns** | **0.2730 ns** | **33.2384 ns** | **33.0733 ns** | **33.6066 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (6d0a(...)6842) [76] | 32.1531 ns | 4.6237 ns | 0.2534 ns | 32.0769 ns | 31.9466 ns | 32.4360 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(9f0c(...)8e1d) [76]** | **45.1432 ns** | **6.9187 ns** | **0.3792 ns** | **44.9371 ns** | **44.9116 ns** | **45.5809 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (9f0c(...)8e1d) [76] | 38.4415 ns | 4.9055 ns | 0.2689 ns | 38.4825 ns | 38.1545 ns | 38.6876 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(fde6(...)72c2) [76]** |  **0.0032 ns** | **0.0508 ns** | **0.0028 ns** |  **0.0047 ns** |  **0.0000 ns** |  **0.0049 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (fde6(...)72c2) [76] |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |  0.0000 ns |      - |         - |
