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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **60.97 ns** |  **6.868 ns** | **0.376 ns** |  **60.74 ns** |  **61.41 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  59.87 ns |  5.737 ns | 0.314 ns |  59.52 ns |  60.13 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  61.78 ns | 42.777 ns | 2.345 ns |  60.34 ns |  64.49 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.92 ns |  1.405 ns | 0.077 ns |  19.87 ns |  20.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  20.03 ns |  4.144 ns | 0.227 ns |  19.90 ns |  20.29 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.36 ns |  0.673 ns | 0.037 ns |  19.33 ns |  19.40 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  58.21 ns | 19.184 ns | 1.052 ns |  57.34 ns |  59.38 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  58.19 ns |  4.440 ns | 0.243 ns |  57.99 ns |  58.46 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  58.71 ns |  2.584 ns | 0.142 ns |  58.61 ns |  58.87 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.02 ns |  1.225 ns | 0.067 ns |  19.98 ns |  20.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.16 ns |  1.635 ns | 0.090 ns |  20.11 ns |  20.27 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.32 ns |  1.774 ns | 0.097 ns |  19.26 ns |  19.43 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **183.96 ns** | **10.536 ns** | **0.578 ns** | **183.44 ns** | **184.58 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 182.14 ns | 50.026 ns | 2.742 ns | 179.75 ns | 185.14 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 175.83 ns | 17.956 ns | 0.984 ns | 175.04 ns | 176.94 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.19 ns |  0.170 ns | 0.009 ns |  59.19 ns |  59.20 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.63 ns |  3.426 ns | 0.188 ns |  58.51 ns |  58.85 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  58.07 ns |  0.442 ns | 0.024 ns |  58.05 ns |  58.09 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 176.17 ns | 12.954 ns | 0.710 ns | 175.54 ns | 176.94 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 174.68 ns | 20.078 ns | 1.101 ns | 173.64 ns | 175.84 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 178.53 ns |  6.724 ns | 0.369 ns | 178.31 ns | 178.95 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.57 ns |  8.075 ns | 0.443 ns |  59.29 ns |  60.08 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.35 ns |  3.757 ns | 0.206 ns |  58.21 ns |  58.59 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.06 ns |  1.190 ns | 0.065 ns |  57.00 ns |  57.13 ns |      - |         - |
