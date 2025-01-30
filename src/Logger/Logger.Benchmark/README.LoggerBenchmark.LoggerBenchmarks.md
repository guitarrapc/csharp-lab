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
| **LogWithoutIfParams**                         | **1**      |  **62.10 ns** | **10.217 ns** | **0.560 ns** |  **61.57 ns** |  **62.68 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  59.63 ns |  1.243 ns | 0.068 ns |  59.55 ns |  59.68 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.20 ns | 28.201 ns | 1.546 ns |  66.43 ns |  69.30 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.97 ns |  0.350 ns | 0.019 ns |  19.96 ns |  19.99 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.17 ns |  1.028 ns | 0.056 ns |  20.10 ns |  20.21 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.26 ns |  0.061 ns | 0.003 ns |  19.26 ns |  19.27 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.84 ns** |  **8.625 ns** | **0.473 ns** | **179.30 ns** | **180.18 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 180.56 ns | 15.912 ns | 0.872 ns | 179.60 ns | 181.30 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.30 ns | 17.053 ns | 0.935 ns | 197.35 ns | 199.22 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.07 ns |  2.656 ns | 0.146 ns |  58.93 ns |  59.22 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  59.17 ns |  0.377 ns | 0.021 ns |  59.15 ns |  59.18 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.09 ns |  1.568 ns | 0.086 ns |  58.01 ns |  58.18 ns |      - |         - |
