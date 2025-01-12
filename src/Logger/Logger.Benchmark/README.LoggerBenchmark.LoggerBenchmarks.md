```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **58.61 ns** | **21.142 ns** | **1.159 ns** |  **57.29 ns** |  **59.45 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  58.23 ns |  7.084 ns | 0.388 ns |  57.82 ns |  58.59 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  62.27 ns | 10.015 ns | 0.549 ns |  61.78 ns |  62.86 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.23 ns |  7.387 ns | 0.405 ns |  19.98 ns |  20.70 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.18 ns |  2.004 ns | 0.110 ns |  20.10 ns |  20.31 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  20.17 ns |  0.588 ns | 0.032 ns |  20.14 ns |  20.21 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **170.96 ns** |  **6.851 ns** | **0.375 ns** | **170.67 ns** | **171.38 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 169.74 ns | 19.087 ns | 1.046 ns | 168.65 ns | 170.74 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 185.14 ns |  9.184 ns | 0.503 ns | 184.60 ns | 185.60 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.28 ns |  0.551 ns | 0.030 ns |  59.26 ns |  59.31 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.52 ns | 10.076 ns | 0.552 ns |  58.18 ns |  59.15 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.07 ns |  0.248 ns | 0.014 ns |  58.06 ns |  58.08 ns |      - |         - |
