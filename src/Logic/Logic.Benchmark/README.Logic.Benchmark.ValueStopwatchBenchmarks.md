```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.03 ns** | **15.748 ns** | **0.863 ns** |  **61.38 ns** |  **63.01 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.58 ns |  1.414 ns | 0.078 ns |  56.49 ns |  56.63 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.64 ns** |  **5.304 ns** | **0.291 ns** | **119.43 ns** | **119.97 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.05 ns |  0.594 ns | 0.033 ns | 114.04 ns | 114.09 ns |      - |         - |
