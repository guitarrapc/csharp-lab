```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.43 ns** |  **1.877 ns** | **0.103 ns** |  **61.34 ns** |  **61.54 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.31 ns |  6.634 ns | 0.364 ns |  57.10 ns |  57.73 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.97 ns** | **20.959 ns** | **1.149 ns** | **119.65 ns** | **121.76 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.99 ns |  0.585 ns | 0.032 ns | 113.96 ns | 114.02 ns |      - |         - |
