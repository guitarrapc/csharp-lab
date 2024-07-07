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
| **Stopwatch**      | **1**      |  **62.17 ns** | **3.025 ns** | **0.166 ns** |  **62.04 ns** |  **62.36 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 0.469 ns | 0.026 ns |  57.11 ns |  57.15 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.62 ns** | **4.446 ns** | **0.244 ns** | **119.45 ns** | **119.90 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.19 ns | 1.529 ns | 0.084 ns | 114.13 ns | 114.29 ns |      - |         - |
