```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.19 ns** | **2.155 ns** | **0.118 ns** |  **62.12 ns** |  **62.33 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.48 ns | 0.995 ns | 0.055 ns |  57.42 ns |  57.53 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.73 ns** | **5.362 ns** | **0.294 ns** | **120.50 ns** | **121.06 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 115.24 ns | 0.473 ns | 0.026 ns | 115.21 ns | 115.26 ns |      - |         - |
