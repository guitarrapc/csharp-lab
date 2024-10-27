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
| **FastMerge** | **(09c8(...)ad88) [76]** |  **0.0046 ns** | **0.0739 ns** | **0.0041 ns** |  **0.0059 ns** |  **0.0000 ns** |  **0.0078 ns** |      **-** |         **-** |
| **FairMerge** | **(8c78(...)aa8c) [76]** | **46.6790 ns** | **1.5696 ns** | **0.0860 ns** | **46.7106 ns** | **46.5816 ns** | **46.7447 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(d46a(...)2628) [76]** | **34.2444 ns** | **2.5843 ns** | **0.1417 ns** | **34.2522 ns** | **34.0990 ns** | **34.3820 ns** | **0.0010** |      **80 B** |
