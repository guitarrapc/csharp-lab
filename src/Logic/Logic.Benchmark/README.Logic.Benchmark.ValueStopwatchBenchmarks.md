```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.96 ns** | **1.973 ns** | **0.108 ns** |  **61.89 ns** |  **62.09 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.46 ns | 0.352 ns | 0.019 ns |  57.44 ns |  57.47 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.67 ns** | **4.390 ns** | **0.241 ns** | **120.48 ns** | **120.94 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.68 ns | 0.929 ns | 0.051 ns | 114.62 ns | 114.72 ns |      - |         - |
