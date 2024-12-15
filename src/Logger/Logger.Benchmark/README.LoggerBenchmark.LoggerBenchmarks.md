```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.28 ns** |  **5.960 ns** | **0.327 ns** |  **60.91 ns** |  **61.53 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.85 ns | 15.568 ns | 0.853 ns |  61.25 ns |  62.83 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.63 ns |  5.896 ns | 0.323 ns |  66.28 ns |  66.90 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.70 ns |  1.912 ns | 0.105 ns |  19.59 ns |  19.80 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.73 ns |  1.286 ns | 0.070 ns |  19.66 ns |  19.80 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.16 ns |  0.310 ns | 0.017 ns |  19.14 ns |  19.18 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **177.55 ns** |  **4.213 ns** | **0.231 ns** | **177.38 ns** | **177.82 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.50 ns | 33.325 ns | 1.827 ns | 176.62 ns | 180.26 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 202.45 ns | 13.261 ns | 0.727 ns | 201.69 ns | 203.14 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.25 ns |  2.372 ns | 0.130 ns |  58.14 ns |  58.40 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.19 ns |  0.954 ns | 0.052 ns |  58.13 ns |  58.22 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  56.80 ns |  2.989 ns | 0.164 ns |  56.61 ns |  56.92 ns |      - |         - |
