```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.10 ns** | **2.768 ns** | **0.152 ns** |  **62.00 ns** |  **62.27 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns | 0.082 ns | 0.005 ns |  57.11 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.64 ns** | **5.501 ns** | **0.302 ns** | **119.45 ns** | **119.99 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.01 ns | 0.659 ns | 0.036 ns | 113.97 ns | 114.03 ns |      - |         - |
