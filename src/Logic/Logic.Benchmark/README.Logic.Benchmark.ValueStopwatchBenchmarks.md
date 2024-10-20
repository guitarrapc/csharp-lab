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
| **Stopwatch**      | **1**      |  **61.45 ns** | **1.969 ns** | **0.108 ns** |  **61.38 ns** |  **61.58 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 0.037 ns | 0.002 ns |  57.14 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.76 ns** | **7.385 ns** | **0.405 ns** | **119.52 ns** | **120.22 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.62 ns | 0.371 ns | 0.020 ns | 114.60 ns | 114.63 ns |      - |         - |
