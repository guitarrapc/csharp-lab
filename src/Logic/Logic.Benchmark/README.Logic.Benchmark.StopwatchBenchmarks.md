```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.13 ns** |  **2.743 ns** | **0.150 ns** |  **59.99 ns** |  **60.29 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.58 ns |  0.370 ns | 0.020 ns |  55.56 ns |  55.60 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.45 ns** | **13.090 ns** | **0.718 ns** | **316.72 ns** | **318.15 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.48 ns |  0.391 ns | 0.021 ns | 308.46 ns | 308.49 ns |      - |         - |
