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
| **Stopwatch**      | **1**      |  **61.59 ns** | **2.594 ns** | **0.142 ns** |  **61.45 ns** |  **61.73 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns | 0.078 ns | 0.004 ns |  57.12 ns |  57.13 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.88 ns** | **4.200 ns** | **0.230 ns** | **119.74 ns** | **120.14 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.00 ns | 0.243 ns | 0.013 ns | 113.99 ns | 114.01 ns |      - |         - |
