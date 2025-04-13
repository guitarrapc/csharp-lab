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
| **FastMerge** | **.NET 8.0** | **(3097(...)0c94) [76]** |  **0.0002 ns** | **0.0073 ns** | **0.0004 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0007 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (3097(...)0c94) [76] |  0.0043 ns | 0.1351 ns | 0.0074 ns |  0.0000 ns |  0.0000 ns |  0.0128 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(3f59(...)9827) [76]** | **41.9166 ns** | **5.5437 ns** | **0.3039 ns** | **42.0549 ns** | **41.5682 ns** | **42.1267 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (3f59(...)9827) [76] | 40.3977 ns | 9.8907 ns | 0.5421 ns | 40.3135 ns | 39.9026 ns | 40.9770 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(dc64(...)879f) [76]** | **31.4806 ns** | **2.8323 ns** | **0.1552 ns** | **31.4972 ns** | **31.3177 ns** | **31.6269 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (dc64(...)879f) [76] | 31.1380 ns | 6.0266 ns | 0.3303 ns | 31.0692 ns | 30.8475 ns | 31.4974 ns | 0.0048 |      80 B |
