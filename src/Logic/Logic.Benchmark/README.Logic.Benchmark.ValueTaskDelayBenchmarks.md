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
| **TaskDelay**      | **1**      |  **11.98 ms** | **0.382 ms** | **0.021 ms** |  **11.96 ms** |  **12.00 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms | 0.101 ms | 0.006 ms |  10.13 ms |  10.14 ms |     192 B |
| **TaskDelay**      | **10**     | **119.62 ms** | **8.380 ms** | **0.459 ms** | **119.10 ms** | **119.99 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.07 ms | 0.304 ms | 0.017 ms | 101.06 ms | 101.09 ms |     381 B |
