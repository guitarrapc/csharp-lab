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
| **Stopwatch**      | **1**      |  **61.34 ns** | **2.398 ns** | **0.131 ns** |  **61.23 ns** |  **61.48 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.18 ns | 1.217 ns | 0.067 ns |  57.13 ns |  57.26 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.68 ns** | **5.155 ns** | **0.283 ns** | **119.51 ns** | **120.01 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.80 ns | 1.305 ns | 0.072 ns | 113.72 ns | 113.86 ns |      - |         - |
