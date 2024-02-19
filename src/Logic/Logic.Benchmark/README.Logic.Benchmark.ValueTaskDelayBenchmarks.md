```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **11.97 ms** | **0.387 ms** | **0.021 ms** |  **11.96 ms** |  **12.00 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.13 ms | 0.081 ms | 0.004 ms |  10.13 ms |  10.14 ms |     192 B |
| **TaskDelay**      | **10**     | **119.52 ms** | **6.195 ms** | **0.340 ms** | **119.27 ms** | **119.90 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.12 ms | 0.103 ms | 0.006 ms | 101.12 ms | 101.13 ms |     381 B |
