```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **12.18 ms** |  **0.196 ms** | **0.011 ms** |  **12.17 ms** |  **12.19 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms |  0.156 ms | 0.009 ms |  10.14 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **121.98 ms** | **36.439 ms** | **1.997 ms** | **120.51 ms** | **124.25 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.09 ms |  0.219 ms | 0.012 ms | 101.08 ms | 101.10 ms |     381 B |
