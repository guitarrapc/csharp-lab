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
| **LogWithoutIfParams**                         | **1**      |  **56.52 ns** |  **1.471 ns** | **0.081 ns** |  **56.46 ns** |  **56.61 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  57.99 ns | 12.279 ns | 0.673 ns |  57.32 ns |  58.66 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  63.84 ns |  8.824 ns | 0.484 ns |  63.45 ns |  64.38 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.97 ns |  0.974 ns | 0.053 ns |  19.94 ns |  20.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.90 ns |  0.375 ns | 0.021 ns |  19.88 ns |  19.92 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.75 ns |  0.541 ns | 0.030 ns |  19.72 ns |  19.77 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **167.84 ns** | **20.539 ns** | **1.126 ns** | **167.09 ns** | **169.14 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 169.23 ns | 34.403 ns | 1.886 ns | 167.83 ns | 171.38 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 185.38 ns | 23.895 ns | 1.310 ns | 184.07 ns | 186.69 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.45 ns |  1.236 ns | 0.068 ns |  59.41 ns |  59.52 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.31 ns |  4.324 ns | 0.237 ns |  58.15 ns |  58.58 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.55 ns | 16.111 ns | 0.883 ns |  57.54 ns |  59.21 ns |      - |         - |
