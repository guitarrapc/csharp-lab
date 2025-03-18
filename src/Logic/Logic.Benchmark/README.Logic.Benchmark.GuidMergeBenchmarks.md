```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(62b7(...)5537) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (62b7(...)5537) [76] |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(7576(...)7e47) [76]** | **43.9847 ns** | **4.9628 ns** | **0.2720 ns** | **43.7797 ns** | **44.2933 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (7576(...)7e47) [76] | 39.4468 ns | 1.1760 ns | 0.0645 ns | 39.3920 ns | 39.5178 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(8af1(...)18e5) [76]** | **32.5295 ns** | **3.5464 ns** | **0.1944 ns** | **32.3729 ns** | **32.7471 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (8af1(...)18e5) [76] | 31.9019 ns | 5.2764 ns | 0.2892 ns | 31.6614 ns | 32.2228 ns | 0.0048 |      80 B |
