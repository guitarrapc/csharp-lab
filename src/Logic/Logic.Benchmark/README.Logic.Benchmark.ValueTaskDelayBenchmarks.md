```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **12.47 ms** |  **6.011 ms** | **0.329 ms** |  **12.12 ms** |  **12.76 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms |  0.112 ms | 0.006 ms |  10.14 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **123.69 ms** | **33.017 ms** | **1.810 ms** | **122.22 ms** | **125.71 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.13 ms |  0.178 ms | 0.010 ms | 101.12 ms | 101.14 ms |     381 B |
