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
| **LogWithoutIfParams**                         | **1**      |  **59.43 ns** |  **3.621 ns** | **0.199 ns** |  **59.27 ns** |  **59.66 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  56.77 ns |  4.759 ns | 0.261 ns |  56.47 ns |  56.96 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  62.33 ns | 11.716 ns | 0.642 ns |  61.96 ns |  63.07 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.97 ns |  0.158 ns | 0.009 ns |  19.96 ns |  19.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.14 ns |  0.315 ns | 0.017 ns |  20.12 ns |  20.16 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.36 ns |  2.157 ns | 0.118 ns |  19.24 ns |  19.48 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **171.82 ns** | **10.782 ns** | **0.591 ns** | **171.40 ns** | **172.49 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 169.03 ns |  4.274 ns | 0.234 ns | 168.89 ns | 169.30 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 191.54 ns | 17.396 ns | 0.954 ns | 190.52 ns | 192.41 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  60.37 ns |  5.484 ns | 0.301 ns |  60.04 ns |  60.62 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.29 ns |  0.876 ns | 0.048 ns |  58.26 ns |  58.35 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.26 ns |  7.864 ns | 0.431 ns |  56.99 ns |  57.76 ns |      - |         - |
