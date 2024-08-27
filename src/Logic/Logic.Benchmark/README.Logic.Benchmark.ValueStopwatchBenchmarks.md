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
| **Stopwatch**      | **1**      |  **61.59 ns** |  **1.989 ns** | **0.109 ns** |  **61.52 ns** |  **61.72 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.11 ns |  0.188 ns | 0.010 ns |  57.10 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.84 ns** |  **5.728 ns** | **0.314 ns** | **119.65 ns** | **120.20 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.83 ns | 21.197 ns | 1.162 ns | 114.02 ns | 116.16 ns |      - |         - |
