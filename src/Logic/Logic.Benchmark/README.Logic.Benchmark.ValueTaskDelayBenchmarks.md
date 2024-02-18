```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **12.22 ms** | **2.072 ms** | **0.114 ms** |  **12.16 ms** |  **12.35 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms | 0.008 ms | 0.000 ms |  10.14 ms |  10.14 ms |     192 B |
| **TaskDelay**      | **10**     | **122.50 ms** | **5.151 ms** | **0.282 ms** | **122.17 ms** | **122.67 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.15 ms | 0.176 ms | 0.010 ms | 101.14 ms | 101.15 ms |     381 B |
