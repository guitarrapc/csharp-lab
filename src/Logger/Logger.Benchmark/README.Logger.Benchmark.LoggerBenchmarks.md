```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.82 ns** |  **5.568 ns** | **0.305 ns** |  **58.61 ns** |  **59.17 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  59.95 ns |  3.363 ns | 0.184 ns |  59.76 ns |  60.13 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  59.07 ns | 21.230 ns | 1.164 ns |  57.73 ns |  59.82 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  20.21 ns |  5.849 ns | 0.321 ns |  20.02 ns |  20.58 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.96 ns |  0.989 ns | 0.054 ns |  19.92 ns |  20.02 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.26 ns |  0.427 ns | 0.023 ns |  19.24 ns |  19.29 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  58.22 ns |  1.972 ns | 0.108 ns |  58.10 ns |  58.31 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  58.14 ns |  9.963 ns | 0.546 ns |  57.73 ns |  58.76 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.62 ns |  1.892 ns | 0.104 ns |  57.53 ns |  57.74 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.96 ns |  1.263 ns | 0.069 ns |  19.88 ns |  20.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.27 ns |  0.243 ns | 0.013 ns |  20.26 ns |  20.28 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.33 ns |  0.636 ns | 0.035 ns |  19.30 ns |  19.37 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **175.09 ns** | **11.898 ns** | **0.652 ns** | **174.45 ns** | **175.76 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 173.70 ns | 16.361 ns | 0.897 ns | 172.68 ns | 174.37 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 173.94 ns | 10.277 ns | 0.563 ns | 173.43 ns | 174.54 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.56 ns |  2.903 ns | 0.159 ns |  59.47 ns |  59.75 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.58 ns |  1.285 ns | 0.070 ns |  58.54 ns |  58.66 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  58.06 ns |  1.685 ns | 0.092 ns |  57.97 ns |  58.16 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 177.64 ns | 43.703 ns | 2.395 ns | 175.01 ns | 179.70 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 183.67 ns | 37.442 ns | 2.052 ns | 182.09 ns | 185.99 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 172.39 ns | 12.779 ns | 0.700 ns | 171.68 ns | 173.08 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  60.17 ns |  3.832 ns | 0.210 ns |  60.02 ns |  60.41 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.65 ns |  0.246 ns | 0.014 ns |  58.64 ns |  58.66 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.58 ns |  4.419 ns | 0.242 ns |  57.41 ns |  57.86 ns |      - |         - |
