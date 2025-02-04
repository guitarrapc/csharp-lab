```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(666a(...)692e) [76]** | **39.8310 ns** |  **2.1218 ns** | **0.1163 ns** | **39.6974 ns** | **39.9101 ns** | **0.0086** |     **144 B** |
| **FastMerge** | **(940c(...)fdfa) [76]** |  **0.0000 ns** |  **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| **SlowMerge** | **(d6d0(...)4d76) [76]** | **33.3015 ns** | **11.0958 ns** | **0.6082 ns** | **32.7731 ns** | **33.9663 ns** | **0.0048** |      **80 B** |
