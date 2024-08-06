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
| **Stopwatch**      | **1**      |  **62.20 ns** | **3.386 ns** | **0.186 ns** |  **61.99 ns** |  **62.35 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.82 ns | 0.389 ns | 0.021 ns |  56.81 ns |  56.84 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.80 ns** | **4.560 ns** | **0.250 ns** | **119.62 ns** | **120.09 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.02 ns | 0.805 ns | 0.044 ns | 113.99 ns | 114.07 ns |      - |         - |
