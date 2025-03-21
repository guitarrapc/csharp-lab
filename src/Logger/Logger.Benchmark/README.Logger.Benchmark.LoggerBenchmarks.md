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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.61 ns** |  **7.575 ns** | **0.415 ns** |  **58.32 ns** |  **59.08 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  57.94 ns |  4.112 ns | 0.225 ns |  57.72 ns |  58.17 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  60.52 ns |  5.547 ns | 0.304 ns |  60.23 ns |  60.84 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  20.00 ns |  1.012 ns | 0.055 ns |  19.94 ns |  20.05 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.92 ns |  0.909 ns | 0.050 ns |  19.88 ns |  19.98 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.34 ns |  0.522 ns | 0.029 ns |  19.31 ns |  19.37 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  56.80 ns |  2.940 ns | 0.161 ns |  56.62 ns |  56.92 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  56.62 ns | 13.123 ns | 0.719 ns |  56.20 ns |  57.45 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  62.62 ns | 11.890 ns | 0.652 ns |  62.15 ns |  63.36 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.01 ns |  0.719 ns | 0.039 ns |  19.97 ns |  20.04 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.15 ns |  0.472 ns | 0.026 ns |  20.12 ns |  20.17 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.30 ns |  1.767 ns | 0.097 ns |  19.23 ns |  19.41 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **174.94 ns** | **22.665 ns** | **1.242 ns** | **174.02 ns** | **176.36 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 174.37 ns |  6.914 ns | 0.379 ns | 174.00 ns | 174.76 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 172.26 ns |  2.304 ns | 0.126 ns | 172.19 ns | 172.41 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.44 ns |  2.117 ns | 0.116 ns |  59.31 ns |  59.52 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.46 ns |  1.925 ns | 0.106 ns |  58.39 ns |  58.58 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.39 ns |  2.148 ns | 0.118 ns |  57.31 ns |  57.52 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 170.27 ns | 32.659 ns | 1.790 ns | 168.89 ns | 172.29 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 172.06 ns | 12.608 ns | 0.691 ns | 171.64 ns | 172.86 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 193.45 ns | 67.871 ns | 3.720 ns | 190.37 ns | 197.58 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.51 ns |  5.198 ns | 0.285 ns |  59.24 ns |  59.81 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.60 ns |  0.196 ns | 0.011 ns |  58.59 ns |  58.61 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  58.07 ns |  0.986 ns | 0.054 ns |  58.01 ns |  58.11 ns |      - |         - |
