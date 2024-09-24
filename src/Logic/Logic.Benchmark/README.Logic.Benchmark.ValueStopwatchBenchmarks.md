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
| **Stopwatch**      | **1**      |  **61.80 ns** | **5.598 ns** | **0.307 ns** |  **61.61 ns** |  **62.15 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.43 ns | 0.528 ns | 0.029 ns |  57.41 ns |  57.46 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.37 ns** | **5.910 ns** | **0.324 ns** | **120.10 ns** | **120.73 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.66 ns | 1.008 ns | 0.055 ns | 114.60 ns | 114.71 ns |      - |         - |
