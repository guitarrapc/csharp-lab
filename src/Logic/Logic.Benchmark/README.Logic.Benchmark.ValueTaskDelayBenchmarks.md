```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **12.00 ms** | **0.374 ms** | **0.020 ms** |  **11.98 ms** |  **12.02 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms | 0.051 ms | 0.003 ms |  10.14 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.70 ms** | **6.415 ms** | **0.352 ms** | **119.38 ms** | **120.08 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.15 ms | 0.376 ms | 0.021 ms | 101.13 ms | 101.17 ms |     381 B |
