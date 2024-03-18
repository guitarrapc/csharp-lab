```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.89 ns** | **1.147 ns** | **0.063 ns** |  **61.82 ns** |  **61.94 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 0.378 ns | 0.021 ns |  57.11 ns |  57.15 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.15 ns** | **4.657 ns** | **0.255 ns** | **119.99 ns** | **120.45 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.17 ns | 3.319 ns | 0.182 ns | 114.01 ns | 114.37 ns |      - |         - |
