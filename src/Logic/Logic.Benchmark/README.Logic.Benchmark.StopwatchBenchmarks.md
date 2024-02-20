```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **59.88 ns** | **3.459 ns** | **0.190 ns** |  **59.75 ns** |  **60.09 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.88 ns | 0.366 ns | 0.020 ns |  55.86 ns |  55.90 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.59 ns** | **9.279 ns** | **0.509 ns** | **316.12 ns** | **317.13 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.48 ns | 1.272 ns | 0.070 ns | 308.41 ns | 308.55 ns |      - |         - |
