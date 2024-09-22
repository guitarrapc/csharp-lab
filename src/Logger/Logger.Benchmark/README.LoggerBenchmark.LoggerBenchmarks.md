```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **62.04 ns** |  **6.242 ns** | **0.342 ns** |  **61.81 ns** |  **62.44 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.24 ns |  0.938 ns | 0.051 ns |  60.21 ns |  60.30 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.61 ns |  5.436 ns | 0.298 ns |  65.28 ns |  65.86 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.90 ns |  0.624 ns | 0.034 ns |  19.87 ns |  19.93 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.00 ns |  0.805 ns | 0.044 ns |  19.95 ns |  20.04 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.25 ns |  0.759 ns | 0.042 ns |  19.22 ns |  19.30 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.31 ns** | **17.854 ns** | **0.979 ns** | **180.49 ns** | **182.40 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.19 ns | 10.080 ns | 0.553 ns | 180.61 ns | 181.71 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.55 ns |  4.242 ns | 0.233 ns | 196.29 ns | 196.75 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.35 ns |  2.167 ns | 0.119 ns |  59.25 ns |  59.48 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.66 ns |  3.284 ns | 0.180 ns |  58.55 ns |  58.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.48 ns |  2.722 ns | 0.149 ns |  57.31 ns |  57.60 ns |      - |         - |
