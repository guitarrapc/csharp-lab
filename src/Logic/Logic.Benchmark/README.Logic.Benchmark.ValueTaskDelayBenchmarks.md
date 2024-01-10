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
| **TaskDelay**      | **1**      |  **12.63 ms** |  **1.547 ms** | **0.085 ms** |  **12.54 ms** |  **12.70 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms |  0.199 ms | 0.011 ms |  10.13 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **126.12 ms** | **23.208 ms** | **1.272 ms** | **124.67 ms** | **127.03 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.13 ms |  0.402 ms | 0.022 ms | 101.12 ms | 101.16 ms |     381 B |
