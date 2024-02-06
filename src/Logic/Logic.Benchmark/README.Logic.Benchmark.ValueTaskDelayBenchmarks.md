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
| **TaskDelay**      | **1**      |  **11.97 ms** | **0.292 ms** | **0.016 ms** |  **11.95 ms** |  **11.98 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms | 0.013 ms | 0.001 ms |  10.15 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.63 ms** | **6.839 ms** | **0.375 ms** | **119.26 ms** | **120.01 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.13 ms | 0.376 ms | 0.021 ms | 101.11 ms | 101.16 ms |     381 B |
