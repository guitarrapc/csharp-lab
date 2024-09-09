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
| **Stopwatch**      | **1**      |  **61.73 ns** | **1.761 ns** | **0.097 ns** |  **61.64 ns** |  **61.83 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.09 ns | 1.253 ns | 0.069 ns |  57.03 ns |  57.16 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.22 ns** | **5.903 ns** | **0.324 ns** | **119.84 ns** | **120.43 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.08 ns | 1.233 ns | 0.068 ns | 114.01 ns | 114.15 ns |      - |         - |
