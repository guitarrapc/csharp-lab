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
| **FastMerge** | **.NET 8.0** | **(3f35(...)0124) [76]** |  **0.0016 ns** |  **0.0496 ns** | **0.0027 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0047 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (3f35(...)0124) [76] |  0.0010 ns |  0.0255 ns | 0.0014 ns |  0.0005 ns |  0.0000 ns |  0.0026 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(471f(...)0442) [76]** | **44.1214 ns** |  **2.8461 ns** | **0.1560 ns** | **44.2102 ns** | **43.9412 ns** | **44.2127 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (471f(...)0442) [76] | 39.9396 ns | 20.8777 ns | 1.1444 ns | 40.4515 ns | 38.6287 ns | 40.7387 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(acaa(...)0e9e) [76]** | **32.7016 ns** |  **4.2604 ns** | **0.2335 ns** | **32.6021 ns** | **32.5343 ns** | **32.9684 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (acaa(...)0e9e) [76] | 33.3186 ns |  2.8534 ns | 0.1564 ns | 33.4077 ns | 33.1380 ns | 33.4100 ns | 0.0048 |      80 B |
