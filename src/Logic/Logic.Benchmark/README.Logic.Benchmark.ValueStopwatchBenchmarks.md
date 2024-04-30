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
| **Stopwatch**      | **1**      |  **61.38 ns** | **2.647 ns** | **0.145 ns** |  **61.27 ns** |  **61.54 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.10 ns | 0.064 ns | 0.003 ns |  57.10 ns |  57.10 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.76 ns** | **5.367 ns** | **0.294 ns** | **119.53 ns** | **120.09 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.98 ns | 0.309 ns | 0.017 ns | 113.96 ns | 114.00 ns |      - |         - |
