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
| **Stopwatch**      | **1**      |    **60.31 ns** |   **3.354 ns** |  **0.184 ns** |    **60.11 ns** |    **60.47 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |    55.96 ns |   1.572 ns |  0.086 ns |    55.89 ns |    56.06 ns |      - |         - |
| **Stopwatch**      | **10**     |   **316.90 ns** |   **8.518 ns** |  **0.467 ns** |   **316.55 ns** |   **317.43 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     |   308.58 ns |   1.806 ns |  0.099 ns |   308.48 ns |   308.67 ns |      - |         - |
| **Stopwatch**      | **100**    | **2,886.47 ns** |  **69.513 ns** |  **3.810 ns** | **2,884.16 ns** | **2,890.87 ns** |      **-** |      **40 B** |
| ValueStopwatch | 100    | 2,850.55 ns | 226.753 ns | 12.429 ns | 2,841.16 ns | 2,864.65 ns |      - |         - |
