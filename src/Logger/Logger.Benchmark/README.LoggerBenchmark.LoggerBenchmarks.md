```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **63.14 ns** |  **3.513 ns** | **0.193 ns** |  **62.97 ns** |  **63.35 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  58.81 ns |  5.377 ns | 0.295 ns |  58.63 ns |  59.15 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.12 ns |  6.436 ns | 0.353 ns |  64.86 ns |  65.52 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.07 ns |  3.531 ns | 0.194 ns |  19.85 ns |  20.22 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.07 ns |  1.631 ns | 0.089 ns |  19.97 ns |  20.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.28 ns |  0.830 ns | 0.045 ns |  19.24 ns |  19.33 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.38 ns** |  **7.055 ns** | **0.387 ns** | **178.94 ns** | **179.68 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 179.58 ns | 79.500 ns | 4.358 ns | 177.04 ns | 184.61 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.24 ns | 11.417 ns | 0.626 ns | 195.52 ns | 196.68 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.98 ns |  0.904 ns | 0.050 ns |  58.93 ns |  59.02 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.35 ns |  5.143 ns | 0.282 ns |  58.19 ns |  58.68 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.60 ns |  1.352 ns | 0.074 ns |  57.53 ns |  57.67 ns |      - |         - |
