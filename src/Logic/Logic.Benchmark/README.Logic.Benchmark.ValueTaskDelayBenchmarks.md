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
| **TaskDelay**      | **1**      |  **11.98 ms** | **0.552 ms** | **0.030 ms** |  **11.95 ms** |  **12.01 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms | 0.080 ms | 0.004 ms |  10.14 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.80 ms** | **8.057 ms** | **0.442 ms** | **119.29 ms** | **120.09 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.09 ms | 0.466 ms | 0.026 ms | 101.06 ms | 101.11 ms |     381 B |
