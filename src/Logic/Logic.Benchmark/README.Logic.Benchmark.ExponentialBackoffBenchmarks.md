```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **11.97 ms** | **0.361 ms** | **0.020 ms** |  **11.95 ms** |  **11.99 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **754.08 ms** | **5.069 ms** | **0.278 ms** | **753.90 ms** | **754.40 ms** |    **4120 B** |
