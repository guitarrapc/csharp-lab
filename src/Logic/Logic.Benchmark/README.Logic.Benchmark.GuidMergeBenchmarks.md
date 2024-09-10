```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(80e2(...)5ca3) [76]** | **34.7700 ns** | **1.6807 ns** | **0.0921 ns** | **34.6733 ns** | **34.8568 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(c18e(...)93a6) [76]** | **47.8726 ns** | **0.9067 ns** | **0.0497 ns** | **47.8384 ns** | **47.9296 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(dd9d(...)dd77) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
