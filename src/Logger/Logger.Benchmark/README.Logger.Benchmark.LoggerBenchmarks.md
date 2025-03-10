```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **57.78 ns** |   **4.469 ns** | **0.245 ns** |  **57.54 ns** |  **58.03 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.27 ns |   9.067 ns | 0.497 ns |  57.90 ns |  58.83 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  58.02 ns |   4.598 ns | 0.252 ns |  57.73 ns |  58.17 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.91 ns |   0.605 ns | 0.033 ns |  19.88 ns |  19.94 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  26.86 ns | 110.202 ns | 6.041 ns |  19.88 ns |  30.36 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.36 ns |   1.479 ns | 0.081 ns |  19.27 ns |  19.42 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  60.25 ns |  16.295 ns | 0.893 ns |  59.54 ns |  61.25 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.53 ns |   3.870 ns | 0.212 ns |  57.31 ns |  57.73 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  64.97 ns |  14.545 ns | 0.797 ns |  64.34 ns |  65.87 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.00 ns |   0.681 ns | 0.037 ns |  19.97 ns |  20.05 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.13 ns |   0.048 ns | 0.003 ns |  20.13 ns |  20.14 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.34 ns |   0.556 ns | 0.030 ns |  19.31 ns |  19.37 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **184.15 ns** |   **5.620 ns** | **0.308 ns** | **183.96 ns** | **184.51 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 172.88 ns |  29.984 ns | 1.644 ns | 171.01 ns | 174.09 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 182.04 ns |  39.531 ns | 2.167 ns | 180.75 ns | 184.54 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.72 ns |   7.398 ns | 0.406 ns |  59.48 ns |  60.19 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.57 ns |   2.227 ns | 0.122 ns |  58.48 ns |  58.71 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.95 ns |   0.423 ns | 0.023 ns |  57.93 ns |  57.98 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 164.79 ns |   5.168 ns | 0.283 ns | 164.52 ns | 165.09 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 169.07 ns |  21.799 ns | 1.195 ns | 168.11 ns | 170.41 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 174.63 ns |  31.806 ns | 1.743 ns | 173.36 ns | 176.62 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.57 ns |   1.023 ns | 0.056 ns |  59.52 ns |  59.63 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.48 ns |   2.534 ns | 0.139 ns |  58.33 ns |  58.60 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.68 ns |   4.259 ns | 0.233 ns |  57.44 ns |  57.90 ns |      - |         - |
