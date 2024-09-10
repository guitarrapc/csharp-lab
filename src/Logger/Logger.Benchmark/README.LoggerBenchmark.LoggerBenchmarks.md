```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.20 ns** |   **2.015 ns** |  **0.110 ns** |  **61.13 ns** |  **61.33 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  63.47 ns |   6.123 ns |  0.336 ns |  63.08 ns |  63.71 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.18 ns |   6.128 ns |  0.336 ns |  66.91 ns |  67.55 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |   0.811 ns |  0.044 ns |  19.87 ns |  19.95 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.80 ns |   0.158 ns |  0.009 ns |  19.79 ns |  19.81 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.20 ns |   0.915 ns |  0.050 ns |  19.14 ns |  19.23 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **184.66 ns** |  **43.048 ns** |  **2.360 ns** | **182.50 ns** | **187.18 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 182.80 ns |  74.930 ns |  4.107 ns | 180.23 ns | 187.54 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 209.48 ns | 338.427 ns | 18.550 ns | 198.15 ns | 230.89 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.45 ns |   4.855 ns |  0.266 ns |  59.29 ns |  59.75 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.34 ns |   1.134 ns |  0.062 ns |  58.28 ns |  58.41 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.16 ns |   1.641 ns |  0.090 ns |  58.08 ns |  58.26 ns |      - |         - |
