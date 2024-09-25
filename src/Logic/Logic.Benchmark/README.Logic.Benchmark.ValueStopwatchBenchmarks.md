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
| **Stopwatch**      | **1**      |  **61.94 ns** | **4.687 ns** | **0.257 ns** |  **61.76 ns** |  **62.23 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.47 ns | 0.962 ns | 0.053 ns |  57.42 ns |  57.52 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.83 ns** | **8.893 ns** | **0.487 ns** | **120.31 ns** | **121.28 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.63 ns | 0.414 ns | 0.023 ns | 114.61 ns | 114.66 ns |      - |         - |
