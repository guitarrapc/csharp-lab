```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.86 ns** |   **1.222 ns** | **0.067 ns** |  **61.82 ns** |  **61.94 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  62.13 ns |   0.772 ns | 0.042 ns |  62.09 ns |  62.17 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.65 ns |   0.693 ns | 0.038 ns |  64.62 ns |  64.70 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.88 ns |   2.907 ns | 0.159 ns |  19.78 ns |  20.07 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.79 ns |   0.389 ns | 0.021 ns |  19.76 ns |  19.80 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.20 ns |   0.924 ns | 0.051 ns |  19.14 ns |  19.24 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **187.03 ns** |   **8.190 ns** | **0.449 ns** | **186.77 ns** | **187.55 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 184.53 ns | 123.050 ns | 6.745 ns | 180.26 ns | 192.31 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 201.26 ns |   9.364 ns | 0.513 ns | 200.72 ns | 201.75 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  61.68 ns |  11.133 ns | 0.610 ns |  61.32 ns |  62.38 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.33 ns |   1.185 ns | 0.065 ns |  58.28 ns |  58.41 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.89 ns |   1.628 ns | 0.089 ns |  57.80 ns |  57.98 ns |      - |         - |
