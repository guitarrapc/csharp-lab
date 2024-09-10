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
| **Stopwatch**      | **1**      |  **61.49 ns** | **2.386 ns** | **0.131 ns** |  **61.40 ns** |  **61.64 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.52 ns | 0.135 ns | 0.007 ns |  56.51 ns |  56.53 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.77 ns** | **4.703 ns** | **0.258 ns** | **119.60 ns** | **120.07 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.98 ns | 0.063 ns | 0.003 ns | 113.98 ns | 113.99 ns |      - |         - |
