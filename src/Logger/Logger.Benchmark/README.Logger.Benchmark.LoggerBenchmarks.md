```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **59.36 ns** | **24.359 ns** | **1.335 ns** |  **58.26 ns** |  **60.84 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.22 ns |  3.104 ns | 0.170 ns |  58.06 ns |  58.40 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.36 ns |  1.408 ns | 0.077 ns |  57.31 ns |  57.45 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.88 ns |  0.029 ns | 0.002 ns |  19.88 ns |  19.88 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  20.09 ns |  2.623 ns | 0.144 ns |  20.00 ns |  20.25 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.27 ns |  0.776 ns | 0.043 ns |  19.22 ns |  19.30 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  57.06 ns |  3.498 ns | 0.192 ns |  56.88 ns |  57.26 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  56.62 ns |  2.754 ns | 0.151 ns |  56.50 ns |  56.79 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  62.21 ns |  2.200 ns | 0.121 ns |  62.10 ns |  62.34 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.93 ns |  1.719 ns | 0.094 ns |  19.86 ns |  20.04 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.18 ns |  2.340 ns | 0.128 ns |  20.11 ns |  20.33 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.30 ns |  2.461 ns | 0.135 ns |  19.22 ns |  19.45 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **172.88 ns** | **13.124 ns** | **0.719 ns** | **172.05 ns** | **173.35 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 169.77 ns | 12.817 ns | 0.703 ns | 169.26 ns | 170.57 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 173.67 ns | 17.871 ns | 0.980 ns | 172.94 ns | 174.79 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.53 ns |  4.779 ns | 0.262 ns |  59.28 ns |  59.80 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.64 ns |  0.186 ns | 0.010 ns |  58.63 ns |  58.65 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.49 ns |  2.502 ns | 0.137 ns |  57.34 ns |  57.61 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 168.56 ns | 16.078 ns | 0.881 ns | 167.95 ns | 169.57 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 167.56 ns |  5.387 ns | 0.295 ns | 167.23 ns | 167.79 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 168.15 ns |  4.100 ns | 0.225 ns | 167.93 ns | 168.38 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.44 ns |  0.878 ns | 0.048 ns |  59.39 ns |  59.49 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.31 ns |  1.527 ns | 0.084 ns |  58.21 ns |  58.38 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.11 ns |  1.819 ns | 0.100 ns |  57.03 ns |  57.22 ns |      - |         - |
