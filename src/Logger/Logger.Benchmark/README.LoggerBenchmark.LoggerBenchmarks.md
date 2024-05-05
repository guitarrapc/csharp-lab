```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **59.88 ns** |  **5.676 ns** | **0.311 ns** |  **59.62 ns** |  **60.22 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  58.88 ns |  5.281 ns | 0.289 ns |  58.61 ns |  59.19 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.26 ns | 12.905 ns | 0.707 ns |  65.47 ns |  66.83 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.92 ns |  2.157 ns | 0.118 ns |  19.85 ns |  20.06 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.81 ns |  0.260 ns | 0.014 ns |  19.80 ns |  19.82 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.14 ns |  0.313 ns | 0.017 ns |  19.12 ns |  19.15 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **178.30 ns** |  **1.324 ns** | **0.073 ns** | **178.21 ns** | **178.35 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.32 ns | 25.886 ns | 1.419 ns | 179.43 ns | 181.96 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 193.73 ns | 49.504 ns | 2.713 ns | 191.68 ns | 196.80 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.97 ns |  0.724 ns | 0.040 ns |  58.93 ns |  59.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.23 ns |  0.468 ns | 0.026 ns |  58.22 ns |  58.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.73 ns |  1.411 ns | 0.077 ns |  57.65 ns |  57.81 ns |      - |         - |
