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
| **Stopwatch**      | **1**      |  **60.43 ns** |  **0.776 ns** | **0.043 ns** |  **60.38 ns** |  **60.46 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.62 ns |  0.785 ns | 0.043 ns |  55.57 ns |  55.65 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.28 ns** | **12.495 ns** | **0.685 ns** | **316.74 ns** | **318.05 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 309.63 ns | 34.454 ns | 1.889 ns | 308.51 ns | 311.81 ns |      - |         - |
