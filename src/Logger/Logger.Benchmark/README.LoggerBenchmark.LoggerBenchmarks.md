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
| **LogWithoutIfParams**                         | **1**      |  **58.08 ns** |   **7.312 ns** |  **0.401 ns** |  **57.69 ns** |  **58.49 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  57.62 ns |   7.128 ns |  0.391 ns |  57.35 ns |  58.07 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  63.72 ns |   5.397 ns |  0.296 ns |  63.45 ns |  64.04 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.15 ns |   4.813 ns |  0.264 ns |  19.90 ns |  20.43 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.09 ns |   0.029 ns |  0.002 ns |  20.09 ns |  20.09 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  20.20 ns |   0.860 ns |  0.047 ns |  20.15 ns |  20.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **171.05 ns** |  **22.619 ns** |  **1.240 ns** | **169.64 ns** | **172.00 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 171.53 ns |  17.073 ns |  0.936 ns | 170.49 ns | 172.31 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 203.06 ns | 230.708 ns | 12.646 ns | 195.20 ns | 217.65 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.33 ns |   1.238 ns |  0.068 ns |  59.28 ns |  59.40 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.91 ns |   2.192 ns |  0.120 ns |  58.83 ns |  59.04 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  56.92 ns |   0.519 ns |  0.028 ns |  56.90 ns |  56.95 ns |      - |         - |
