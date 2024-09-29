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
| **LogWithoutIfParams**                         | **1**      |  **61.01 ns** |  **3.222 ns** | **0.177 ns** |  **60.91 ns** |  **61.22 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  63.22 ns |  1.276 ns | 0.070 ns |  63.15 ns |  63.29 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.24 ns | 33.797 ns | 1.853 ns |  66.12 ns |  69.38 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |  0.205 ns | 0.011 ns |  19.88 ns |  19.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.91 ns |  0.169 ns | 0.009 ns |  19.91 ns |  19.93 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.23 ns |  0.024 ns | 0.001 ns |  19.22 ns |  19.23 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.73 ns** | **11.692 ns** | **0.641 ns** | **182.02 ns** | **183.28 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.27 ns |  2.813 ns | 0.154 ns | 180.15 ns | 180.45 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.06 ns |  6.617 ns | 0.363 ns | 197.76 ns | 198.46 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.26 ns |  0.684 ns | 0.037 ns |  59.23 ns |  59.30 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.51 ns |  0.248 ns | 0.014 ns |  58.50 ns |  58.53 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.77 ns | 26.712 ns | 1.464 ns |  57.54 ns |  60.39 ns |      - |         - |
