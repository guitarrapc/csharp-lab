```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(51c9(...)c323) [76]** | **46.7175 ns** | **4.0329 ns** | **0.2211 ns** | **46.6726 ns** | **46.5223 ns** | **46.9576 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(b7c0(...)31e6) [76]** | **34.0482 ns** | **2.7512 ns** | **0.1508 ns** | **34.0761 ns** | **33.8853 ns** | **34.1830 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(c7d0(...)62f5) [76]** |  **0.0011 ns** | **0.0332 ns** | **0.0018 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0032 ns** |      **-** |         **-** |
