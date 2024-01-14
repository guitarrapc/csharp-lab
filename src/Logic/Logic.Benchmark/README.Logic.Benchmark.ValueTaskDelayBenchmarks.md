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
| **TaskDelay**      | **1**      |  **12.12 ms** |  **0.586 ms** | **0.032 ms** |  **12.08 ms** |  **12.15 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.13 ms |  0.152 ms | 0.008 ms |  10.13 ms |  10.14 ms |     192 B |
| **TaskDelay**      | **10**     | **122.04 ms** | **28.607 ms** | **1.568 ms** | **120.29 ms** | **123.32 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.08 ms |  0.234 ms | 0.013 ms | 101.07 ms | 101.09 ms |     381 B |
