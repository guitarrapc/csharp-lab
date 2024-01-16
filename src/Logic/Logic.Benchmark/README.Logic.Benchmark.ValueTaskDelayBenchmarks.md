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
| **TaskDelay**      | **1**      |  **12.61 ms** |  **4.423 ms** | **0.242 ms** |  **12.35 ms** |  **12.83 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.15 ms |  0.019 ms | 0.001 ms |  10.15 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **128.62 ms** | **21.167 ms** | **1.160 ms** | **127.66 ms** | **129.91 ms** |    **2104 B** |
| ValueTaskDelay | 10     | 101.09 ms |  0.853 ms | 0.047 ms | 101.05 ms | 101.14 ms |     381 B |
