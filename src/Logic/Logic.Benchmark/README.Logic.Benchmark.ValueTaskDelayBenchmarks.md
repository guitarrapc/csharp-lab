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
| **TaskDelay**      | **1**      |  **11.96 ms** | **0.349 ms** | **0.019 ms** |  **11.95 ms** |  **11.99 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms | 0.122 ms | 0.007 ms |  10.14 ms |  10.15 ms |     192 B |
| **TaskDelay**      | **10**     | **119.68 ms** | **3.388 ms** | **0.186 ms** | **119.57 ms** | **119.90 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.17 ms | 0.542 ms | 0.030 ms | 101.15 ms | 101.21 ms |     381 B |
