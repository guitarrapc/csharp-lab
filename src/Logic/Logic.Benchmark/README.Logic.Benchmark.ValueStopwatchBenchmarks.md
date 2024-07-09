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
| **Stopwatch**      | **1**      |  **61.40 ns** | **2.707 ns** | **0.148 ns** |  **61.30 ns** |  **61.57 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.96 ns | 0.088 ns | 0.005 ns |  56.95 ns |  56.96 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.69 ns** | **5.501 ns** | **0.302 ns** | **119.52 ns** | **120.04 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.29 ns | 9.424 ns | 0.517 ns | 113.99 ns | 114.88 ns |      - |         - |
