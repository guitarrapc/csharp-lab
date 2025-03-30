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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **57.79 ns** |  **6.618 ns** | **0.363 ns** |  **57.57 ns** |  **58.21 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.70 ns | 12.612 ns | 0.691 ns |  57.92 ns |  59.23 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.06 ns |  5.193 ns | 0.285 ns |  56.73 ns |  57.23 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.98 ns |  2.029 ns | 0.111 ns |  19.91 ns |  20.11 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.80 ns |  0.176 ns | 0.010 ns |  19.79 ns |  19.81 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.40 ns |  0.986 ns | 0.054 ns |  19.35 ns |  19.46 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  55.69 ns |  2.638 ns | 0.145 ns |  55.56 ns |  55.85 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  58.79 ns |  8.171 ns | 0.448 ns |  58.28 ns |  59.13 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  56.30 ns |  2.395 ns | 0.131 ns |  56.15 ns |  56.40 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.97 ns |  0.641 ns | 0.035 ns |  19.95 ns |  20.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.09 ns |  2.045 ns | 0.112 ns |  20.00 ns |  20.21 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.62 ns | 10.105 ns | 0.554 ns |  19.27 ns |  20.26 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **171.11 ns** |  **5.802 ns** | **0.318 ns** | **170.76 ns** | **171.38 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 189.32 ns | 31.289 ns | 1.715 ns | 188.33 ns | 191.30 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 174.13 ns |  9.758 ns | 0.535 ns | 173.64 ns | 174.70 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.28 ns |  3.842 ns | 0.211 ns |  59.15 ns |  59.53 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.71 ns |  3.063 ns | 0.168 ns |  58.57 ns |  58.90 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.99 ns |  1.480 ns | 0.081 ns |  57.90 ns |  58.06 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 166.32 ns |  5.141 ns | 0.282 ns | 166.12 ns | 166.64 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 173.00 ns |  1.834 ns | 0.101 ns | 172.89 ns | 173.08 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 167.90 ns | 43.253 ns | 2.371 ns | 166.41 ns | 170.63 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.28 ns |  0.402 ns | 0.022 ns |  59.26 ns |  59.30 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.95 ns |  3.363 ns | 0.184 ns |  58.82 ns |  59.16 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.02 ns |  0.980 ns | 0.054 ns |  56.96 ns |  57.06 ns |      - |         - |
