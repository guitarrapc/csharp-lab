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
| **FastMerge** | **(0e9b(...)3a0d) [76]** |  **0.0012 ns** | **0.0376 ns** | **0.0021 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0036 ns** |      **-** |         **-** |
| **SlowMerge** | **(8272(...)0d11) [76]** | **34.2018 ns** | **0.7042 ns** | **0.0386 ns** | **34.1897 ns** | **34.1708 ns** | **34.2451 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(a8a1(...)65f6) [76]** | **46.9966 ns** | **2.5318 ns** | **0.1388 ns** | **46.9821 ns** | **46.8656 ns** | **47.1421 ns** | **0.0017** |     **144 B** |
