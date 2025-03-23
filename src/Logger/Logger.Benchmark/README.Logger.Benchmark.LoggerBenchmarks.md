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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **59.13 ns** | **13.721 ns** | **0.752 ns** |  **58.44 ns** |  **59.93 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  57.75 ns | 16.183 ns | 0.887 ns |  57.12 ns |  58.76 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  58.42 ns | 15.315 ns | 0.839 ns |  57.72 ns |  59.35 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.95 ns |  1.904 ns | 0.104 ns |  19.89 ns |  20.07 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.93 ns |  0.617 ns | 0.034 ns |  19.91 ns |  19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.24 ns |  0.153 ns | 0.008 ns |  19.23 ns |  19.24 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  60.26 ns |  5.781 ns | 0.317 ns |  59.93 ns |  60.56 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  59.25 ns | 25.081 ns | 1.375 ns |  58.44 ns |  60.83 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  56.46 ns | 19.256 ns | 1.055 ns |  55.65 ns |  57.66 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.01 ns |  1.312 ns | 0.072 ns |  19.97 ns |  20.09 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.12 ns |  0.262 ns | 0.014 ns |  20.11 ns |  20.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  20.17 ns |  0.302 ns | 0.017 ns |  20.15 ns |  20.18 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **172.74 ns** | **13.021 ns** | **0.714 ns** | **172.05 ns** | **173.48 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 171.43 ns | 14.338 ns | 0.786 ns | 170.62 ns | 172.19 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 207.82 ns | 32.791 ns | 1.797 ns | 205.74 ns | 208.91 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  60.07 ns |  2.798 ns | 0.153 ns |  59.98 ns |  60.25 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.84 ns |  9.671 ns | 0.530 ns |  58.51 ns |  59.45 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  59.64 ns |  0.931 ns | 0.051 ns |  59.58 ns |  59.68 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 171.69 ns | 90.860 ns | 4.980 ns | 166.89 ns | 176.84 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 172.55 ns |  9.662 ns | 0.530 ns | 172.24 ns | 173.16 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 170.92 ns | 21.206 ns | 1.162 ns | 169.58 ns | 171.60 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.42 ns |  3.467 ns | 0.190 ns |  59.29 ns |  59.63 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.15 ns |  5.945 ns | 0.326 ns |  58.93 ns |  59.52 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.04 ns |  0.349 ns | 0.019 ns |  57.02 ns |  57.06 ns |      - |         - |
