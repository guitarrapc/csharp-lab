```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.43 ns** | **1.097 ns** | **0.060 ns** |  **61.36 ns** |  **61.47 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.19 ns | 1.712 ns | 0.094 ns |  57.13 ns |  57.30 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.60 ns** | **5.259 ns** | **0.288 ns** | **119.38 ns** | **119.93 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.72 ns | 0.679 ns | 0.037 ns | 113.70 ns | 113.77 ns |      - |         - |
