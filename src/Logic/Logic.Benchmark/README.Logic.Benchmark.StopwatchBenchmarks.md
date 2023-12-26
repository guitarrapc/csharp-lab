```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|--------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **Stopwatch**      | **1**      |    **60.45 ns** |   **3.423 ns** |  **0.188 ns** |    **60.27 ns** |    **60.64 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |    55.90 ns |   0.248 ns |  0.014 ns |    55.89 ns |    55.92 ns |      - |         - |
| **Stopwatch**      | **10**     |   **316.79 ns** |   **9.661 ns** |  **0.530 ns** |   **316.31 ns** |   **317.36 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     |   308.54 ns |   3.378 ns |  0.185 ns |   308.35 ns |   308.72 ns |      - |         - |
| **Stopwatch**      | **100**    | **2,900.84 ns** | **417.186 ns** | **22.867 ns** | **2,882.87 ns** | **2,926.58 ns** |      **-** |      **40 B** |
| ValueStopwatch | 100    | 2,844.18 ns |  84.045 ns |  4.607 ns | 2,840.60 ns | 2,849.38 ns |      - |         - |
