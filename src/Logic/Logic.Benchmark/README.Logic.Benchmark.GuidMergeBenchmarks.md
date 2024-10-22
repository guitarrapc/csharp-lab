```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(0c3e(...)92f6) [76]** | **45.9212 ns** | **4.6454 ns** | **0.2546 ns** | **45.7294 ns** | **46.2100 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(6304(...)e01a) [76]** |  **0.1748 ns** | **0.0428 ns** | **0.0023 ns** |  **0.1724 ns** |  **0.1771 ns** |      **-** |         **-** |
| **SlowMerge** | **(c680(...)4b8b) [76]** | **33.9895 ns** | **6.0287 ns** | **0.3305 ns** | **33.7320 ns** | **34.3621 ns** | **0.0010** |      **80 B** |
