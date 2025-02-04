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
| **LogWithoutIfParams**                         | **1**      |  **59.11 ns** |  **1.446 ns** | **0.079 ns** |  **59.02 ns** |  **59.18 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  59.00 ns |  0.834 ns | 0.046 ns |  58.95 ns |  59.03 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.70 ns | 23.253 ns | 1.275 ns |  65.59 ns |  68.09 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.94 ns |  0.623 ns | 0.034 ns |  19.91 ns |  19.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.18 ns |  1.824 ns | 0.100 ns |  20.10 ns |  20.29 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.52 ns |  5.460 ns | 0.299 ns |  19.31 ns |  19.86 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **175.62 ns** | **26.368 ns** | **1.445 ns** | **173.96 ns** | **176.64 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 176.46 ns | 19.025 ns | 1.043 ns | 175.27 ns | 177.23 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.48 ns | 14.405 ns | 0.790 ns | 194.76 ns | 196.33 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.34 ns |  1.728 ns | 0.095 ns |  59.26 ns |  59.45 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.27 ns |  0.591 ns | 0.032 ns |  58.25 ns |  58.31 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.14 ns |  2.845 ns | 0.156 ns |  57.01 ns |  57.31 ns |      - |         - |
