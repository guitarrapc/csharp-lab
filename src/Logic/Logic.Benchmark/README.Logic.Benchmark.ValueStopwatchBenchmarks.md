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
| **Stopwatch**      | **1**      |  **61.28 ns** | **2.974 ns** | **0.163 ns** |  **61.15 ns** |  **61.46 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.03 ns | 0.170 ns | 0.009 ns |  57.02 ns |  57.04 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.72 ns** | **4.917 ns** | **0.269 ns** | **119.41 ns** | **119.87 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.71 ns | 0.549 ns | 0.030 ns | 113.68 ns | 113.74 ns |      - |         - |
