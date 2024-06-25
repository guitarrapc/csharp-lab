```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.53 ns** | **18.281 ns** | **1.002 ns** |  **61.44 ns** |  **63.41 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.36 ns | 10.520 ns | 0.577 ns |  56.81 ns |  57.96 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.70 ns** |  **8.208 ns** | **0.450 ns** | **119.43 ns** | **120.22 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.95 ns | 31.183 ns | 1.709 ns | 113.95 ns | 116.93 ns |      - |         - |
