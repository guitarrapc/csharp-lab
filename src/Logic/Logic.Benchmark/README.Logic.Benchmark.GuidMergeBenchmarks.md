```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **(57ca(...)7797) [76]** |  **0.0012 ns** | **0.0394 ns** | **0.0022 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0037 ns** |      **-** |         **-** |
| **FairMerge** | **(99c8(...)dfcd) [76]** | **46.3181 ns** | **4.9757 ns** | **0.2727 ns** | **46.1881 ns** | **46.1347 ns** | **46.6315 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(ccd0(...)1d68) [76]** | **34.1224 ns** | **3.1271 ns** | **0.1714 ns** | **34.1667 ns** | **33.9331 ns** | **34.2672 ns** | **0.0010** |      **80 B** |
