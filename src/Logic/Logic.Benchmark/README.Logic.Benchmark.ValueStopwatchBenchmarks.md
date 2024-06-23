```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.50 ns** | **2.042 ns** | **0.112 ns** |  **61.38 ns** |  **61.60 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.10 ns | 0.036 ns | 0.002 ns |  57.09 ns |  57.10 ns |      - |         - |
| **Stopwatch**      | **3**      | **122.78 ns** | **4.492 ns** | **0.246 ns** | **122.51 ns** | **122.99 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.98 ns | 0.282 ns | 0.015 ns | 113.97 ns | 114.00 ns |      - |         - |
