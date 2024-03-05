```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean     | Error     | StdDev   | Min      | Max      | Allocated |
|--------------- |------- |---------:|----------:|---------:|---------:|---------:|----------:|
| **TaskDelay**      | **1**      | **12.35 ms** |  **3.951 ms** | **0.217 ms** | **12.21 ms** | **12.60 ms** |     **352 B** |
| ValueTaskDelay | 1      | 10.14 ms |  0.101 ms | 0.006 ms | 10.14 ms | 10.15 ms |     192 B |
| **TaskDelay**      | **3**      | **37.01 ms** | **19.173 ms** | **1.051 ms** | **36.00 ms** | **38.10 ms** |     **745 B** |
| ValueTaskDelay | 3      | 30.35 ms |  0.191 ms | 0.010 ms | 30.34 ms | 30.36 ms |     208 B |
