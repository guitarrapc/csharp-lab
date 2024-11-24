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
| **Stopwatch**      | **1**      |  **61.11 ns** | **3.780 ns** | **0.207 ns** |  **60.95 ns** |  **61.34 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 2.957 ns | 0.162 ns |  56.99 ns |  57.31 ns |      - |         - |
| **Stopwatch**      | **3**      | **118.33 ns** | **8.207 ns** | **0.450 ns** | **117.85 ns** | **118.74 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.60 ns | 1.643 ns | 0.090 ns | 114.50 ns | 114.67 ns |      - |         - |
