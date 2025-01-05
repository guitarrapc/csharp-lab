```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(1728(...)9562) [76]** | **38.8876 ns** | **3.8619 ns** | **0.2117 ns** | **38.9433 ns** | **38.6536 ns** | **39.0658 ns** | **0.0086** |     **144 B** |
| **FastMerge** | **(302b(...)d587) [76]** |  **0.0044 ns** | **0.1403 ns** | **0.0077 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0133 ns** |      **-** |         **-** |
| **SlowMerge** | **(94bc(...)5dd3) [76]** | **31.9004 ns** | **6.9610 ns** | **0.3816 ns** | **31.7760 ns** | **31.5966 ns** | **32.3286 ns** | **0.0048** |      **80 B** |
