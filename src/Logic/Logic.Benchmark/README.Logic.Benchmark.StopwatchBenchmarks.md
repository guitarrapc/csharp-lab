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
| **Stopwatch**      | **1**      |  **58.38 ns** |  **7.395 ns** | **0.405 ns** |  **57.95 ns** |  **58.75 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  53.01 ns |  3.766 ns | 0.206 ns |  52.83 ns |  53.24 ns |      - |         - |
| **Stopwatch**      | **10**     | **299.84 ns** | **33.732 ns** | **1.849 ns** | **298.42 ns** | **301.93 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 292.35 ns | 23.228 ns | 1.273 ns | 291.32 ns | 293.78 ns |      - |         - |
