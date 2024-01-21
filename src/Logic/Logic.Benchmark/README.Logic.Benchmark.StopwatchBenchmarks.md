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
| **Stopwatch**      | **1**      |  **60.04 ns** |  **2.131 ns** | **0.117 ns** |  **59.93 ns** |  **60.16 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.88 ns |  0.389 ns | 0.021 ns |  55.87 ns |  55.91 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.81 ns** | **13.781 ns** | **0.755 ns** | **316.17 ns** | **317.64 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.43 ns |  2.600 ns | 0.142 ns | 308.34 ns | 308.60 ns |      - |         - |
