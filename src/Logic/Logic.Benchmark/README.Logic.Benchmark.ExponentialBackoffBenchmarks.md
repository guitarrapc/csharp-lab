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
| **ExponentialBackoff** | **1**      |  **12.14 ms** |  **1.521 ms** | **0.083 ms** |  **12.05 ms** |  **12.19 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **753.14 ms** | **22.645 ms** | **1.241 ms** | **751.70 ms** | **753.86 ms** |    **4120 B** |
