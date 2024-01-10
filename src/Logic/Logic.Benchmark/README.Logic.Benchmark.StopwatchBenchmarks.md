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
| **Stopwatch**      | **1**      |  **60.05 ns** |  **3.468 ns** | **0.190 ns** |  **59.85 ns** |  **60.23 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.87 ns |  0.610 ns | 0.033 ns |  55.85 ns |  55.91 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.72 ns** | **11.083 ns** | **0.607 ns** | **316.30 ns** | **317.42 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.48 ns |  2.259 ns | 0.124 ns | 308.40 ns | 308.62 ns |      - |         - |
