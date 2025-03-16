```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(447c(...)3ead) [76]** |  **0.0070 ns** | **0.1275 ns** | **0.0070 ns** |  **0.0070 ns** |  **0.0000 ns** |  **0.0140 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (447c(...)3ead) [76] |  0.0022 ns | 0.0688 ns | 0.0038 ns |  0.0000 ns |  0.0000 ns |  0.0065 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(4825(...)1568) [76]** | **42.7993 ns** | **3.4953 ns** | **0.1916 ns** | **42.7150 ns** | **42.6644 ns** | **43.0186 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (4825(...)1568) [76] | 38.7320 ns | 8.2809 ns | 0.4539 ns | 38.6391 ns | 38.3318 ns | 39.2252 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(baae(...)af58) [76]** | **31.6402 ns** | **5.6944 ns** | **0.3121 ns** | **31.5234 ns** | **31.4033 ns** | **31.9939 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (baae(...)af58) [76] | 31.5190 ns | 2.2988 ns | 0.1260 ns | 31.5003 ns | 31.4034 ns | 31.6533 ns | 0.0048 |      80 B |
