```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.96 ns** |  **9.387 ns** | **0.515 ns** |  **60.58 ns** |  **61.55 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  62.99 ns |  1.562 ns | 0.086 ns |  62.90 ns |  63.07 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.33 ns | 11.334 ns | 0.621 ns |  66.83 ns |  68.02 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.95 ns |  0.276 ns | 0.015 ns |  19.94 ns |  19.97 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.83 ns |  0.831 ns | 0.046 ns |  19.80 ns |  19.89 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.23 ns |  1.073 ns | 0.059 ns |  19.20 ns |  19.30 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **183.81 ns** | **19.089 ns** | **1.046 ns** | **182.68 ns** | **184.74 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 190.06 ns |  9.728 ns | 0.533 ns | 189.50 ns | 190.57 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.94 ns | 13.515 ns | 0.741 ns | 199.10 ns | 200.49 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.49 ns |  0.620 ns | 0.034 ns |  59.45 ns |  59.52 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.33 ns |  0.536 ns | 0.029 ns |  58.30 ns |  58.35 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.85 ns |  6.254 ns | 0.343 ns |  57.54 ns |  58.22 ns |      - |         - |
