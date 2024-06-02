```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **62.83 ns** |  **1.189 ns** | **0.065 ns** |  **62.75 ns** |  **62.87 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.98 ns | 35.216 ns | 1.930 ns |  58.77 ns |  62.21 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.95 ns |  4.384 ns | 0.240 ns |  68.73 ns |  69.20 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.98 ns |  1.842 ns | 0.101 ns |  19.89 ns |  20.09 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.92 ns |  0.110 ns | 0.006 ns |  19.92 ns |  19.93 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.17 ns |  0.657 ns | 0.036 ns |  19.14 ns |  19.21 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.24 ns** | **27.884 ns** | **1.528 ns** | **178.11 ns** | **180.98 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 179.85 ns | 18.768 ns | 1.029 ns | 178.67 ns | 180.58 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.25 ns |  7.863 ns | 0.431 ns | 194.76 ns | 195.57 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.03 ns |  0.632 ns | 0.035 ns |  59.01 ns |  59.07 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.21 ns |  0.460 ns | 0.025 ns |  58.18 ns |  58.23 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.84 ns |  1.023 ns | 0.056 ns |  57.80 ns |  57.90 ns |      - |         - |
