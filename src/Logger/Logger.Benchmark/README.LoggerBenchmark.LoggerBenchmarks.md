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
| **LogWithoutIfParams**                         | **1**      |  **56.38 ns** |  **1.873 ns** | **0.103 ns** |  **56.29 ns** |  **56.49 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  57.73 ns | 22.257 ns | 1.220 ns |  56.88 ns |  59.12 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  62.30 ns |  7.599 ns | 0.417 ns |  61.96 ns |  62.77 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.96 ns |  0.296 ns | 0.016 ns |  19.94 ns |  19.97 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.05 ns |  0.364 ns | 0.020 ns |  20.04 ns |  20.08 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.35 ns |  3.566 ns | 0.195 ns |  19.22 ns |  19.57 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **170.40 ns** | **27.887 ns** | **1.529 ns** | **168.93 ns** | **171.98 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 168.82 ns |  0.510 ns | 0.028 ns | 168.80 ns | 168.85 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 184.32 ns |  5.926 ns | 0.325 ns | 183.95 ns | 184.55 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.33 ns |  3.545 ns | 0.194 ns |  59.21 ns |  59.56 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  59.24 ns |  1.285 ns | 0.070 ns |  59.17 ns |  59.31 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.00 ns |  0.914 ns | 0.050 ns |  56.95 ns |  57.05 ns |      - |         - |
