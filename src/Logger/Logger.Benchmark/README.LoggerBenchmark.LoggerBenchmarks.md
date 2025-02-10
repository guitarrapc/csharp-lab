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
| **LogWithoutIfParams**                         | **1**      |  **59.42 ns** | **17.784 ns** | **0.975 ns** |  **58.33 ns** |  **60.21 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  56.88 ns |  9.834 ns | 0.539 ns |  56.43 ns |  57.48 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.24 ns | 12.142 ns | 0.666 ns |  64.60 ns |  65.93 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.03 ns |  1.090 ns | 0.060 ns |  19.99 ns |  20.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.15 ns |  1.164 ns | 0.064 ns |  20.11 ns |  20.22 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.26 ns |  0.968 ns | 0.053 ns |  19.23 ns |  19.32 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **174.51 ns** | **29.352 ns** | **1.609 ns** | **173.16 ns** | **176.29 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 171.15 ns |  1.218 ns | 0.067 ns | 171.07 ns | 171.20 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 190.22 ns | 31.304 ns | 1.716 ns | 188.90 ns | 192.16 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.29 ns |  1.165 ns | 0.064 ns |  59.24 ns |  59.36 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.71 ns |  3.569 ns | 0.196 ns |  58.59 ns |  58.94 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.74 ns |  3.893 ns | 0.213 ns |  57.61 ns |  57.99 ns |      - |         - |
