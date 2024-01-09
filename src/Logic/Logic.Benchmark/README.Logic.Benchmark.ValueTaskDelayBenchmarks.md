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
| **TaskDelay**      | **1**      |  **12.12 ms** |  **1.707 ms** | **0.094 ms** |  **12.03 ms** |  **12.21 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms |  0.067 ms | 0.004 ms |  10.13 ms |  10.14 ms |     192 B |
| **TaskDelay**      | **10**     | **120.67 ms** | **11.997 ms** | **0.658 ms** | **120.08 ms** | **121.38 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.08 ms |  0.857 ms | 0.047 ms | 101.04 ms | 101.14 ms |     381 B |
