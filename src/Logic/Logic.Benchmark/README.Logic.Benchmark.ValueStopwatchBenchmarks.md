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
| **Stopwatch**      | **1**      |  **61.60 ns** | **2.192 ns** | **0.120 ns** |  **61.51 ns** |  **61.74 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns | 0.186 ns | 0.010 ns |  57.11 ns |  57.13 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.74 ns** | **4.316 ns** | **0.237 ns** | **119.59 ns** | **120.01 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.98 ns | 0.093 ns | 0.005 ns | 113.97 ns | 113.98 ns |      - |         - |
