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
| **TaskDelay**      | **1**      |  **12.31 ms** |  **2.257 ms** | **0.124 ms** |  **12.18 ms** |  **12.43 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms |  0.043 ms | 0.002 ms |  10.14 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **121.25 ms** | **14.450 ms** | **0.792 ms** | **120.53 ms** | **122.10 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.10 ms |  0.695 ms | 0.038 ms | 101.05 ms | 101.13 ms |     381 B |
