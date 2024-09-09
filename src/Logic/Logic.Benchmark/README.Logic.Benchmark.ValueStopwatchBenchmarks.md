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
| **Stopwatch**      | **1**      |  **61.75 ns** | **1.844 ns** | **0.101 ns** |  **61.67 ns** |  **61.86 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns | 0.148 ns | 0.008 ns |  57.12 ns |  57.13 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.00 ns** | **6.226 ns** | **0.341 ns** | **119.77 ns** | **120.40 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.12 ns | 2.363 ns | 0.129 ns | 114.01 ns | 114.26 ns |      - |         - |
