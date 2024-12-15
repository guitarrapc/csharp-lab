```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(3363(...)b1f4) [76]** | **46.5210 ns** | **0.9085 ns** | **0.0498 ns** | **46.4650 ns** | **46.5605 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(5fa4(...)7660) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| **SlowMerge** | **(e460(...)b7ea) [76]** | **33.9979 ns** | **0.6889 ns** | **0.0378 ns** | **33.9581 ns** | **34.0332 ns** | **0.0010** |      **80 B** |
