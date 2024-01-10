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
| **Stopwatch**      | **1**      |  **60.40 ns** |  **2.615 ns** | **0.143 ns** |  **60.24 ns** |  **60.49 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.93 ns |  1.104 ns | 0.060 ns |  55.88 ns |  55.99 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.73 ns** | **10.868 ns** | **0.596 ns** | **317.25 ns** | **318.39 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.61 ns |  3.707 ns | 0.203 ns | 308.42 ns | 308.82 ns |      - |         - |
