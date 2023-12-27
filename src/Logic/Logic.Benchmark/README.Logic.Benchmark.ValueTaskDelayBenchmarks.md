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
| **TaskDelay**      | **1**      |  **12.29 ms** |  **2.374 ms** | **0.130 ms** |  **12.16 ms** |  **12.42 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms |  0.024 ms | 0.001 ms |  10.15 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **124.48 ms** | **42.522 ms** | **2.331 ms** | **122.69 ms** | **127.12 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.11 ms |  0.335 ms | 0.018 ms | 101.09 ms | 101.13 ms |     381 B |
