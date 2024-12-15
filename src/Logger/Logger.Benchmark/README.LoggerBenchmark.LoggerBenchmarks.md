```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **58.29 ns** |  **7.672 ns** | **0.421 ns** |  **57.99 ns** |  **58.77 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  58.77 ns |  2.782 ns | 0.152 ns |  58.62 ns |  58.93 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.20 ns | 22.386 ns | 1.227 ns |  64.80 ns |  67.05 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.91 ns |  0.893 ns | 0.049 ns |  19.85 ns |  19.95 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.94 ns |  0.510 ns | 0.028 ns |  19.92 ns |  19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  20.09 ns |  0.894 ns | 0.049 ns |  20.05 ns |  20.14 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **175.49 ns** | **10.353 ns** | **0.567 ns** | **175.01 ns** | **176.12 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 176.05 ns | 35.023 ns | 1.920 ns | 173.93 ns | 177.66 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 192.28 ns | 23.067 ns | 1.264 ns | 191.43 ns | 193.73 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.78 ns |  2.130 ns | 0.117 ns |  58.68 ns |  58.91 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.03 ns |  3.770 ns | 0.207 ns |  57.89 ns |  58.27 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.58 ns |  0.718 ns | 0.039 ns |  57.54 ns |  57.62 ns |      - |         - |
