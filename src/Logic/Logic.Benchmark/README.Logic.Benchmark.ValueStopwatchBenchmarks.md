```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.07 ns** | **2.535 ns** | **0.139 ns** |  **61.99 ns** |  **62.23 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns | 0.439 ns | 0.024 ns |  57.10 ns |  57.15 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.94 ns** | **4.333 ns** | **0.237 ns** | **119.80 ns** | **120.22 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.12 ns | 0.350 ns | 0.019 ns | 114.10 ns | 114.14 ns |      - |         - |
