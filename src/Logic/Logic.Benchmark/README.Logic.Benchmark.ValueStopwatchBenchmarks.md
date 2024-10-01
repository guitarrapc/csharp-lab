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
| **Stopwatch**      | **1**      |  **61.96 ns** | **2.503 ns** | **0.137 ns** |  **61.87 ns** |  **62.12 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.45 ns | 0.234 ns | 0.013 ns |  57.43 ns |  57.46 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.67 ns** | **5.215 ns** | **0.286 ns** | **120.47 ns** | **121.00 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.61 ns | 0.228 ns | 0.013 ns | 114.60 ns | 114.63 ns |      - |         - |
