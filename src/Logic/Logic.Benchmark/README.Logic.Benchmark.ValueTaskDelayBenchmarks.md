```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **12.24 ms** |  **0.108 ms** | **0.006 ms** |  **12.23 ms** |  **12.24 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.13 ms |  0.062 ms | 0.003 ms |  10.13 ms |  10.13 ms |     192 B |
| **TaskDelay**      | **10**     | **121.83 ms** | **41.217 ms** | **2.259 ms** | **119.25 ms** | **123.46 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.07 ms |  0.220 ms | 0.012 ms | 101.05 ms | 101.08 ms |     381 B |
