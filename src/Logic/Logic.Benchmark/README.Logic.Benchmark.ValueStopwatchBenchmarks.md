```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.66 ns** | **3.201 ns** | **0.175 ns** |  **61.52 ns** |  **61.86 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.16 ns | 0.667 ns | 0.037 ns |  57.12 ns |  57.19 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.85 ns** | **4.445 ns** | **0.244 ns** | **119.70 ns** | **120.13 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.10 ns | 3.282 ns | 0.180 ns | 113.99 ns | 114.30 ns |      - |         - |
