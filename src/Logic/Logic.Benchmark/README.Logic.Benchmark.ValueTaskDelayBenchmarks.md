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
| **TaskDelay**      | **1**      |  **12.15 ms** |  **3.162 ms** | **0.173 ms** |  **11.95 ms** |  **12.27 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.16 ms |  0.202 ms | 0.011 ms |  10.15 ms |  10.17 ms |     192 B |
| **TaskDelay**      | **10**     | **121.36 ms** | **32.176 ms** | **1.764 ms** | **119.42 ms** | **122.87 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.29 ms |  1.426 ms | 0.078 ms | 101.21 ms | 101.36 ms |     381 B |
