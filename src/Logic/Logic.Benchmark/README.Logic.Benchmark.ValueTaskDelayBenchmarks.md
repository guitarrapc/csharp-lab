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
| **TaskDelay**      | **1**      |  **11.99 ms** | **0.516 ms** | **0.028 ms** |  **11.96 ms** |  **12.02 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.16 ms | 0.201 ms | 0.011 ms |  10.15 ms |  10.17 ms |     192 B |
| **TaskDelay**      | **10**     | **119.73 ms** | **6.816 ms** | **0.374 ms** | **119.31 ms** | **120.00 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.10 ms | 0.205 ms | 0.011 ms | 101.09 ms | 101.11 ms |     381 B |
