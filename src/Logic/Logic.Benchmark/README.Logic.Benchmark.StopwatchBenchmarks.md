```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|--------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **Stopwatch**      | **1**      |    **60.73 ns** |   **2.400 ns** | **0.132 ns** |    **60.63 ns** |    **60.88 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |    55.89 ns |   2.992 ns | 0.164 ns |    55.76 ns |    56.07 ns |      - |         - |
| **Stopwatch**      | **10**     |   **316.93 ns** |   **7.121 ns** | **0.390 ns** |   **316.68 ns** |   **317.38 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     |   308.60 ns |   2.348 ns | 0.129 ns |   308.50 ns |   308.74 ns |      - |         - |
| **Stopwatch**      | **100**    | **2,891.17 ns** | **116.819 ns** | **6.403 ns** | **2,884.73 ns** | **2,897.54 ns** |      **-** |      **40 B** |
| ValueStopwatch | 100    | 2,844.43 ns |  38.644 ns | 2.118 ns | 2,842.99 ns | 2,846.86 ns |      - |         - |
