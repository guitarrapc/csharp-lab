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
| **TaskDelay**      | **1**      |  **11.97 ms** |  **0.313 ms** | **0.017 ms** |  **11.95 ms** |  **11.99 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms |  0.139 ms | 0.008 ms |  10.14 ms |  10.15 ms |     385 B |
| **TaskDelay**      | **10**     | **127.92 ms** | **48.997 ms** | **2.686 ms** | **125.23 ms** | **130.60 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.14 ms |  0.725 ms | 0.040 ms | 101.11 ms | 101.18 ms |     381 B |
