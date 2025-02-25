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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **59.58 ns** |  **7.391 ns** | **0.405 ns** |  **59.14 ns** |  **59.92 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.96 ns | 12.407 ns | 0.680 ns |  58.25 ns |  59.61 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  60.00 ns | 36.992 ns | 2.028 ns |  58.69 ns |  62.34 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.93 ns |  1.286 ns | 0.070 ns |  19.88 ns |  20.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.76 ns |  1.435 ns | 0.079 ns |  19.72 ns |  19.85 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.37 ns |  1.678 ns | 0.092 ns |  19.27 ns |  19.44 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  56.97 ns |  4.535 ns | 0.249 ns |  56.74 ns |  57.23 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  56.99 ns |  4.467 ns | 0.245 ns |  56.75 ns |  57.24 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.65 ns |  6.109 ns | 0.335 ns |  57.27 ns |  57.88 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.07 ns |  0.857 ns | 0.047 ns |  20.03 ns |  20.12 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.17 ns |  0.887 ns | 0.049 ns |  20.12 ns |  20.21 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  20.18 ns |  0.964 ns | 0.053 ns |  20.15 ns |  20.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **175.69 ns** | **36.633 ns** | **2.008 ns** | **174.18 ns** | **177.96 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 177.25 ns | 32.822 ns | 1.799 ns | 175.35 ns | 178.93 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 173.25 ns |  3.117 ns | 0.171 ns | 173.07 ns | 173.41 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.62 ns |  4.499 ns | 0.247 ns |  59.46 ns |  59.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.50 ns |  0.361 ns | 0.020 ns |  58.48 ns |  58.51 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  59.37 ns |  1.916 ns | 0.105 ns |  59.31 ns |  59.49 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 172.10 ns | 19.320 ns | 1.059 ns | 170.87 ns | 172.72 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 169.75 ns | 19.778 ns | 1.084 ns | 168.84 ns | 170.95 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 174.97 ns | 19.004 ns | 1.042 ns | 174.13 ns | 176.14 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.25 ns |  0.159 ns | 0.009 ns |  59.25 ns |  59.26 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.32 ns |  2.036 ns | 0.112 ns |  58.23 ns |  58.45 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  58.08 ns |  2.079 ns | 0.114 ns |  57.97 ns |  58.20 ns |      - |         - |
