```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.96 ns** | **2.262 ns** | **0.124 ns** |  **62.87 ns** |  **63.10 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.25 ns | 0.768 ns | 0.042 ns |  57.23 ns |  57.30 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.89 ns** | **3.737 ns** | **0.205 ns** | **120.68 ns** | **121.09 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.80 ns | 1.511 ns | 0.083 ns | 114.73 ns | 114.89 ns |      - |         - |
