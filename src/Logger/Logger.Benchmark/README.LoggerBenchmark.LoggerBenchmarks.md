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
| **LogWithoutIfParams**                         | **1**      |  **58.59 ns** |  **3.924 ns** | **0.215 ns** |  **58.40 ns** |  **58.82 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  61.66 ns | 82.159 ns | 4.503 ns |  58.25 ns |  66.77 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.38 ns | 29.702 ns | 1.628 ns |  63.21 ns |  66.24 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.09 ns |  1.073 ns | 0.059 ns |  20.02 ns |  20.13 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.03 ns |  2.428 ns | 0.133 ns |  19.91 ns |  20.17 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  20.17 ns |  0.211 ns | 0.012 ns |  20.16 ns |  20.18 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **176.98 ns** | **16.203 ns** | **0.888 ns** | **175.95 ns** | **177.56 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 178.08 ns | 55.943 ns | 3.066 ns | 174.90 ns | 181.02 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 189.36 ns | 70.290 ns | 3.853 ns | 186.17 ns | 193.64 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.29 ns |  0.511 ns | 0.028 ns |  59.26 ns |  59.31 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.38 ns |  1.000 ns | 0.055 ns |  58.34 ns |  58.44 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.01 ns |  1.357 ns | 0.074 ns |  56.95 ns |  57.09 ns |      - |         - |
