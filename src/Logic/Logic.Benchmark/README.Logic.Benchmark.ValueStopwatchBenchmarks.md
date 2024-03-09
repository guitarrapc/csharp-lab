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
| **Stopwatch**      | **1**      |  **62.28 ns** | **4.663 ns** | **0.256 ns** |  **62.13 ns** |  **62.57 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns | 0.489 ns | 0.027 ns |  57.10 ns |  57.15 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.98 ns** | **2.690 ns** | **0.147 ns** | **119.87 ns** | **120.15 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.00 ns | 0.651 ns | 0.036 ns | 113.96 ns | 114.03 ns |      - |         - |
