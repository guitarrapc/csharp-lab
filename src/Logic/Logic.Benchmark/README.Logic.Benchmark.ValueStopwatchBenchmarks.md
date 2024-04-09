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
| **Stopwatch**      | **1**      |  **61.45 ns** |  **1.846 ns** | **0.101 ns** |  **61.34 ns** |  **61.51 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.68 ns |  7.646 ns | 0.419 ns |  56.33 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **3**      | **118.23 ns** | **50.032 ns** | **2.742 ns** | **115.07 ns** | **119.89 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 112.88 ns | 12.565 ns | 0.689 ns | 112.08 ns | 113.32 ns |      - |         - |
