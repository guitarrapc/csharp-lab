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
| **Stopwatch**      | **1**      |  **61.46 ns** | **2.561 ns** | **0.140 ns** |  **61.33 ns** |  **61.61 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.10 ns | 0.044 ns | 0.002 ns |  57.10 ns |  57.11 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.76 ns** | **5.138 ns** | **0.282 ns** | **119.50 ns** | **120.06 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.34 ns | 0.686 ns | 0.038 ns | 114.31 ns | 114.38 ns |      - |         - |
