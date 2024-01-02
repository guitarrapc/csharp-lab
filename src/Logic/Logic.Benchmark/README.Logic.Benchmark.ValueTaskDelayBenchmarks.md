```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **12.29 ms** | **6.952 ms** | **0.381 ms** |  **12.01 ms** |  **12.72 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.13 ms | 0.311 ms | 0.017 ms |  10.11 ms |  10.14 ms |     192 B |
| **TaskDelay**      | **10**     | **124.63 ms** | **5.389 ms** | **0.295 ms** | **124.41 ms** | **124.97 ms** |    **2104 B** |
| ValueTaskDelay | 10     | 101.04 ms | 1.261 ms | 0.069 ms | 100.96 ms | 101.09 ms |     381 B |
