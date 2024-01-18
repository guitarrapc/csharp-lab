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
| **TaskDelay**      | **1**      |  **11.98 ms** |  **0.793 ms** | **0.043 ms** |  **11.94 ms** |  **12.02 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.13 ms |  0.164 ms | 0.009 ms |  10.13 ms |  10.14 ms |     192 B |
| **TaskDelay**      | **10**     | **119.71 ms** | **10.563 ms** | **0.579 ms** | **119.19 ms** | **120.33 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.11 ms |  0.679 ms | 0.037 ms | 101.07 ms | 101.14 ms |     381 B |
