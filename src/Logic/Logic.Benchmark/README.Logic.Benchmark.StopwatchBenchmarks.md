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
| **Stopwatch**      | **1**      |  **60.63 ns** |  **5.550 ns** | **0.304 ns** |  **60.45 ns** |  **60.98 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.90 ns |  0.608 ns | 0.033 ns |  55.87 ns |  55.94 ns |      - |         - |
| **Stopwatch**      | **10**     | **318.41 ns** |  **9.065 ns** | **0.497 ns** | **317.95 ns** | **318.93 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 309.04 ns | 15.089 ns | 0.827 ns | 308.49 ns | 309.99 ns |      - |         - |
