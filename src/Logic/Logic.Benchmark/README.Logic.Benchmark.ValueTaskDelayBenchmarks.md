```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **11.97 ms** | **0.494 ms** | **0.027 ms** |  **11.94 ms** |  **12.00 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms | 0.038 ms | 0.002 ms |  10.15 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.68 ms** | **7.119 ms** | **0.390 ms** | **119.34 ms** | **120.10 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.16 ms | 0.350 ms | 0.019 ms | 101.14 ms | 101.17 ms |     381 B |
