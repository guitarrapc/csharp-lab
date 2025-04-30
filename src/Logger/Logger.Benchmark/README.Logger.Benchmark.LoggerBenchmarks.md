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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.74 ns** |  **6.824 ns** | **0.374 ns** |  **58.36 ns** |  **59.11 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  57.24 ns |  6.544 ns | 0.359 ns |  56.83 ns |  57.50 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.67 ns |  2.225 ns | 0.122 ns |  57.57 ns |  57.81 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  20.01 ns |  2.493 ns | 0.137 ns |  19.88 ns |  20.15 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  20.07 ns |  0.874 ns | 0.048 ns |  20.03 ns |  20.12 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.33 ns |  1.451 ns | 0.080 ns |  19.25 ns |  19.40 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  58.43 ns |  5.555 ns | 0.304 ns |  58.10 ns |  58.70 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.15 ns |  9.361 ns | 0.513 ns |  56.59 ns |  57.59 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.36 ns |  1.975 ns | 0.108 ns |  57.26 ns |  57.48 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.97 ns |  3.175 ns | 0.174 ns |  19.85 ns |  20.17 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.02 ns |  0.446 ns | 0.024 ns |  19.99 ns |  20.04 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.75 ns |  9.152 ns | 0.502 ns |  19.45 ns |  20.33 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **173.52 ns** | **20.676 ns** | **1.133 ns** | **172.22 ns** | **174.26 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 175.18 ns |  1.716 ns | 0.094 ns | 175.08 ns | 175.27 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 176.84 ns | 30.016 ns | 1.645 ns | 175.47 ns | 178.66 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.38 ns |  4.441 ns | 0.243 ns |  59.23 ns |  59.66 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.48 ns |  0.343 ns | 0.019 ns |  58.47 ns |  58.50 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.47 ns |  1.718 ns | 0.094 ns |  57.37 ns |  57.55 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 171.96 ns | 20.205 ns | 1.108 ns | 171.28 ns | 173.24 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 169.86 ns | 35.210 ns | 1.930 ns | 168.27 ns | 172.01 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 183.90 ns | 22.057 ns | 1.209 ns | 182.52 ns | 184.77 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.24 ns |  1.188 ns | 0.065 ns |  59.18 ns |  59.31 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.23 ns |  0.530 ns | 0.029 ns |  58.20 ns |  58.25 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.05 ns |  3.590 ns | 0.197 ns |  56.91 ns |  57.28 ns |      - |         - |
