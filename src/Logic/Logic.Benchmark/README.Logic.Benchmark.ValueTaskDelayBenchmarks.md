```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **11.98 ms** | **0.085 ms** | **0.005 ms** |  **11.97 ms** |  **11.98 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms | 0.125 ms | 0.007 ms |  10.13 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.71 ms** | **2.838 ms** | **0.156 ms** | **119.58 ms** | **119.88 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.10 ms | 0.205 ms | 0.011 ms | 101.09 ms | 101.11 ms |     381 B |
