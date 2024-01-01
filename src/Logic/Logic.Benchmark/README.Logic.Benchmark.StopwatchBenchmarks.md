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
| **Stopwatch**      | **1**      |  **60.17 ns** |  **1.983 ns** | **0.109 ns** |  **60.09 ns** |  **60.29 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.89 ns |  0.628 ns | 0.034 ns |  55.87 ns |  55.93 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.02 ns** | **18.657 ns** | **1.023 ns** | **316.40 ns** | **318.20 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.69 ns |  6.261 ns | 0.343 ns | 308.43 ns | 309.08 ns |      - |         - |
