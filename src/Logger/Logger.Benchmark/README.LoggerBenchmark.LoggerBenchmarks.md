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
| **LogWithoutIfParams**                         | **1**      |  **58.15 ns** |  **5.451 ns** | **0.299 ns** |  **57.86 ns** |  **58.46 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  57.21 ns | 19.593 ns | 1.074 ns |  56.04 ns |  58.15 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.08 ns | 23.241 ns | 1.274 ns |  63.29 ns |  65.55 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.00 ns |  0.514 ns | 0.028 ns |  19.96 ns |  20.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.18 ns |  1.393 ns | 0.076 ns |  20.13 ns |  20.27 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.27 ns |  0.729 ns | 0.040 ns |  19.23 ns |  19.30 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **168.59 ns** | **17.699 ns** | **0.970 ns** | **167.99 ns** | **169.71 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 168.69 ns | 33.835 ns | 1.855 ns | 166.78 ns | 170.48 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 184.48 ns |  1.985 ns | 0.109 ns | 184.35 ns | 184.55 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.39 ns |  1.724 ns | 0.095 ns |  59.30 ns |  59.49 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  59.15 ns |  0.940 ns | 0.052 ns |  59.12 ns |  59.21 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.02 ns |  5.179 ns | 0.284 ns |  57.76 ns |  58.32 ns |      - |         - |
