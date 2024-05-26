```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.38 ns** |  **2.382 ns** | **0.131 ns** |  **61.29 ns** |  **61.53 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.15 ns |  0.762 ns | 0.042 ns |  57.12 ns |  57.20 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.21 ns** | **12.564 ns** | **0.689 ns** | **119.64 ns** | **120.97 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.27 ns |  3.598 ns | 0.197 ns | 114.12 ns | 114.49 ns |      - |         - |
