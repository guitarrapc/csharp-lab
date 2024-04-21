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
| **Stopwatch**      | **1**      |  **61.91 ns** | **2.721 ns** | **0.149 ns** |  **61.75 ns** |  **62.05 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.11 ns | 0.248 ns | 0.014 ns |  57.10 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.67 ns** | **5.311 ns** | **0.291 ns** | **119.48 ns** | **120.01 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.24 ns | 6.453 ns | 0.354 ns | 113.98 ns | 114.64 ns |      - |         - |
