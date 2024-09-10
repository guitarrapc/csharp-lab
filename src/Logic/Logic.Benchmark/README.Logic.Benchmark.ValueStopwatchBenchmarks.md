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
| **Stopwatch**      | **1**      |  **61.63 ns** | **1.587 ns** | **0.087 ns** |  **61.56 ns** |  **61.73 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.08 ns | 1.234 ns | 0.068 ns |  57.02 ns |  57.15 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.21 ns** | **4.504 ns** | **0.247 ns** | **119.95 ns** | **120.43 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.02 ns | 0.759 ns | 0.042 ns | 113.99 ns | 114.07 ns |      - |         - |
