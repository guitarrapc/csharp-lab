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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **61.78 ns** |  **4.482 ns** | **0.246 ns** |  **61.51 ns** |  **61.99 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  57.38 ns |  4.194 ns | 0.230 ns |  57.24 ns |  57.64 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.92 ns |  9.784 ns | 0.536 ns |  57.31 ns |  58.31 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.96 ns |  1.290 ns | 0.071 ns |  19.91 ns |  20.04 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.96 ns |  0.206 ns | 0.011 ns |  19.95 ns |  19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.60 ns | 11.242 ns | 0.616 ns |  19.24 ns |  20.31 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  57.21 ns |  4.004 ns | 0.219 ns |  57.02 ns |  57.45 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  56.70 ns |  2.970 ns | 0.163 ns |  56.51 ns |  56.81 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  56.48 ns |  3.242 ns | 0.178 ns |  56.27 ns |  56.60 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.92 ns |  1.400 ns | 0.077 ns |  19.88 ns |  20.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.13 ns |  0.382 ns | 0.021 ns |  20.10 ns |  20.14 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  20.38 ns | 15.637 ns | 0.857 ns |  19.47 ns |  21.17 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **177.93 ns** |  **1.542 ns** | **0.085 ns** | **177.83 ns** | **178.00 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 170.73 ns | 42.868 ns | 2.350 ns | 169.37 ns | 173.45 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 170.18 ns | 10.768 ns | 0.590 ns | 169.69 ns | 170.83 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.37 ns |  6.000 ns | 0.329 ns |  59.17 ns |  59.75 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.95 ns |  3.647 ns | 0.200 ns |  58.81 ns |  59.18 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.42 ns |  4.076 ns | 0.223 ns |  57.26 ns |  57.67 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 172.70 ns | 11.463 ns | 0.628 ns | 172.20 ns | 173.40 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 173.36 ns | 37.187 ns | 2.038 ns | 171.01 ns | 174.61 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 170.92 ns | 43.160 ns | 2.366 ns | 168.62 ns | 173.34 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.57 ns |  4.783 ns | 0.262 ns |  59.41 ns |  59.87 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.17 ns |  1.504 ns | 0.082 ns |  59.10 ns |  59.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  58.93 ns |  3.301 ns | 0.181 ns |  58.81 ns |  59.13 ns |      - |         - |
