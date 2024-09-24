```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(7e2c(...)b2c2) [76]** | **34.6506 ns** | **0.8237 ns** | **0.0451 ns** | **34.6116 ns** | **34.7001 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(8dca(...)da67) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| **FairMerge** | **(a2af(...)b347) [76]** | **52.1461 ns** | **7.0560 ns** | **0.3868 ns** | **51.9123 ns** | **52.5925 ns** | **0.0017** |     **144 B** |
