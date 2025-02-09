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
| **LogWithoutIfParams**                         | **1**      |  **60.20 ns** |  **9.717 ns** | **0.533 ns** |  **59.73 ns** |  **60.78 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  59.16 ns |  9.357 ns | 0.513 ns |  58.58 ns |  59.57 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.87 ns | 40.675 ns | 2.230 ns |  65.78 ns |  70.22 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.95 ns |  0.164 ns | 0.009 ns |  19.94 ns |  19.96 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.17 ns |  0.748 ns | 0.041 ns |  20.12 ns |  20.19 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.24 ns |  0.691 ns | 0.038 ns |  19.21 ns |  19.28 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **177.52 ns** | **12.865 ns** | **0.705 ns** | **177.06 ns** | **178.33 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 178.38 ns |  6.936 ns | 0.380 ns | 177.95 ns | 178.62 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.04 ns | 30.613 ns | 1.678 ns | 194.19 ns | 197.46 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.35 ns |  3.140 ns | 0.172 ns |  59.25 ns |  59.55 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.96 ns |  1.529 ns | 0.084 ns |  58.87 ns |  59.03 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.09 ns |  3.292 ns | 0.180 ns |  56.88 ns |  57.22 ns |      - |         - |
