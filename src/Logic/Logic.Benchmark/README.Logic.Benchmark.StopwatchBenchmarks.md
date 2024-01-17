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
| **Stopwatch**      | **1**      |  **60.92 ns** |  **2.615 ns** | **0.143 ns** |  **60.82 ns** |  **61.08 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.77 ns |  0.293 ns | 0.016 ns |  55.75 ns |  55.78 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.54 ns** | **17.625 ns** | **0.966 ns** | **316.71 ns** | **318.60 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.45 ns |  2.138 ns | 0.117 ns | 308.32 ns | 308.54 ns |      - |         - |
