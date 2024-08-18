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
| **Stopwatch**      | **1**      |  **61.50 ns** | **1.641 ns** | **0.090 ns** |  **61.42 ns** |  **61.60 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.13 ns | 0.168 ns | 0.009 ns |  57.12 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.85 ns** | **3.930 ns** | **0.215 ns** | **119.71 ns** | **120.10 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.09 ns | 1.689 ns | 0.093 ns | 114.03 ns | 114.20 ns |      - |         - |
