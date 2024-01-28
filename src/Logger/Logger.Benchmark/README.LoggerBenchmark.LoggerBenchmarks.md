```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **59.68 ns** |   **4.645 ns** |  **0.255 ns** |    **59.53 ns** |    **59.97 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    58.40 ns |   0.995 ns |  0.055 ns |    58.35 ns |    58.46 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.39 ns |   8.792 ns |  0.482 ns |    65.05 ns |    65.94 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.86 ns |   2.539 ns |  0.139 ns |    19.77 ns |    20.02 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.87 ns |   0.287 ns |  0.016 ns |    19.86 ns |    19.89 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.19 ns |   0.283 ns |  0.016 ns |    19.17 ns |    19.20 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **609.87 ns** |  **36.700 ns** |  **2.012 ns** |   **607.69 ns** |   **611.66 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   598.49 ns |  52.318 ns |  2.868 ns |   595.18 ns |   600.19 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   670.94 ns |  29.092 ns |  1.595 ns |   669.11 ns |   672.04 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.15 ns |   2.728 ns |  0.150 ns |   198.00 ns |   198.30 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.08 ns |   7.682 ns |  0.421 ns |   196.82 ns |   197.57 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.11 ns |   9.737 ns |  0.534 ns |   191.72 ns |   192.72 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,759.97 ns** | **139.928 ns** |  **7.670 ns** | **6,753.96 ns** | **6,768.61 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,981.56 ns | 293.938 ns | 16.112 ns | 5,968.92 ns | 5,999.70 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 8,815.86 ns | 310.519 ns | 17.021 ns | 8,800.55 ns | 8,834.19 ns | 0.0916 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,990.52 ns | 136.310 ns |  7.472 ns | 1,985.07 ns | 1,999.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,986.35 ns |  58.385 ns |  3.200 ns | 1,983.20 ns | 1,989.60 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,931.27 ns | 284.558 ns | 15.598 ns | 1,921.43 ns | 1,949.25 ns |      - |         - |
