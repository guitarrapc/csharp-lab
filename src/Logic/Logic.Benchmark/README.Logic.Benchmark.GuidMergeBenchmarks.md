```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(0654(...)3f89) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (0654(...)3f89) [76] |  0.0007 ns | 0.0224 ns | 0.0012 ns |  0.0000 ns |  0.0000 ns |  0.0021 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(3d54(...)e51b) [76]** | **48.2656 ns** | **5.0982 ns** | **0.2795 ns** | **48.2897 ns** | **47.9749 ns** | **48.5323 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (3d54(...)e51b) [76] | 43.1355 ns | 5.4334 ns | 0.2978 ns | 43.0056 ns | 42.9248 ns | 43.4763 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(b77f(...)d7fb) [76]** | **35.1730 ns** | **2.3345 ns** | **0.1280 ns** | **35.1383 ns** | **35.0660 ns** | **35.3147 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (b77f(...)d7fb) [76] | 33.8072 ns | 5.5366 ns | 0.3035 ns | 33.6411 ns | 33.6231 ns | 34.1575 ns | 0.0048 |      80 B |
