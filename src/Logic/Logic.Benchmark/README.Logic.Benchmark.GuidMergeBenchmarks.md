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
| **FastMerge** | **(29a0(...)d8fb) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| **FairMerge** | **(38c7(...)9893) [76]** | **49.6929 ns** | **0.3739 ns** | **0.0205 ns** | **49.6699 ns** | **49.7090 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(e08d(...)6081) [76]** | **38.6622 ns** | **1.6294 ns** | **0.0893 ns** | **38.5696 ns** | **38.7479 ns** | **0.0010** |      **80 B** |
