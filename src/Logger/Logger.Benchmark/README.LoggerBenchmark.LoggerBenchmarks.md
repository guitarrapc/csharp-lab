```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **58.28 ns** |   **1.625 ns** |  **0.089 ns** |  **58.18 ns** |  **58.35 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  59.37 ns |  12.427 ns |  0.681 ns |  58.62 ns |  59.95 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.76 ns |  23.187 ns |  1.271 ns |  64.80 ns |  67.20 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.04 ns |   1.951 ns |  0.107 ns |  19.96 ns |  20.16 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.15 ns |   0.590 ns |  0.032 ns |  20.11 ns |  20.18 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.27 ns |   2.380 ns |  0.130 ns |  19.14 ns |  19.39 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **176.47 ns** |  **31.707 ns** |  **1.738 ns** | **174.48 ns** | **177.68 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 218.09 ns | 230.380 ns | 12.628 ns | 210.16 ns | 232.65 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 194.11 ns |  45.319 ns |  2.484 ns | 191.68 ns | 196.64 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.66 ns |   5.329 ns |  0.292 ns |  59.38 ns |  59.96 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.86 ns |   3.570 ns |  0.196 ns |  58.65 ns |  59.03 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.92 ns |   0.518 ns |  0.028 ns |  57.89 ns |  57.95 ns |      - |         - |
