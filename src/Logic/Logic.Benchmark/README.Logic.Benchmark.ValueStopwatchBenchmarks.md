```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.33 ns** | **2.827 ns** | **0.155 ns** |  **61.19 ns** |  **61.50 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.13 ns | 0.479 ns | 0.026 ns |  57.11 ns |  57.16 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.71 ns** | **6.746 ns** | **0.370 ns** | **119.47 ns** | **120.13 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.33 ns | 1.128 ns | 0.062 ns | 114.29 ns | 114.40 ns |      - |         - |
