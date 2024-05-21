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
| **Stopwatch**      | **1**      |  **62.16 ns** | **1.974 ns** | **0.108 ns** |  **62.05 ns** |  **62.26 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.10 ns | 0.126 ns | 0.007 ns |  57.10 ns |  57.11 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.53 ns** | **6.405 ns** | **0.351 ns** | **119.32 ns** | **119.94 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.31 ns | 0.810 ns | 0.044 ns | 114.27 ns | 114.36 ns |      - |         - |
