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
| **LogWithoutIfParams**                         | **1**      |  **60.72 ns** |  **1.649 ns** | **0.090 ns** |  **60.65 ns** |  **60.82 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.35 ns | 22.621 ns | 1.240 ns |  60.63 ns |  62.79 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.85 ns | 19.511 ns | 1.069 ns |  65.09 ns |  67.07 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.84 ns |  0.055 ns | 0.003 ns |  19.84 ns |  19.85 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.01 ns |  1.389 ns | 0.076 ns |  19.95 ns |  20.09 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.37 ns |  6.301 ns | 0.345 ns |  19.14 ns |  19.77 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.80 ns** |  **7.519 ns** | **0.412 ns** | **181.33 ns** | **182.07 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.97 ns |  0.961 ns | 0.053 ns | 181.92 ns | 182.02 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 194.86 ns |  7.314 ns | 0.401 ns | 194.62 ns | 195.33 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.40 ns |  3.248 ns | 0.178 ns |  59.27 ns |  59.60 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.48 ns |  4.880 ns | 0.267 ns |  58.33 ns |  58.79 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.80 ns |  3.083 ns | 0.169 ns |  57.64 ns |  57.97 ns |      - |         - |
