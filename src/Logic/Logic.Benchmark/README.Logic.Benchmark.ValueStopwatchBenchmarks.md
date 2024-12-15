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
| **Stopwatch**      | **1**      |  **69.85 ns** | **1.969 ns** | **0.108 ns** |  **69.78 ns** |  **69.98 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.21 ns | 0.171 ns | 0.009 ns |  56.19 ns |  56.21 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.96 ns** | **3.290 ns** | **0.180 ns** | **119.83 ns** | **120.17 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.75 ns | 0.308 ns | 0.017 ns | 113.74 ns | 113.77 ns |      - |         - |
