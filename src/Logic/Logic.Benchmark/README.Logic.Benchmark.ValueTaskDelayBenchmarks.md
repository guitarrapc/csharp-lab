```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **11.97 ms** | **0.376 ms** | **0.021 ms** |  **11.95 ms** |  **11.99 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.17 ms | 0.068 ms | 0.004 ms |  10.17 ms |  10.18 ms |     192 B |
| **TaskDelay**      | **10**     | **119.63 ms** | **2.851 ms** | **0.156 ms** | **119.45 ms** | **119.73 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.27 ms | 0.373 ms | 0.020 ms | 101.25 ms | 101.29 ms |     381 B |
