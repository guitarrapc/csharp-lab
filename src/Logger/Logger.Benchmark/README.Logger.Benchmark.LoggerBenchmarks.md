```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **59.47 ns** |  **4.647 ns** | **0.255 ns** |  **59.26 ns** |  **59.76 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  59.23 ns |  8.035 ns | 0.440 ns |  58.86 ns |  59.72 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  59.35 ns | 23.567 ns | 1.292 ns |  58.14 ns |  60.71 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.93 ns |  1.038 ns | 0.057 ns |  19.90 ns |  20.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.98 ns |  1.291 ns | 0.071 ns |  19.90 ns |  20.03 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.32 ns |  0.494 ns | 0.027 ns |  19.30 ns |  19.35 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  60.92 ns | 15.418 ns | 0.845 ns |  60.04 ns |  61.72 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  58.71 ns |  1.740 ns | 0.095 ns |  58.60 ns |  58.77 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  58.14 ns | 15.825 ns | 0.867 ns |  57.47 ns |  59.12 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.02 ns |  1.267 ns | 0.069 ns |  19.97 ns |  20.09 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.23 ns |  1.805 ns | 0.099 ns |  20.12 ns |  20.30 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.35 ns |  1.236 ns | 0.068 ns |  19.27 ns |  19.40 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **180.22 ns** | **29.482 ns** | **1.616 ns** | **178.52 ns** | **181.74 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 175.63 ns | 17.021 ns | 0.933 ns | 174.97 ns | 176.70 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 177.37 ns | 30.874 ns | 1.692 ns | 175.42 ns | 178.40 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.63 ns |  3.957 ns | 0.217 ns |  59.50 ns |  59.88 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.69 ns |  3.983 ns | 0.218 ns |  58.51 ns |  58.93 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  59.48 ns |  2.451 ns | 0.134 ns |  59.34 ns |  59.61 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 175.70 ns | 72.356 ns | 3.966 ns | 172.80 ns | 180.22 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 174.43 ns | 43.119 ns | 2.363 ns | 172.37 ns | 177.01 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 174.64 ns | 24.687 ns | 1.353 ns | 173.60 ns | 176.17 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.38 ns |  3.938 ns | 0.216 ns |  59.22 ns |  59.62 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.31 ns |  4.848 ns | 0.266 ns |  58.15 ns |  58.62 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.23 ns |  3.024 ns | 0.166 ns |  57.11 ns |  57.42 ns |      - |         - |
