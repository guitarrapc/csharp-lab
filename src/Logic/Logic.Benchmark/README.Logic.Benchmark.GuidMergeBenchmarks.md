```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(1d0c(...)70ac) [76]** | **47.5628 ns** | **2.5316 ns** | **0.1388 ns** | **47.5456 ns** | **47.4334 ns** | **47.7094 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(b9a7(...)0574) [76]** | **34.2595 ns** | **2.4997 ns** | **0.1370 ns** | **34.2551 ns** | **34.1248 ns** | **34.3988 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(e0d1(...)81ab) [76]** |  **0.0011 ns** | **0.0355 ns** | **0.0019 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0034 ns** |      **-** |         **-** |
