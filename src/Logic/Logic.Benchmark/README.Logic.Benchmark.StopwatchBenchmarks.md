```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|--------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **Stopwatch**      | **1**      |    **60.32 ns** |  **2.989 ns** | **0.164 ns** |    **60.21 ns** |    **60.51 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |    55.89 ns |  0.534 ns | 0.029 ns |    55.85 ns |    55.91 ns |      - |         - |
| **Stopwatch**      | **10**     |   **316.96 ns** |  **8.881 ns** | **0.487 ns** |   **316.43 ns** |   **317.38 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     |   308.49 ns |  1.790 ns | 0.098 ns |   308.42 ns |   308.60 ns |      - |         - |
| **Stopwatch**      | **100**    | **2,886.74 ns** | **90.296 ns** | **4.949 ns** | **2,883.84 ns** | **2,892.45 ns** |      **-** |      **40 B** |
| ValueStopwatch | 100    | 2,844.54 ns | 77.094 ns | 4.226 ns | 2,841.41 ns | 2,849.35 ns |      - |         - |
