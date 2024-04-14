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
| **LogWithoutIfParams**                         | **1**      |  **66.40 ns** |  **4.016 ns** | **0.220 ns** |  **66.17 ns** |  **66.61 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  63.34 ns |  9.656 ns | 0.529 ns |  63.03 ns |  63.95 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.41 ns |  2.538 ns | 0.139 ns |  65.27 ns |  65.55 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.10 ns |  4.913 ns | 0.269 ns |  19.86 ns |  20.39 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.00 ns |  1.282 ns | 0.070 ns |  19.95 ns |  20.08 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.21 ns |  0.040 ns | 0.002 ns |  19.21 ns |  19.21 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **188.62 ns** |  **5.230 ns** | **0.287 ns** | **188.30 ns** | **188.85 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.10 ns | 62.332 ns | 3.417 ns | 178.75 ns | 185.02 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.12 ns |  8.233 ns | 0.451 ns | 198.82 ns | 199.64 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.94 ns |  0.668 ns | 0.037 ns |  58.91 ns |  58.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.55 ns |  5.480 ns | 0.300 ns |  58.38 ns |  58.90 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.12 ns |  0.587 ns | 0.032 ns |  59.08 ns |  59.14 ns |      - |         - |
