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
| **Stopwatch**      | **1**      |  **61.39 ns** | **2.813 ns** | **0.154 ns** |  **61.28 ns** |  **61.56 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.16 ns | 6.588 ns | 0.361 ns |  56.94 ns |  57.58 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.65 ns** | **5.059 ns** | **0.277 ns** | **119.34 ns** | **119.88 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.21 ns | 0.637 ns | 0.035 ns | 114.18 ns | 114.25 ns |      - |         - |
