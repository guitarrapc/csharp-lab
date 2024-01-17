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
| **Stopwatch**      | **1**      |  **60.47 ns** |  **2.058 ns** | **0.113 ns** |  **60.40 ns** |  **60.60 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.88 ns |  0.301 ns | 0.017 ns |  55.87 ns |  55.90 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.91 ns** | **12.118 ns** | **0.664 ns** | **316.45 ns** | **317.67 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.45 ns |  1.738 ns | 0.095 ns | 308.39 ns | 308.56 ns |      - |         - |
