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
| **FairMerge** | **(0bce(...)6a45) [76]** | **48.6429 ns** | **7.0559 ns** | **0.3868 ns** | **48.6200 ns** | **48.2681 ns** | **49.0406 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(43e1(...)78fa) [76]** |  **0.0014 ns** | **0.0182 ns** | **0.0010 ns** |  **0.0009 ns** |  **0.0008 ns** |  **0.0026 ns** |      **-** |         **-** |
| **SlowMerge** | **(8fa2(...)11b7) [76]** | **36.4351 ns** | **4.0085 ns** | **0.2197 ns** | **36.3773 ns** | **36.2500 ns** | **36.6779 ns** | **0.0010** |      **80 B** |
