```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **63.15 ns** |  **2.381 ns** | **0.131 ns** |  **63.03 ns** |  **63.29 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.00 ns |  7.472 ns | 0.410 ns |  59.74 ns |  60.47 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.74 ns |  9.867 ns | 0.541 ns |  67.26 ns |  68.33 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |  0.694 ns | 0.038 ns |  19.86 ns |  19.93 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  30.34 ns |  0.542 ns | 0.030 ns |  30.31 ns |  30.37 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.40 ns |  2.154 ns | 0.118 ns |  19.27 ns |  19.51 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **186.20 ns** | **48.815 ns** | **2.676 ns** | **184.20 ns** | **189.24 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 183.56 ns | 45.502 ns | 2.494 ns | 182.04 ns | 186.44 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 207.19 ns |  7.546 ns | 0.414 ns | 206.91 ns | 207.67 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.40 ns |  0.319 ns | 0.018 ns |  59.38 ns |  59.42 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  59.72 ns | 18.461 ns | 1.012 ns |  58.65 ns |  60.66 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.36 ns |  1.821 ns | 0.100 ns |  57.27 ns |  57.47 ns |      - |         - |
