```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **12.42 ms** |  **3.593 ms** | **0.197 ms** |  **12.23 ms** |  **12.63 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms |  0.153 ms | 0.008 ms |  10.13 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **123.70 ms** | **37.485 ms** | **2.055 ms** | **121.55 ms** | **125.65 ms** |    **2104 B** |
| ValueTaskDelay | 10     | 101.09 ms |  0.158 ms | 0.009 ms | 101.08 ms | 101.10 ms |     381 B |
