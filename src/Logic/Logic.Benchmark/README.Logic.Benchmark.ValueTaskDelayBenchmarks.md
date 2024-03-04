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
| **TaskDelay**      | **1**      |  **11.97 ms** | **0.751 ms** | **0.041 ms** |  **11.93 ms** |  **12.01 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms | 0.140 ms | 0.008 ms |  10.15 ms |  10.16 ms |     192 B |
| **TaskDelay**      | **10**     | **119.58 ms** | **4.638 ms** | **0.254 ms** | **119.35 ms** | **119.85 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.21 ms | 2.374 ms | 0.130 ms | 101.14 ms | 101.37 ms |     381 B |
