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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **57.98 ns** |  **6.877 ns** | **0.377 ns** |  **57.73 ns** |  **58.42 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  57.87 ns | 18.974 ns | 1.040 ns |  57.22 ns |  59.07 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.57 ns |  1.823 ns | 0.100 ns |  57.50 ns |  57.68 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.90 ns |  0.431 ns | 0.024 ns |  19.88 ns |  19.93 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.91 ns |  0.189 ns | 0.010 ns |  19.90 ns |  19.92 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.37 ns |  0.324 ns | 0.018 ns |  19.35 ns |  19.38 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  60.70 ns |  7.265 ns | 0.398 ns |  60.41 ns |  61.16 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.20 ns |  8.628 ns | 0.473 ns |  56.69 ns |  57.62 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  56.93 ns |  7.751 ns | 0.425 ns |  56.64 ns |  57.42 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.00 ns |  0.449 ns | 0.025 ns |  19.97 ns |  20.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.17 ns |  0.586 ns | 0.032 ns |  20.13 ns |  20.19 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.23 ns |  0.153 ns | 0.008 ns |  19.22 ns |  19.24 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **174.29 ns** | **20.555 ns** | **1.127 ns** | **173.44 ns** | **175.57 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 178.47 ns |  4.421 ns | 0.242 ns | 178.25 ns | 178.73 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 184.01 ns | 80.008 ns | 4.385 ns | 181.13 ns | 189.05 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.54 ns |  0.367 ns | 0.020 ns |  59.51 ns |  59.55 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.51 ns |  0.692 ns | 0.038 ns |  58.47 ns |  58.54 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.50 ns |  0.791 ns | 0.043 ns |  57.45 ns |  57.53 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 178.36 ns | 40.169 ns | 2.202 ns | 175.90 ns | 180.13 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 169.76 ns | 33.957 ns | 1.861 ns | 167.75 ns | 171.43 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 170.17 ns | 37.119 ns | 2.035 ns | 168.85 ns | 172.51 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  60.50 ns | 31.764 ns | 1.741 ns |  59.40 ns |  62.51 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.38 ns |  0.291 ns | 0.016 ns |  58.37 ns |  58.40 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  56.94 ns |  0.231 ns | 0.013 ns |  56.93 ns |  56.95 ns |      - |         - |
