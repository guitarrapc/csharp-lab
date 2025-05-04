```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **.NET 8.0** | **(a99e(...)bf09) [76]** | **33.9038 ns** |  **3.8786 ns** | **0.2126 ns** | **33.9538 ns** | **33.6707 ns** | **34.0870 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (a99e(...)bf09) [76] | 33.2624 ns |  3.6435 ns | 0.1997 ns | 33.3518 ns | 33.0336 ns | 33.4018 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(c46d(...)bbbe) [76]** | **46.2962 ns** |  **6.6804 ns** | **0.3662 ns** | **46.2694 ns** | **45.9441 ns** | **46.6750 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (c46d(...)bbbe) [76] | 40.7605 ns | 11.7956 ns | 0.6466 ns | 41.0708 ns | 40.0173 ns | 41.1934 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(dd07(...)71dc) [76]** |  **0.0062 ns** |  **0.0994 ns** | **0.0054 ns** |  **0.0084 ns** |  **0.0000 ns** |  **0.0102 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (dd07(...)71dc) [76] |  0.0000 ns |  0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |  0.0000 ns |      - |         - |
