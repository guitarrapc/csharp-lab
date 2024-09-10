```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.11 ns** | **1.944 ns** | **0.107 ns** |  **61.98 ns** |  **62.18 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.17 ns | 1.341 ns | 0.073 ns |  57.12 ns |  57.26 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.09 ns** | **5.237 ns** | **0.287 ns** | **119.92 ns** | **120.42 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.09 ns | 1.241 ns | 0.068 ns | 114.05 ns | 114.17 ns |      - |         - |
