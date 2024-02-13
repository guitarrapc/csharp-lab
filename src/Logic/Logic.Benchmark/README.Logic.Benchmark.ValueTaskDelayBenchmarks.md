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
| **TaskDelay**      | **1**      |  **11.98 ms** | **0.546 ms** | **0.030 ms** |  **11.96 ms** |  **12.02 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.18 ms | 0.789 ms | 0.043 ms |  10.14 ms |  10.23 ms |     192 B |
| **TaskDelay**      | **10**     | **119.71 ms** | **6.559 ms** | **0.359 ms** | **119.41 ms** | **120.11 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.30 ms | 2.332 ms | 0.128 ms | 101.18 ms | 101.43 ms |     381 B |
