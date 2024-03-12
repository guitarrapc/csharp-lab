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
| **Stopwatch**      | **1**      |  **61.57 ns** | **1.692 ns** | **0.093 ns** |  **61.51 ns** |  **61.68 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.16 ns | 1.072 ns | 0.059 ns |  57.12 ns |  57.23 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.79 ns** | **8.127 ns** | **0.445 ns** | **119.54 ns** | **120.31 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.99 ns | 0.664 ns | 0.036 ns | 113.96 ns | 114.03 ns |      - |         - |
