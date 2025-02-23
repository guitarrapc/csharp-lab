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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **59.75 ns** |  **9.353 ns** | **0.513 ns** |  **59.32 ns** |  **60.32 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  61.54 ns |  8.345 ns | 0.457 ns |  61.24 ns |  62.07 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  62.47 ns |  6.973 ns | 0.382 ns |  62.03 ns |  62.73 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.92 ns |  0.378 ns | 0.021 ns |  19.90 ns |  19.94 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.91 ns |  0.631 ns | 0.035 ns |  19.87 ns |  19.93 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.48 ns |  3.992 ns | 0.219 ns |  19.27 ns |  19.71 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  57.58 ns |  5.871 ns | 0.322 ns |  57.34 ns |  57.94 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.19 ns |  2.339 ns | 0.128 ns |  57.07 ns |  57.33 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  58.21 ns | 11.965 ns | 0.656 ns |  57.46 ns |  58.69 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.05 ns |  1.308 ns | 0.072 ns |  19.97 ns |  20.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.17 ns |  1.544 ns | 0.085 ns |  20.10 ns |  20.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.33 ns |  0.588 ns | 0.032 ns |  19.30 ns |  19.37 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **178.80 ns** |  **6.073 ns** | **0.333 ns** | **178.48 ns** | **179.14 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 179.90 ns | 27.238 ns | 1.493 ns | 178.81 ns | 181.60 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 203.93 ns | 17.022 ns | 0.933 ns | 203.36 ns | 205.01 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.16 ns |  0.052 ns | 0.003 ns |  59.16 ns |  59.17 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.59 ns |  1.262 ns | 0.069 ns |  58.55 ns |  58.67 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.70 ns |  3.381 ns | 0.185 ns |  57.52 ns |  57.89 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 170.17 ns | 22.923 ns | 1.256 ns | 168.75 ns | 171.12 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 171.95 ns | 21.515 ns | 1.179 ns | 170.60 ns | 172.72 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 173.86 ns | 16.309 ns | 0.894 ns | 172.84 ns | 174.49 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.33 ns |  1.899 ns | 0.104 ns |  59.25 ns |  59.45 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.09 ns |  0.098 ns | 0.005 ns |  59.09 ns |  59.10 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.67 ns |  1.389 ns | 0.076 ns |  57.63 ns |  57.76 ns |      - |         - |
