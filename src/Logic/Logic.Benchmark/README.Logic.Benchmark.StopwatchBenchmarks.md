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
| **Stopwatch**      | **1**      |  **60.35 ns** |  **2.257 ns** | **0.124 ns** |  **60.22 ns** |  **60.46 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.93 ns |  1.101 ns | 0.060 ns |  55.87 ns |  55.99 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.98 ns** | **11.800 ns** | **0.647 ns** | **316.32 ns** | **317.62 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.43 ns |  0.408 ns | 0.022 ns | 308.41 ns | 308.46 ns |      - |         - |
