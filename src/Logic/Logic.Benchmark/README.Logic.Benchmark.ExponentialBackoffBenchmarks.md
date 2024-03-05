```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|------------------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| **ExponentialBackoff** | **1**      | **11.98 ms** | **0.307 ms** | **0.017 ms** | **11.97 ms** | **12.00 ms** |     **520 B** |
| **ExponentialBackoff** | **3**      | **71.71 ms** | **0.613 ms** | **0.034 ms** | **71.68 ms** | **71.75 ms** |    **1226 B** |
