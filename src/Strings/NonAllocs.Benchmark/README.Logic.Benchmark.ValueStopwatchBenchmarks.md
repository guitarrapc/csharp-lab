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
| **Stopwatch**      | **1**      |  **61.44 ns** | **2.978 ns** | **0.163 ns** |  **61.32 ns** |  **61.62 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.15 ns | 1.015 ns | 0.056 ns |  57.09 ns |  57.21 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.99 ns** | **2.625 ns** | **0.144 ns** | **119.82 ns** | **120.09 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.05 ns | 2.235 ns | 0.123 ns | 113.95 ns | 114.18 ns |      - |         - |
