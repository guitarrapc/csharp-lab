```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.15 ns** |  **6.544 ns** | **0.359 ns** |  **59.90 ns** |  **60.56 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.89 ns |  0.745 ns | 0.041 ns |  55.86 ns |  55.94 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.26 ns** | **13.502 ns** | **0.740 ns** | **316.42 ns** | **317.83 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.99 ns | 21.235 ns | 1.164 ns | 308.29 ns | 310.33 ns |      - |         - |
