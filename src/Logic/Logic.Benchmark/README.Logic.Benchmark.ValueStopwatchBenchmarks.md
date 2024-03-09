```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.26 ns** |  **1.882 ns** | **0.103 ns** |  **62.17 ns** |  **62.37 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.24 ns |  3.453 ns | 0.189 ns |  57.12 ns |  57.45 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.00 ns** | **11.286 ns** | **0.619 ns** | **119.64 ns** | **120.71 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.77 ns |  0.122 ns | 0.007 ns | 113.76 ns | 113.78 ns |      - |         - |
