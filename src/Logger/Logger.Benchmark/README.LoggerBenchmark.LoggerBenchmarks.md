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
| **LogWithoutIfParams**                         | **1**      |  **56.65 ns** |  **2.299 ns** | **0.126 ns** |  **56.53 ns** |  **56.78 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  56.92 ns | 31.028 ns | 1.701 ns |  55.91 ns |  58.89 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  62.09 ns |  9.607 ns | 0.527 ns |  61.52 ns |  62.56 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.01 ns |  0.841 ns | 0.046 ns |  19.97 ns |  20.06 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.12 ns |  0.203 ns | 0.011 ns |  20.11 ns |  20.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.22 ns |  0.099 ns | 0.005 ns |  19.21 ns |  19.22 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **170.32 ns** | **11.369 ns** | **0.623 ns** | **169.77 ns** | **171.00 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 166.58 ns | 10.609 ns | 0.582 ns | 166.11 ns | 167.23 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 186.23 ns | 17.393 ns | 0.953 ns | 185.64 ns | 187.33 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.39 ns |  4.528 ns | 0.248 ns |  59.24 ns |  59.68 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.77 ns |  1.542 ns | 0.085 ns |  58.71 ns |  58.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.82 ns |  0.900 ns | 0.049 ns |  57.78 ns |  57.87 ns |      - |         - |
