```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.92 ns** | **2.049 ns** | **0.112 ns** |  **61.83 ns** |  **62.04 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.11 ns | 0.515 ns | 0.028 ns |  57.08 ns |  57.13 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.25 ns** | **4.900 ns** | **0.269 ns** | **119.98 ns** | **120.52 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.16 ns | 3.872 ns | 0.212 ns | 114.02 ns | 114.40 ns |      - |         - |
