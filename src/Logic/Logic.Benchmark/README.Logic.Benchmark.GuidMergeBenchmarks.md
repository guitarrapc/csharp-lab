```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(7380(...)8c9d) [76]** | **34.0885 ns** | **4.5380 ns** | **0.2487 ns** | **34.0373 ns** | **33.8694 ns** | **34.3589 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(8802(...)2e51) [76]** |  **0.0005 ns** | **0.0123 ns** | **0.0007 ns** |  **0.0003 ns** |  **0.0000 ns** |  **0.0013 ns** |      **-** |         **-** |
| **FairMerge** | **(e286(...)0093) [76]** | **46.8786 ns** | **2.7582 ns** | **0.1512 ns** | **46.8959 ns** | **46.7195 ns** | **47.0204 ns** | **0.0017** |     **144 B** |
