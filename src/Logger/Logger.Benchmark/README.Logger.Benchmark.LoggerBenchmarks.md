```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **60.63 ns** |  **6.333 ns** | **0.347 ns** |  **60.27 ns** |  **60.97 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  62.16 ns |  5.875 ns | 0.322 ns |  61.82 ns |  62.46 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  59.81 ns |  6.920 ns | 0.379 ns |  59.38 ns |  60.10 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.96 ns |  1.770 ns | 0.097 ns |  19.89 ns |  20.07 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.97 ns |  1.212 ns | 0.066 ns |  19.92 ns |  20.05 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.25 ns |  0.042 ns | 0.002 ns |  19.24 ns |  19.25 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  57.93 ns |  9.194 ns | 0.504 ns |  57.39 ns |  58.39 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.86 ns |  3.390 ns | 0.186 ns |  57.65 ns |  58.01 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.96 ns |  3.123 ns | 0.171 ns |  57.79 ns |  58.14 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.97 ns |  0.194 ns | 0.011 ns |  19.96 ns |  19.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.10 ns |  0.464 ns | 0.025 ns |  20.08 ns |  20.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.31 ns |  2.154 ns | 0.118 ns |  19.23 ns |  19.45 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **183.53 ns** | **36.310 ns** | **1.990 ns** | **181.33 ns** | **185.20 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 176.10 ns |  2.897 ns | 0.159 ns | 175.93 ns | 176.24 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 175.74 ns |  4.875 ns | 0.267 ns | 175.43 ns | 175.93 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.71 ns |  1.311 ns | 0.072 ns |  59.64 ns |  59.78 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.52 ns |  0.145 ns | 0.008 ns |  58.52 ns |  58.53 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.29 ns |  0.145 ns | 0.008 ns |  57.28 ns |  57.29 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 171.58 ns |  6.840 ns | 0.375 ns | 171.20 ns | 171.95 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 172.54 ns |  6.734 ns | 0.369 ns | 172.14 ns | 172.87 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 172.42 ns | 14.273 ns | 0.782 ns | 171.53 ns | 173.02 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.29 ns |  1.812 ns | 0.099 ns |  59.21 ns |  59.40 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.14 ns |  1.346 ns | 0.074 ns |  59.08 ns |  59.22 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.99 ns |  0.445 ns | 0.024 ns |  57.97 ns |  58.02 ns |      - |         - |
