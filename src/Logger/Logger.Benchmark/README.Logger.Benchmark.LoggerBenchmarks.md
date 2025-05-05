```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.16 ns** |  **10.226 ns** | **0.561 ns** |  **57.78 ns** |  **58.80 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  59.33 ns |  15.617 ns | 0.856 ns |  58.76 ns |  60.32 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  58.78 ns |  17.755 ns | 0.973 ns |  57.92 ns |  59.84 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  26.90 ns | 110.177 ns | 6.039 ns |  19.93 ns |  30.56 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.95 ns |   0.906 ns | 0.050 ns |  19.92 ns |  20.01 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.48 ns |   3.734 ns | 0.205 ns |  19.35 ns |  19.72 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  56.68 ns |   7.987 ns | 0.438 ns |  56.37 ns |  57.18 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.35 ns |   4.361 ns | 0.239 ns |  57.13 ns |  57.60 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  56.82 ns |   8.699 ns | 0.477 ns |  56.28 ns |  57.19 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.95 ns |   1.055 ns | 0.058 ns |  19.89 ns |  19.99 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.06 ns |   0.577 ns | 0.032 ns |  20.03 ns |  20.09 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.29 ns |   0.875 ns | 0.048 ns |  19.25 ns |  19.34 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **173.75 ns** |  **15.835 ns** | **0.868 ns** | **173.19 ns** | **174.75 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 171.47 ns |   7.484 ns | 0.410 ns | 171.09 ns | 171.90 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 172.28 ns |  18.352 ns | 1.006 ns | 171.42 ns | 173.39 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.28 ns |   1.062 ns | 0.058 ns |  59.25 ns |  59.35 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.65 ns |   2.995 ns | 0.164 ns |  58.47 ns |  58.80 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.51 ns |   3.513 ns | 0.193 ns |  57.39 ns |  57.74 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 169.21 ns |  34.061 ns | 1.867 ns | 167.87 ns | 171.34 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 167.77 ns |   6.476 ns | 0.355 ns | 167.45 ns | 168.15 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 173.43 ns | 129.767 ns | 7.113 ns | 168.94 ns | 181.63 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.94 ns |   0.670 ns | 0.037 ns |  59.91 ns |  59.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.29 ns |   3.673 ns | 0.201 ns |  58.17 ns |  58.52 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.49 ns |   3.469 ns | 0.190 ns |  57.38 ns |  57.71 ns |      - |         - |
