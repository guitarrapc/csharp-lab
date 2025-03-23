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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.34 ns** |  **3.007 ns** | **0.165 ns** |  **58.19 ns** |  **58.52 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  57.06 ns |  3.670 ns | 0.201 ns |  56.86 ns |  57.26 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.72 ns |  2.405 ns | 0.132 ns |  57.58 ns |  57.84 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.91 ns |  1.280 ns | 0.070 ns |  19.87 ns |  19.99 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.93 ns |  0.790 ns | 0.043 ns |  19.89 ns |  19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.72 ns | 10.676 ns | 0.585 ns |  19.37 ns |  20.39 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  55.96 ns |  6.231 ns | 0.342 ns |  55.61 ns |  56.29 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  59.40 ns |  2.143 ns | 0.117 ns |  59.27 ns |  59.50 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  56.13 ns |  3.327 ns | 0.182 ns |  56.02 ns |  56.34 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.00 ns |  0.226 ns | 0.012 ns |  19.98 ns |  20.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.12 ns |  0.192 ns | 0.011 ns |  20.10 ns |  20.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.21 ns |  0.056 ns | 0.003 ns |  19.21 ns |  19.22 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **176.83 ns** | **19.728 ns** | **1.081 ns** | **175.58 ns** | **177.52 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 176.27 ns | 18.330 ns | 1.005 ns | 175.19 ns | 177.17 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 169.49 ns |  7.469 ns | 0.409 ns | 169.22 ns | 169.96 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.61 ns |  2.372 ns | 0.130 ns |  59.49 ns |  59.75 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.84 ns |  0.341 ns | 0.019 ns |  58.82 ns |  58.86 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  60.10 ns |  3.754 ns | 0.206 ns |  59.97 ns |  60.34 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 168.63 ns | 58.908 ns | 3.229 ns | 165.19 ns | 171.60 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 170.26 ns | 41.687 ns | 2.285 ns | 167.71 ns | 172.11 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 171.79 ns | 81.206 ns | 4.451 ns | 168.94 ns | 176.92 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.36 ns |  2.223 ns | 0.122 ns |  59.28 ns |  59.50 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.33 ns |  2.357 ns | 0.129 ns |  58.23 ns |  58.48 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.07 ns |  1.993 ns | 0.109 ns |  56.99 ns |  57.20 ns |      - |         - |
