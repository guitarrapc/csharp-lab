```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.91 ns** |  **4.575 ns** | **0.251 ns** |  **61.67 ns** |  **62.17 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.13 ns |  0.059 ns | 0.003 ns |  57.13 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **3**      | **121.66 ns** | **55.154 ns** | **3.023 ns** | **119.85 ns** | **125.15 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.60 ns | 13.925 ns | 0.763 ns | 114.01 ns | 115.46 ns |      - |         - |
