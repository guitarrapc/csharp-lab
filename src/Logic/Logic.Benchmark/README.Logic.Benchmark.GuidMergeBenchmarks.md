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
| **FairMerge** | **(7748(...)94c4) [76]** | **46.4799 ns** | **6.0080 ns** | **0.3293 ns** | **46.3036 ns** | **46.2763 ns** | **46.8598 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(9430(...)63ba) [76]** |  **0.0016 ns** | **0.0371 ns** | **0.0020 ns** |  **0.0010 ns** |  **0.0000 ns** |  **0.0039 ns** |      **-** |         **-** |
| **SlowMerge** | **(9704(...)2552) [76]** | **33.8928 ns** | **0.9445 ns** | **0.0518 ns** | **33.9008 ns** | **33.8375 ns** | **33.9401 ns** | **0.0010** |      **80 B** |
