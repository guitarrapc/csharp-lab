```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.19 ns** |  **1.922 ns** | **0.105 ns** |  **62.09 ns** |  **62.30 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.29 ns |  5.254 ns | 0.288 ns |  55.98 ns |  56.55 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.15 ns** | **10.759 ns** | **0.590 ns** | **119.60 ns** | **120.77 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.73 ns | 14.642 ns | 0.803 ns | 112.82 ns | 114.34 ns |      - |         - |
