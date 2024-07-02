```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.03 ns** | **2.217 ns** | **0.122 ns** |  **61.92 ns** |  **62.16 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.98 ns | 0.609 ns | 0.033 ns |  56.94 ns |  57.01 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.08 ns** | **7.085 ns** | **0.388 ns** | **119.67 ns** | **120.44 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.97 ns | 0.206 ns | 0.011 ns | 113.96 ns | 113.98 ns |      - |         - |
