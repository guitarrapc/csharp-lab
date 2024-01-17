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
| **Stopwatch**      | **1**      |  **60.67 ns** |  **2.359 ns** | **0.129 ns** |  **60.52 ns** |  **60.78 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.89 ns |  0.218 ns | 0.012 ns |  55.87 ns |  55.90 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.60 ns** | **10.458 ns** | **0.573 ns** | **316.17 ns** | **317.25 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.46 ns |  0.985 ns | 0.054 ns | 308.40 ns | 308.50 ns |      - |         - |
