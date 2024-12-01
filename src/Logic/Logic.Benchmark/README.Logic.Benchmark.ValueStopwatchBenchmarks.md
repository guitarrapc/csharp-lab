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
| **Stopwatch**      | **1**      |  **61.21 ns** | **1.958 ns** | **0.107 ns** |  **61.12 ns** |  **61.33 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 0.082 ns | 0.005 ns |  57.14 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.62 ns** | **4.798 ns** | **0.263 ns** | **119.46 ns** | **119.92 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.76 ns | 1.273 ns | 0.070 ns | 113.70 ns | 113.84 ns |      - |         - |
