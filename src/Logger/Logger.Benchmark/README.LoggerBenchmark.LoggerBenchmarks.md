```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.94 ns** |  **9.410 ns** | **0.516 ns** |  **60.52 ns** |  **61.52 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.03 ns |  2.629 ns | 0.144 ns |  58.91 ns |  59.19 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  69.23 ns |  1.673 ns | 0.092 ns |  69.13 ns |  69.31 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.86 ns |  2.285 ns | 0.125 ns |  19.77 ns |  20.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.88 ns |  0.602 ns | 0.033 ns |  19.85 ns |  19.91 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.21 ns |  0.718 ns | 0.039 ns |  19.18 ns |  19.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.04 ns** | **15.531 ns** | **0.851 ns** | **180.35 ns** | **181.99 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 186.76 ns | 54.301 ns | 2.976 ns | 184.95 ns | 190.20 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.22 ns | 47.233 ns | 2.589 ns | 196.26 ns | 201.07 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.04 ns |  0.809 ns | 0.044 ns |  58.99 ns |  59.08 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.28 ns |  1.356 ns | 0.074 ns |  58.24 ns |  58.37 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.26 ns | 19.431 ns | 1.065 ns |  57.60 ns |  59.49 ns |      - |         - |
