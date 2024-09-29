```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.59 ns** |  **4.170 ns** | **0.229 ns** |  **61.42 ns** |  **61.85 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.15 ns |  3.459 ns | 0.190 ns |  56.95 ns |  57.32 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.90 ns** | **23.649 ns** | **1.296 ns** | **118.46 ns** | **120.98 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 112.87 ns |  8.302 ns | 0.455 ns | 112.54 ns | 113.39 ns |      - |         - |
