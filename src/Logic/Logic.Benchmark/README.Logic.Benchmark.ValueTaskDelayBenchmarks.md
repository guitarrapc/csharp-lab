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
| **TaskDelay**      | **1**      |  **12.43 ms** |  **6.025 ms** | **0.330 ms** |  **12.15 ms** |  **12.79 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.13 ms |  0.083 ms | 0.005 ms |  10.12 ms |  10.13 ms |     192 B |
| **TaskDelay**      | **10**     | **124.93 ms** | **39.622 ms** | **2.172 ms** | **123.47 ms** | **127.43 ms** |    **2104 B** |
| ValueTaskDelay | 10     | 101.10 ms |  0.114 ms | 0.006 ms | 101.09 ms | 101.10 ms |     381 B |
