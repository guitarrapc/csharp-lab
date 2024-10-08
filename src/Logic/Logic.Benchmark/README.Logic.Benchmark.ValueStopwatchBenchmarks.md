```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.16 ns** | **2.371 ns** | **0.130 ns** |  **62.03 ns** |  **62.29 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.43 ns | 0.256 ns | 0.014 ns |  57.42 ns |  57.45 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.91 ns** | **5.127 ns** | **0.281 ns** | **120.71 ns** | **121.23 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.64 ns | 1.146 ns | 0.063 ns | 114.57 ns | 114.70 ns |      - |         - |
