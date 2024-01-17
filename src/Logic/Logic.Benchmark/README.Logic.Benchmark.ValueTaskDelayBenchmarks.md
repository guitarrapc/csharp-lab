```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **12.12 ms** |  **0.623 ms** | **0.034 ms** |  **12.08 ms** |  **12.14 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms |  0.119 ms | 0.007 ms |  10.13 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **121.20 ms** | **16.295 ms** | **0.893 ms** | **120.34 ms** | **122.13 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.08 ms |  0.118 ms | 0.006 ms | 101.08 ms | 101.09 ms |     381 B |
