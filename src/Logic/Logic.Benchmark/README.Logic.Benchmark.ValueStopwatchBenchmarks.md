```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.38 ns** |  **2.504 ns** | **0.137 ns** |  **61.24 ns** |  **61.51 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.05 ns |  0.138 ns | 0.008 ns |  57.04 ns |  57.06 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.44 ns** | **26.101 ns** | **1.431 ns** | **119.60 ns** | **122.09 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.00 ns |  0.086 ns | 0.005 ns | 113.99 ns | 114.00 ns |      - |         - |
