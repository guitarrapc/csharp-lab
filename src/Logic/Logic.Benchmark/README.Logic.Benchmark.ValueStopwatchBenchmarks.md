```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.61 ns** | **2.655 ns** | **0.146 ns** |  **61.50 ns** |  **61.78 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 0.504 ns | 0.028 ns |  57.12 ns |  57.17 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.00 ns** | **6.458 ns** | **0.354 ns** | **119.59 ns** | **120.22 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.03 ns | 0.482 ns | 0.026 ns | 114.00 ns | 114.05 ns |      - |         - |
