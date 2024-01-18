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
| **TaskDelay**      | **1**      |  **12.03 ms** |  **0.282 ms** | **0.015 ms** |  **12.02 ms** |  **12.05 ms** |     **366 B** |
| ValueTaskDelay | 1      |  10.13 ms |  0.033 ms | 0.002 ms |  10.13 ms |  10.13 ms |     192 B |
| **TaskDelay**      | **10**     | **120.43 ms** | **10.899 ms** | **0.597 ms** | **120.05 ms** | **121.12 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.10 ms |  0.436 ms | 0.024 ms | 101.08 ms | 101.13 ms |     381 B |
