```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.25 ns** | **2.174 ns** | **0.119 ns** |  **62.18 ns** |  **62.39 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.10 ns | 0.390 ns | 0.021 ns |  57.09 ns |  57.13 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.85 ns** | **4.601 ns** | **0.252 ns** | **119.57 ns** | **120.06 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.01 ns | 0.694 ns | 0.038 ns | 113.97 ns | 114.04 ns |      - |         - |
