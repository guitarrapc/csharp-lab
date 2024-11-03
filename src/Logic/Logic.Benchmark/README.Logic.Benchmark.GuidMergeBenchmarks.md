```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(1a9b(...)e614) [76]** | **33.8784 ns** | **2.3702 ns** | **0.1299 ns** | **33.7532 ns** | **34.0126 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(2714(...)b6d5) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| **FairMerge** | **(5bbb(...)5c70) [76]** | **46.6434 ns** | **2.7244 ns** | **0.1493 ns** | **46.5361 ns** | **46.8140 ns** | **0.0017** |     **144 B** |
