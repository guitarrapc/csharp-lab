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
| **LogWithoutIfParams**                         | **1**      |  **59.82 ns** |  **8.581 ns** | **0.470 ns** |  **59.28 ns** |  **60.11 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.22 ns |  5.952 ns | 0.326 ns |  58.88 ns |  59.54 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.42 ns |  1.427 ns | 0.078 ns |  67.34 ns |  67.49 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.70 ns |  3.567 ns | 0.196 ns |  19.54 ns |  19.92 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.79 ns |  1.642 ns | 0.090 ns |  19.68 ns |  19.85 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.18 ns |  1.129 ns | 0.062 ns |  19.12 ns |  19.24 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **183.11 ns** | **74.203 ns** | **4.067 ns** | **179.50 ns** | **187.51 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 179.30 ns | 47.254 ns | 2.590 ns | 176.31 ns | 180.94 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.73 ns | 42.929 ns | 2.353 ns | 196.55 ns | 201.23 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.33 ns | 13.500 ns | 0.740 ns |  57.60 ns |  59.08 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  57.96 ns |  2.481 ns | 0.136 ns |  57.84 ns |  58.11 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.09 ns |  7.303 ns | 0.400 ns |  58.64 ns |  59.40 ns |      - |         - |
