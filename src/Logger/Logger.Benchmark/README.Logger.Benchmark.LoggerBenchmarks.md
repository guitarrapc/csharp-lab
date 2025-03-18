```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.15 ns** |  **4.985 ns** | **0.273 ns** |  **57.85 ns** |  **58.39 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  59.71 ns | 22.327 ns | 1.224 ns |  58.31 ns |  60.56 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  70.58 ns | 17.673 ns | 0.969 ns |  69.93 ns |  71.70 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.94 ns |  1.520 ns | 0.083 ns |  19.87 ns |  20.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  20.65 ns | 12.057 ns | 0.661 ns |  19.89 ns |  21.06 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.27 ns |  1.030 ns | 0.056 ns |  19.23 ns |  19.33 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  56.59 ns |  5.638 ns | 0.309 ns |  56.34 ns |  56.94 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.55 ns | 11.766 ns | 0.645 ns |  57.10 ns |  58.29 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  56.71 ns |  3.312 ns | 0.182 ns |  56.50 ns |  56.83 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.96 ns |  0.231 ns | 0.013 ns |  19.96 ns |  19.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  19.94 ns |  1.467 ns | 0.080 ns |  19.89 ns |  20.03 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.26 ns |  1.105 ns | 0.061 ns |  19.22 ns |  19.33 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **184.51 ns** | **11.125 ns** | **0.610 ns** | **184.09 ns** | **185.21 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 171.47 ns |  7.569 ns | 0.415 ns | 171.16 ns | 171.94 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 178.04 ns | 28.878 ns | 1.583 ns | 176.92 ns | 179.86 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.21 ns |  0.462 ns | 0.025 ns |  59.18 ns |  59.23 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.53 ns |  0.924 ns | 0.051 ns |  58.48 ns |  58.58 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.35 ns |  0.243 ns | 0.013 ns |  57.34 ns |  57.37 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 167.41 ns | 13.810 ns | 0.757 ns | 166.92 ns | 168.28 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 168.83 ns |  7.486 ns | 0.410 ns | 168.41 ns | 169.23 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 172.44 ns | 50.398 ns | 2.763 ns | 169.57 ns | 175.09 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.84 ns |  3.391 ns | 0.186 ns |  59.63 ns |  59.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.32 ns |  4.061 ns | 0.223 ns |  58.18 ns |  58.58 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  58.03 ns |  3.598 ns | 0.197 ns |  57.90 ns |  58.26 ns |      - |         - |
