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
| **Stopwatch**      | **1**      |  **60.15 ns** | **3.588 ns** | **0.197 ns** |  **59.94 ns** |  **60.33 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.94 ns | 1.589 ns | 0.087 ns |  55.86 ns |  56.03 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.44 ns** | **9.760 ns** | **0.535 ns** | **316.07 ns** | **317.06 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.54 ns | 4.063 ns | 0.223 ns | 308.38 ns | 308.80 ns |      - |         - |
