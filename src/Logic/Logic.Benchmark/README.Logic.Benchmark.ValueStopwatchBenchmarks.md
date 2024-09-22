```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.92 ns** | **3.053 ns** | **0.167 ns** |  **61.81 ns** |  **62.11 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.42 ns | 1.263 ns | 0.069 ns |  57.34 ns |  57.47 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.62 ns** | **1.849 ns** | **0.101 ns** | **120.50 ns** | **120.70 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.62 ns | 1.918 ns | 0.105 ns | 114.51 ns | 114.72 ns |      - |         - |
