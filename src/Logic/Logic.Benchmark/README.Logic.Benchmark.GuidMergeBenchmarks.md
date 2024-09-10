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
| **FastMerge** | **(2a4e(...)28fc) [76]** |  **0.0369 ns** | **1.1669 ns** | **0.0640 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.1108 ns** |      **-** |         **-** |
| **SlowMerge** | **(91aa(...)759d) [76]** | **34.3406 ns** | **5.6374 ns** | **0.3090 ns** | **34.3956 ns** | **34.0078 ns** | **34.6184 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(e240(...)71cb) [76]** | **47.1346 ns** | **6.1476 ns** | **0.3370 ns** | **46.9904 ns** | **46.8936 ns** | **47.5196 ns** | **0.0017** |     **144 B** |
