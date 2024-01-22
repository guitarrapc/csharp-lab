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
| **TaskDelay**      | **1**      |  **11.97 ms** | **0.545 ms** | **0.030 ms** |  **11.95 ms** |  **12.01 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms | 0.104 ms | 0.006 ms |  10.14 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.63 ms** | **1.699 ms** | **0.093 ms** | **119.56 ms** | **119.74 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.09 ms | 0.667 ms | 0.037 ms | 101.05 ms | 101.11 ms |     381 B |
