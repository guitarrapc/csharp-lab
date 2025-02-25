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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **62.67 ns** |  **9.913 ns** | **0.543 ns** |  **62.08 ns** |  **63.15 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  61.61 ns | 14.044 ns | 0.770 ns |  60.75 ns |  62.23 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  59.39 ns |  5.511 ns | 0.302 ns |  59.08 ns |  59.69 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.92 ns |  0.411 ns | 0.023 ns |  19.90 ns |  19.94 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.95 ns |  1.756 ns | 0.096 ns |  19.88 ns |  20.06 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.52 ns |  1.542 ns | 0.085 ns |  19.43 ns |  19.59 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  60.51 ns |  2.693 ns | 0.148 ns |  60.40 ns |  60.68 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.80 ns |  6.060 ns | 0.332 ns |  57.44 ns |  58.08 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  62.53 ns |  2.912 ns | 0.160 ns |  62.37 ns |  62.68 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.97 ns |  0.365 ns | 0.020 ns |  19.95 ns |  19.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.01 ns |  0.884 ns | 0.048 ns |  19.96 ns |  20.06 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.30 ns |  1.260 ns | 0.069 ns |  19.24 ns |  19.37 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **179.34 ns** |  **4.203 ns** | **0.230 ns** | **179.09 ns** | **179.53 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 173.64 ns | 16.319 ns | 0.894 ns | 173.00 ns | 174.66 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 177.37 ns |  4.493 ns | 0.246 ns | 177.12 ns | 177.61 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  60.97 ns | 46.097 ns | 2.527 ns |  59.48 ns |  63.89 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.76 ns |  5.726 ns | 0.314 ns |  58.56 ns |  59.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.57 ns |  5.563 ns | 0.305 ns |  57.38 ns |  57.92 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 170.21 ns | 14.618 ns | 0.801 ns | 169.59 ns | 171.12 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 173.43 ns |  6.804 ns | 0.373 ns | 173.21 ns | 173.86 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 181.79 ns | 20.631 ns | 1.131 ns | 180.49 ns | 182.56 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.69 ns |  5.407 ns | 0.296 ns |  59.51 ns |  60.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.53 ns | 10.696 ns | 0.586 ns |  59.18 ns |  60.21 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.83 ns |  2.725 ns | 0.149 ns |  57.70 ns |  57.99 ns |      - |         - |
