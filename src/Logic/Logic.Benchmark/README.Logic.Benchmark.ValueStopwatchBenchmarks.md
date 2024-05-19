```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.38 ns** | **2.247 ns** | **0.123 ns** |  **61.26 ns** |  **61.50 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.13 ns | 0.156 ns | 0.009 ns |  57.12 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.83 ns** | **6.339 ns** | **0.347 ns** | **119.51 ns** | **120.20 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.03 ns | 0.628 ns | 0.034 ns | 113.99 ns | 114.05 ns |      - |         - |
