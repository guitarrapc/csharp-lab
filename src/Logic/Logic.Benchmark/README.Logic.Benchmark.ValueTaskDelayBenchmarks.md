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
| **TaskDelay**      | **1**      |  **11.99 ms** | **0.574 ms** | **0.031 ms** |  **11.97 ms** |  **12.03 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms | 0.055 ms | 0.003 ms |  10.15 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.73 ms** | **1.220 ms** | **0.067 ms** | **119.65 ms** | **119.78 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.12 ms | 0.250 ms | 0.014 ms | 101.10 ms | 101.13 ms |     381 B |
