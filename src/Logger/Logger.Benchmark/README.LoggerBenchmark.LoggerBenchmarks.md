```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **59.87 ns** |   **2.533 ns** |  **0.139 ns** |  **59.71 ns** |  **59.97 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  58.97 ns |   6.296 ns |  0.345 ns |  58.67 ns |  59.35 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.80 ns |  19.944 ns |  1.093 ns |  64.68 ns |  66.87 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.96 ns |   2.388 ns |  0.131 ns |  19.87 ns |  20.11 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.01 ns |   3.087 ns |  0.169 ns |  19.91 ns |  20.21 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.14 ns |   0.152 ns |  0.008 ns |  19.13 ns |  19.14 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **217.72 ns** | **551.958 ns** | **30.255 ns** | **182.79 ns** | **235.52 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.06 ns |  57.866 ns |  3.172 ns | 176.06 ns | 181.72 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.16 ns |   6.228 ns |  0.341 ns | 195.77 ns | 196.40 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.96 ns |   0.374 ns |  0.020 ns |  58.94 ns |  58.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.41 ns |   2.672 ns |  0.146 ns |  58.28 ns |  58.57 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.17 ns |   0.814 ns |  0.045 ns |  59.13 ns |  59.22 ns |      - |         - |
