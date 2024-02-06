```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.94 ns** |  **3.035 ns** | **0.166 ns** |  **60.75 ns** |  **61.05 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.83 ns |  0.334 ns | 0.018 ns |  55.81 ns |  55.85 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.75 ns** | **15.039 ns** | **0.824 ns** | **316.11 ns** | **317.68 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.61 ns |  4.010 ns | 0.220 ns | 308.45 ns | 308.86 ns |      - |         - |
