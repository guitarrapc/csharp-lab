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
| **TaskDelay**      | **1**      |  **11.97 ms** | **0.525 ms** | **0.029 ms** |  **11.94 ms** |  **11.99 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.13 ms | 0.152 ms | 0.008 ms |  10.13 ms |  10.14 ms |     192 B |
| **TaskDelay**      | **10**     | **119.63 ms** | **6.712 ms** | **0.368 ms** | **119.25 ms** | **119.98 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.12 ms | 0.129 ms | 0.007 ms | 101.11 ms | 101.12 ms |     381 B |
