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
| **Stopwatch**      | **1**      |  **61.86 ns** | **2.471 ns** | **0.135 ns** |  **61.76 ns** |  **62.01 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.15 ns | 0.904 ns | 0.050 ns |  57.11 ns |  57.20 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.60 ns** | **4.175 ns** | **0.229 ns** | **120.34 ns** | **120.78 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.72 ns | 3.767 ns | 0.206 ns | 114.59 ns | 114.96 ns |      - |         - |
