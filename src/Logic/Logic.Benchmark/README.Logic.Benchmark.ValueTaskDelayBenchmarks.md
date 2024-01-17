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
| **TaskDelay**      | **1**      |  **11.98 ms** | **0.126 ms** | **0.007 ms** |  **11.97 ms** |  **11.99 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms | 0.242 ms | 0.013 ms |  10.12 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.64 ms** | **7.642 ms** | **0.419 ms** | **119.21 ms** | **120.05 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.07 ms | 0.359 ms | 0.020 ms | 101.05 ms | 101.09 ms |     381 B |
