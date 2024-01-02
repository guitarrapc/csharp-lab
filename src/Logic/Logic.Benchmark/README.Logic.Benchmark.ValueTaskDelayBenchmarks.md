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
| **TaskDelay**      | **1**      |  **11.98 ms** | **0.401 ms** | **0.022 ms** |  **11.96 ms** |  **11.99 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms | 0.087 ms | 0.005 ms |  10.14 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.61 ms** | **4.712 ms** | **0.258 ms** | **119.39 ms** | **119.89 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.08 ms | 0.484 ms | 0.027 ms | 101.05 ms | 101.10 ms |     381 B |
