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
| **Stopwatch**      | **1**      |  **61.37 ns** | **3.205 ns** | **0.176 ns** |  **61.25 ns** |  **61.57 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 0.560 ns | 0.031 ns |  57.11 ns |  57.16 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.73 ns** | **5.961 ns** | **0.327 ns** | **119.41 ns** | **120.06 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.02 ns | 1.056 ns | 0.058 ns | 113.97 ns | 114.08 ns |      - |         - |
