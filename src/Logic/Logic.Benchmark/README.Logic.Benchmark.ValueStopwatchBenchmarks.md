```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.67 ns** | **2.164 ns** | **0.119 ns** |  **61.57 ns** |  **61.80 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.11 ns | 0.159 ns | 0.009 ns |  57.10 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.84 ns** | **4.795 ns** | **0.263 ns** | **119.66 ns** | **120.14 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.00 ns | 0.959 ns | 0.053 ns | 113.96 ns | 114.06 ns |      - |         - |
