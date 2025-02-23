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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **60.72 ns** |  **8.343 ns** | **0.457 ns** |  **60.41 ns** |  **61.25 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  59.14 ns | 11.656 ns | 0.639 ns |  58.75 ns |  59.88 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.80 ns | 29.570 ns | 1.621 ns |  56.52 ns |  59.62 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.75 ns |  3.194 ns | 0.175 ns |  19.57 ns |  19.92 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.59 ns |  2.532 ns | 0.139 ns |  19.44 ns |  19.69 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.63 ns |  0.505 ns | 0.028 ns |  19.60 ns |  19.66 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  62.25 ns | 12.160 ns | 0.667 ns |  61.75 ns |  63.00 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  56.55 ns |  2.858 ns | 0.157 ns |  56.40 ns |  56.71 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  62.54 ns |  5.973 ns | 0.327 ns |  62.33 ns |  62.91 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.83 ns |  2.008 ns | 0.110 ns |  19.75 ns |  19.95 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  19.85 ns |  4.639 ns | 0.254 ns |  19.67 ns |  20.14 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  18.85 ns |  5.481 ns | 0.300 ns |  18.67 ns |  19.20 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **171.35 ns** | **44.566 ns** | **2.443 ns** | **168.67 ns** | **173.46 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 174.19 ns | 29.869 ns | 1.637 ns | 172.46 ns | 175.72 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 176.03 ns | 30.648 ns | 1.680 ns | 174.37 ns | 177.73 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.80 ns |  0.336 ns | 0.018 ns |  59.78 ns |  59.82 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  57.89 ns |  6.299 ns | 0.345 ns |  57.52 ns |  58.21 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  56.65 ns |  7.581 ns | 0.416 ns |  56.20 ns |  57.02 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 167.37 ns | 58.162 ns | 3.188 ns | 165.45 ns | 171.05 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 166.37 ns | 24.243 ns | 1.329 ns | 165.27 ns | 167.85 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 168.53 ns | 55.598 ns | 3.047 ns | 165.05 ns | 170.69 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  58.94 ns |  5.272 ns | 0.289 ns |  58.63 ns |  59.20 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  57.19 ns | 17.358 ns | 0.951 ns |  56.23 ns |  58.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.74 ns | 18.947 ns | 1.039 ns |  56.79 ns |  58.85 ns |      - |         - |
