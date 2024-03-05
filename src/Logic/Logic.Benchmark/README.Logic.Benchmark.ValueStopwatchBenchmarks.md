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
| **Stopwatch**      | **1**      |  **61.54 ns** | **2.152 ns** | **0.118 ns** |  **61.45 ns** |  **61.68 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns | 0.101 ns | 0.006 ns |  57.11 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.86 ns** | **5.558 ns** | **0.305 ns** | **119.67 ns** | **120.21 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.13 ns | 2.437 ns | 0.134 ns | 113.98 ns | 114.25 ns |      - |         - |
