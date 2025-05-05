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
| **SlowMerge** | **.NET 8.0** | **(233d(...)731c) [76]** | **34.7910 ns** | **0.5626 ns** | **0.0308 ns** | **34.8026 ns** | **34.7561 ns** | **34.8144 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (233d(...)731c) [76] | 33.5204 ns | 3.7513 ns | 0.2056 ns | 33.4405 ns | 33.3667 ns | 33.7540 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(4cf6(...)ec3a) [76]** | **46.8035 ns** | **5.3417 ns** | **0.2928 ns** | **46.8088 ns** | **46.5081 ns** | **47.0936 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (4cf6(...)ec3a) [76] | 41.9599 ns | 1.2448 ns | 0.0682 ns | 41.9444 ns | 41.9009 ns | 42.0346 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(cd0a(...)9f23) [76]** |  **0.0195 ns** | **0.5523 ns** | **0.0303 ns** |  **0.0042 ns** |  **0.0000 ns** |  **0.0544 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (cd0a(...)9f23) [76] |  0.0003 ns | 0.0094 ns | 0.0005 ns |  0.0000 ns |  0.0000 ns |  0.0009 ns |      - |         - |
