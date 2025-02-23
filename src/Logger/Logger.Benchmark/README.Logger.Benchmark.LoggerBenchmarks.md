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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.56 ns** |  **3.737 ns** | **0.205 ns** |  **58.33 ns** |  **58.68 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  59.27 ns | 21.283 ns | 1.167 ns |  58.21 ns |  60.52 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  58.09 ns |  3.457 ns | 0.190 ns |  57.90 ns |  58.28 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.88 ns |  0.162 ns | 0.009 ns |  19.87 ns |  19.89 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.88 ns |  0.221 ns | 0.012 ns |  19.88 ns |  19.90 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.39 ns |  4.344 ns | 0.238 ns |  19.24 ns |  19.67 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  56.82 ns |  4.363 ns | 0.239 ns |  56.56 ns |  57.03 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  58.68 ns |  1.841 ns | 0.101 ns |  58.56 ns |  58.76 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  58.49 ns |  3.429 ns | 0.188 ns |  58.37 ns |  58.71 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.01 ns |  0.896 ns | 0.049 ns |  19.97 ns |  20.07 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.19 ns |  1.248 ns | 0.068 ns |  20.12 ns |  20.25 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.82 ns |  8.763 ns | 0.480 ns |  19.26 ns |  20.14 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **175.85 ns** | **47.277 ns** | **2.591 ns** | **173.58 ns** | **178.68 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 174.15 ns | 16.886 ns | 0.926 ns | 173.31 ns | 175.14 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 173.92 ns | 31.896 ns | 1.748 ns | 172.11 ns | 175.60 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.23 ns |  1.807 ns | 0.099 ns |  59.15 ns |  59.34 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.71 ns |  2.046 ns | 0.112 ns |  58.58 ns |  58.80 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  59.38 ns |  3.560 ns | 0.195 ns |  59.26 ns |  59.60 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 168.81 ns | 39.755 ns | 2.179 ns | 167.28 ns | 171.30 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 169.75 ns | 19.578 ns | 1.073 ns | 168.54 ns | 170.60 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 179.21 ns | 16.835 ns | 0.923 ns | 178.35 ns | 180.19 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  60.15 ns |  7.906 ns | 0.433 ns |  59.65 ns |  60.43 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.38 ns |  3.937 ns | 0.216 ns |  58.26 ns |  58.63 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.64 ns |  0.460 ns | 0.025 ns |  57.62 ns |  57.67 ns |      - |         - |
