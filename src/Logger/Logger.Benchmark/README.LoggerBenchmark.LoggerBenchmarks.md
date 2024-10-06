```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.76 ns** | **1.690 ns** | **0.093 ns** |  **60.66 ns** |  **60.82 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  62.34 ns | 1.740 ns | 0.095 ns |  62.24 ns |  62.43 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.95 ns | 5.401 ns | 0.296 ns |  65.66 ns |  66.25 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.91 ns | 0.034 ns | 0.002 ns |  19.90 ns |  19.91 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.91 ns | 0.330 ns | 0.018 ns |  19.89 ns |  19.93 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.65 ns | 1.589 ns | 0.087 ns |  19.55 ns |  19.72 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **195.56 ns** | **3.951 ns** | **0.217 ns** | **195.32 ns** | **195.75 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 187.12 ns | 2.017 ns | 0.111 ns | 187.00 ns | 187.22 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 201.21 ns | 8.438 ns | 0.463 ns | 200.92 ns | 201.74 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.42 ns | 3.487 ns | 0.191 ns |  59.29 ns |  59.64 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.59 ns | 0.415 ns | 0.023 ns |  58.57 ns |  58.62 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.42 ns | 3.083 ns | 0.169 ns |  57.28 ns |  57.61 ns |      - |         - |
