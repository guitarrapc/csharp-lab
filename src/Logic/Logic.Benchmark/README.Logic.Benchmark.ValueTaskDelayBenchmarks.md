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
| **TaskDelay**      | **1**      |  **11.98 ms** | **0.467 ms** | **0.026 ms** |  **11.95 ms** |  **11.99 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms | 0.162 ms | 0.009 ms |  10.13 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.78 ms** | **4.142 ms** | **0.227 ms** | **119.62 ms** | **120.04 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.11 ms | 0.240 ms | 0.013 ms | 101.09 ms | 101.12 ms |     381 B |
