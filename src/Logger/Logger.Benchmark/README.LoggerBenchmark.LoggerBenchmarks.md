```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **57.06 ns** |  **7.736 ns** | **0.424 ns** |  **56.71 ns** |  **57.53 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  54.72 ns | 12.397 ns | 0.680 ns |  53.96 ns |  55.25 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  61.49 ns |  5.916 ns | 0.324 ns |  61.23 ns |  61.85 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.93 ns |  3.372 ns | 0.185 ns |  19.73 ns |  20.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.94 ns |  1.015 ns | 0.056 ns |  19.89 ns |  20.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.13 ns |  9.675 ns | 0.530 ns |  18.61 ns |  19.67 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **164.38 ns** | **21.572 ns** | **1.182 ns** | **163.04 ns** | **165.28 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 162.61 ns | 52.824 ns | 2.895 ns | 159.27 ns | 164.39 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 186.66 ns | 15.750 ns | 0.863 ns | 185.71 ns | 187.40 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.10 ns |  4.463 ns | 0.245 ns |  58.87 ns |  59.36 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.23 ns |  4.866 ns | 0.267 ns |  58.04 ns |  58.53 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.60 ns |  6.990 ns | 0.383 ns |  58.25 ns |  59.01 ns |      - |         - |
