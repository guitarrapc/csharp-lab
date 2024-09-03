```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.65 ns** |  **0.789 ns** | **0.043 ns** |  **61.60 ns** |  **61.68 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.09 ns |  0.264 ns | 0.014 ns |  57.07 ns |  57.10 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.96 ns** |  **7.489 ns** | **0.411 ns** | **119.70 ns** | **120.43 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.54 ns | 16.409 ns | 0.899 ns | 113.98 ns | 115.58 ns |      - |         - |
