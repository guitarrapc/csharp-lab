```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.77 ns** | **1.600 ns** | **0.088 ns** |  **61.71 ns** |  **61.87 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.19 ns | 1.387 ns | 0.076 ns |  57.14 ns |  57.28 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.66 ns** | **6.092 ns** | **0.334 ns** | **119.46 ns** | **120.04 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.96 ns | 4.176 ns | 0.229 ns | 113.69 ns | 114.11 ns |      - |         - |
