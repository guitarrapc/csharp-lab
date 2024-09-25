```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(7844(...)b9c2) [76]** | **47.1514 ns** | **4.0821 ns** | **0.2238 ns** | **46.8991 ns** | **47.3257 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(80fe(...)4653) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| **SlowMerge** | **(c974(...)23c8) [76]** | **34.3149 ns** | **3.1434 ns** | **0.1723 ns** | **34.1919 ns** | **34.5119 ns** | **0.0010** |      **80 B** |
