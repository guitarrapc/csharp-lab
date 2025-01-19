```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(4213(...)b07b) [76]** | **32.4769 ns** | **13.0624 ns** | **0.7160 ns** | **32.7743 ns** | **31.6601 ns** | **32.9963 ns** | **0.0048** |      **80 B** |
| **FairMerge** | **(67da(...)63f6) [76]** | **38.9581 ns** |  **9.3701 ns** | **0.5136 ns** | **38.6780 ns** | **38.6455 ns** | **39.5509 ns** | **0.0086** |     **144 B** |
| **FastMerge** | **(cf09(...)eb8a) [76]** |  **0.0068 ns** |  **0.2082 ns** | **0.0114 ns** |  **0.0003 ns** |  **0.0000 ns** |  **0.0199 ns** |      **-** |         **-** |
