```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **12.14 ms** |  **0.683 ms** | **0.037 ms** |  **12.10 ms** |  **12.17 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **754.08 ms** | **41.209 ms** | **2.259 ms** | **751.79 ms** | **756.31 ms** |    **4120 B** |
