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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **60.90 ns** |  **7.697 ns** | **0.422 ns** |  **60.57 ns** |  **61.37 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.76 ns | 12.532 ns | 0.687 ns |  58.17 ns |  59.51 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.64 ns |  2.572 ns | 0.141 ns |  57.53 ns |  57.80 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.91 ns |  0.037 ns | 0.002 ns |  19.91 ns |  19.91 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.91 ns |  0.819 ns | 0.045 ns |  19.88 ns |  19.96 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.41 ns |  4.930 ns | 0.270 ns |  19.23 ns |  19.72 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  56.73 ns |  5.358 ns | 0.294 ns |  56.54 ns |  57.07 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  56.25 ns |  6.240 ns | 0.342 ns |  55.91 ns |  56.59 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  58.21 ns | 28.506 ns | 1.563 ns |  57.14 ns |  60.01 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.11 ns |  0.559 ns | 0.031 ns |  20.08 ns |  20.14 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.12 ns |  0.398 ns | 0.022 ns |  20.10 ns |  20.15 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.25 ns |  1.212 ns | 0.066 ns |  19.21 ns |  19.33 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **174.67 ns** | **31.194 ns** | **1.710 ns** | **172.70 ns** | **175.69 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 171.67 ns | 25.885 ns | 1.419 ns | 170.46 ns | 173.23 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 171.88 ns |  3.913 ns | 0.214 ns | 171.63 ns | 172.00 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.22 ns |  1.620 ns | 0.089 ns |  59.15 ns |  59.32 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.43 ns |  0.903 ns | 0.050 ns |  58.40 ns |  58.49 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  59.27 ns |  0.637 ns | 0.035 ns |  59.23 ns |  59.30 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 170.35 ns | 83.295 ns | 4.566 ns | 167.10 ns | 175.57 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 171.35 ns | 10.095 ns | 0.553 ns | 170.97 ns | 171.99 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 169.88 ns | 24.934 ns | 1.367 ns | 169.04 ns | 171.46 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.96 ns |  2.809 ns | 0.154 ns |  59.84 ns |  60.13 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.13 ns |  1.172 ns | 0.064 ns |  59.08 ns |  59.20 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.99 ns |  0.915 ns | 0.050 ns |  57.95 ns |  58.04 ns |      - |         - |
