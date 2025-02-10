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
| **LogWithoutIfParams**                         | **1**      |  **57.24 ns** |  **8.484 ns** | **0.465 ns** |  **56.89 ns** |  **57.77 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  58.54 ns |  0.518 ns | 0.028 ns |  58.51 ns |  58.57 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.23 ns | 15.250 ns | 0.836 ns |  63.45 ns |  65.11 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |  0.761 ns | 0.042 ns |  19.85 ns |  19.94 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.94 ns |  0.999 ns | 0.055 ns |  19.90 ns |  20.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.60 ns | 10.260 ns | 0.562 ns |  19.22 ns |  20.24 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **167.72 ns** | **11.266 ns** | **0.618 ns** | **167.25 ns** | **168.42 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 190.51 ns | 13.017 ns | 0.714 ns | 189.97 ns | 191.32 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 184.45 ns |  5.645 ns | 0.309 ns | 184.11 ns | 184.72 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.39 ns |  0.961 ns | 0.053 ns |  59.34 ns |  59.44 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.26 ns |  0.132 ns | 0.007 ns |  58.25 ns |  58.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.23 ns |  0.581 ns | 0.032 ns |  57.19 ns |  57.25 ns |      - |         - |
