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
| **Stopwatch**      | **1**      |  **61.74 ns** | **22.812 ns** | **1.250 ns** |  **60.99 ns** |  **63.18 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.90 ns |  0.630 ns | 0.035 ns |  55.88 ns |  55.94 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.76 ns** | **24.028 ns** | **1.317 ns** | **316.41 ns** | **319.04 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.80 ns |  9.845 ns | 0.540 ns | 308.48 ns | 309.43 ns |      - |         - |
