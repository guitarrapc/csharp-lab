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
| **FastMerge** | **.NET 8.0** | **(17a2(...)5c4c) [76]** |  **0.0011 ns** |  **0.0336 ns** | **0.0018 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0032 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (17a2(...)5c4c) [76] |  0.0037 ns |  0.0594 ns | 0.0033 ns |  0.0028 ns |  0.0010 ns |  0.0074 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(2eef(...)2ec9) [76]** | **46.6652 ns** |  **1.5340 ns** | **0.0841 ns** | **46.6422 ns** | **46.5951 ns** | **46.7584 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (2eef(...)2ec9) [76] | 41.7864 ns |  3.8197 ns | 0.2094 ns | 41.9021 ns | 41.5447 ns | 41.9125 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(48e6(...)5a83) [76]** | **35.1200 ns** | **13.8911 ns** | **0.7614 ns** | **34.9493 ns** | **34.4585 ns** | **35.9523 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (48e6(...)5a83) [76] | 32.6278 ns |  2.8903 ns | 0.1584 ns | 32.5999 ns | 32.4852 ns | 32.7983 ns | 0.0048 |      80 B |
