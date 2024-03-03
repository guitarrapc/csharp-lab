```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.57 ns** | **2.156 ns** | **0.118 ns** |  **61.43 ns** |  **61.64 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.11 ns | 0.353 ns | 0.019 ns |  57.09 ns |  57.13 ns |      - |         - |
| **Stopwatch**      | **10**     | **323.59 ns** | **8.025 ns** | **0.440 ns** | **323.28 ns** | **324.09 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 315.42 ns | 0.836 ns | 0.046 ns | 315.38 ns | 315.47 ns |      - |         - |
