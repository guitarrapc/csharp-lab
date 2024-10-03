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
| **Stopwatch**      | **1**      |  **61.97 ns** | **3.653 ns** | **0.200 ns** |  **61.79 ns** |  **62.18 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.45 ns | 0.239 ns | 0.013 ns |  57.44 ns |  57.46 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.70 ns** | **4.325 ns** | **0.237 ns** | **120.51 ns** | **120.96 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.67 ns | 0.384 ns | 0.021 ns | 114.65 ns | 114.68 ns |      - |         - |
