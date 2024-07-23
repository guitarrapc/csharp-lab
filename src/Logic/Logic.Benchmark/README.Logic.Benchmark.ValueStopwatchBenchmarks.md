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
| **Stopwatch**      | **1**      |  **62.37 ns** | **2.006 ns** | **0.110 ns** |  **62.27 ns** |  **62.49 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.11 ns | 0.236 ns | 0.013 ns |  57.09 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.78 ns** | **4.786 ns** | **0.262 ns** | **119.57 ns** | **120.07 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.03 ns | 0.524 ns | 0.029 ns | 114.01 ns | 114.07 ns |      - |         - |
