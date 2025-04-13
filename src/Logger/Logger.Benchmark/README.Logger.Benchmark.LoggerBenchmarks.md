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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.63 ns** |  **4.895 ns** | **0.268 ns** |  **58.33 ns** |  **58.86 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  56.67 ns |  0.967 ns | 0.053 ns |  56.62 ns |  56.73 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  56.48 ns |  2.621 ns | 0.144 ns |  56.33 ns |  56.60 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.93 ns |  1.123 ns | 0.062 ns |  19.87 ns |  19.99 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.88 ns |  1.102 ns | 0.060 ns |  19.84 ns |  19.95 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.52 ns |  4.592 ns | 0.252 ns |  19.23 ns |  19.70 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  56.84 ns | 13.618 ns | 0.746 ns |  56.34 ns |  57.70 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  56.15 ns |  1.244 ns | 0.068 ns |  56.07 ns |  56.20 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  56.48 ns |  3.765 ns | 0.206 ns |  56.25 ns |  56.65 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.06 ns |  1.400 ns | 0.077 ns |  19.99 ns |  20.14 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.18 ns |  2.152 ns | 0.118 ns |  20.11 ns |  20.32 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.94 ns |  8.610 ns | 0.472 ns |  19.40 ns |  20.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **174.93 ns** |  **9.654 ns** | **0.529 ns** | **174.55 ns** | **175.53 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 170.81 ns | 19.084 ns | 1.046 ns | 169.87 ns | 171.94 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 171.32 ns | 12.177 ns | 0.667 ns | 170.83 ns | 172.08 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.62 ns |  3.891 ns | 0.213 ns |  59.42 ns |  59.85 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.70 ns |  4.037 ns | 0.221 ns |  58.54 ns |  58.95 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.32 ns |  0.946 ns | 0.052 ns |  57.26 ns |  57.36 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 168.83 ns | 24.623 ns | 1.350 ns | 167.97 ns | 170.39 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 167.52 ns | 10.725 ns | 0.588 ns | 167.08 ns | 168.18 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 169.99 ns | 24.177 ns | 1.325 ns | 168.85 ns | 171.45 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.44 ns |  3.540 ns | 0.194 ns |  59.26 ns |  59.64 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.55 ns |  9.119 ns | 0.500 ns |  58.25 ns |  59.12 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  86.32 ns |  8.329 ns | 0.457 ns |  86.03 ns |  86.84 ns |      - |         - |
