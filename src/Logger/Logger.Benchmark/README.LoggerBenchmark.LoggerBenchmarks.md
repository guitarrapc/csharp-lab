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
| **LogWithoutIfParams**                         | **1**      |  **59.70 ns** |  **1.815 ns** | **0.099 ns** |  **59.62 ns** |  **59.81 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.34 ns |  3.232 ns | 0.177 ns |  59.16 ns |  59.52 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.68 ns |  2.560 ns | 0.140 ns |  64.55 ns |  64.83 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.87 ns |  0.196 ns | 0.011 ns |  19.86 ns |  19.88 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.92 ns |  0.179 ns | 0.010 ns |  19.92 ns |  19.93 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  20.96 ns |  5.285 ns | 0.290 ns |  20.79 ns |  21.29 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **175.33 ns** |  **6.533 ns** | **0.358 ns** | **175.01 ns** | **175.72 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 176.93 ns | 21.420 ns | 1.174 ns | 175.58 ns | 177.72 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 193.13 ns | 14.769 ns | 0.810 ns | 192.20 ns | 193.71 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.68 ns |  0.423 ns | 0.023 ns |  58.66 ns |  58.70 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  57.88 ns |  0.476 ns | 0.026 ns |  57.86 ns |  57.91 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  56.81 ns |  2.581 ns | 0.141 ns |  56.72 ns |  56.98 ns |      - |         - |
