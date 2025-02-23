```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **.NET 8.0** | **(3e26(...)a490) [76]** | **52.3427 ns** | **17.1654 ns** | **0.9409 ns** | **51.4655 ns** | **53.3364 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (3e26(...)a490) [76] | 45.5498 ns |  7.0069 ns | 0.3841 ns | 45.1853 ns | 45.9509 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(4ff8(...)0ce8) [76]** |  **0.0070 ns** |  **0.0079 ns** | **0.0004 ns** |  **0.0066 ns** |  **0.0074 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (4ff8(...)0ce8) [76] |  0.0000 ns |  0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |      - |         - |
| **SlowMerge** | **.NET 8.0** | **(6196(...)494f) [76]** | **36.1703 ns** |  **5.3248 ns** | **0.2919 ns** | **35.8424 ns** | **36.4016 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (6196(...)494f) [76] | 36.3168 ns |  5.7562 ns | 0.3155 ns | 36.0526 ns | 36.6661 ns | 0.0048 |      80 B |
