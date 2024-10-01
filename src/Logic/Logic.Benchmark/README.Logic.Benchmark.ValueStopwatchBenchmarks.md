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
| **Stopwatch**      | **1**      |  **61.90 ns** | **2.555 ns** | **0.140 ns** |  **61.82 ns** |  **62.06 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.44 ns | 0.809 ns | 0.044 ns |  57.39 ns |  57.48 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.74 ns** | **4.471 ns** | **0.245 ns** | **120.51 ns** | **121.00 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.66 ns | 0.781 ns | 0.043 ns | 114.61 ns | 114.69 ns |      - |         - |
