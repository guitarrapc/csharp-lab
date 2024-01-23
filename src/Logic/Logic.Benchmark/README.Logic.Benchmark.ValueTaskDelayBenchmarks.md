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
| **TaskDelay**      | **1**      |  **11.98 ms** | **0.645 ms** | **0.035 ms** |  **11.95 ms** |  **12.02 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms | 0.094 ms | 0.005 ms |  10.14 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.70 ms** | **7.515 ms** | **0.412 ms** | **119.23 ms** | **119.95 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.09 ms | 0.594 ms | 0.033 ms | 101.06 ms | 101.13 ms |     381 B |
