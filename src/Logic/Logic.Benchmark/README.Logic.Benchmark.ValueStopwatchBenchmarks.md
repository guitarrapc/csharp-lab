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
| **Stopwatch**      | **1**      |  **62.25 ns** | **1.344 ns** | **0.074 ns** |  **62.17 ns** |  **62.31 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.28 ns | 0.833 ns | 0.046 ns |  57.24 ns |  57.33 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.80 ns** | **5.967 ns** | **0.327 ns** | **120.58 ns** | **121.17 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.61 ns | 0.220 ns | 0.012 ns | 114.61 ns | 114.63 ns |      - |         - |
