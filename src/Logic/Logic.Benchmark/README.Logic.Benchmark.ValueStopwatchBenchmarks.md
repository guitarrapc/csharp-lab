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
| **Stopwatch**      | **1**      |  **61.62 ns** | **2.239 ns** | **0.123 ns** |  **61.51 ns** |  **61.75 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.82 ns | 0.404 ns | 0.022 ns |  56.80 ns |  56.84 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.01 ns** | **5.592 ns** | **0.306 ns** | **119.75 ns** | **120.35 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.04 ns | 0.623 ns | 0.034 ns | 114.00 ns | 114.07 ns |      - |         - |
