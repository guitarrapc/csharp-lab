```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.42 ns** |  **2.203 ns** | **0.121 ns** |  **60.34 ns** |  **60.56 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.99 ns |  2.079 ns | 0.114 ns |  55.86 ns |  56.07 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.90 ns** | **13.258 ns** | **0.727 ns** | **316.46 ns** | **317.74 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.59 ns |  2.914 ns | 0.160 ns | 308.41 ns | 308.70 ns |      - |         - |
