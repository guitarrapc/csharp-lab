```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.55 ns** |  **2.533 ns** | **0.139 ns** |  **61.44 ns** |  **61.70 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.13 ns |  0.292 ns | 0.016 ns |  57.11 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **10**     | **323.45 ns** | **13.212 ns** | **0.724 ns** | **323.01 ns** | **324.28 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 315.35 ns |  3.544 ns | 0.194 ns | 315.22 ns | 315.57 ns |      - |         - |
