```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **11.99 ms** | **0.471 ms** | **0.026 ms** |  **11.96 ms** |  **12.01 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.13 ms | 0.179 ms | 0.010 ms |  10.13 ms |  10.14 ms |     192 B |
| **TaskDelay**      | **10**     | **119.65 ms** | **7.297 ms** | **0.400 ms** | **119.27 ms** | **120.07 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.10 ms | 0.370 ms | 0.020 ms | 101.08 ms | 101.12 ms |     381 B |
