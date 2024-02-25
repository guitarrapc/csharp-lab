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
| **TaskDelay**      | **1**      |  **11.98 ms** | **0.309 ms** | **0.017 ms** |  **11.96 ms** |  **11.99 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms | 0.044 ms | 0.002 ms |  10.14 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.74 ms** | **3.414 ms** | **0.187 ms** | **119.58 ms** | **119.95 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.10 ms | 0.788 ms | 0.043 ms | 101.06 ms | 101.15 ms |     381 B |
