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
| **LogWithoutIfParams**                         | **1**      |  **60.13 ns** |  **3.248 ns** | **0.178 ns** |  **59.94 ns** |  **60.29 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.89 ns |  5.937 ns | 0.325 ns |  59.52 ns |  60.13 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.17 ns |  7.186 ns | 0.394 ns |  65.93 ns |  66.62 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |  1.164 ns | 0.064 ns |  19.84 ns |  19.96 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.87 ns |  0.331 ns | 0.018 ns |  19.86 ns |  19.89 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.28 ns |  1.694 ns | 0.093 ns |  19.19 ns |  19.38 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.49 ns** | **23.785 ns** | **1.304 ns** | **179.70 ns** | **182.00 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.63 ns | 23.278 ns | 1.276 ns | 177.33 ns | 179.88 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 193.79 ns |  5.618 ns | 0.308 ns | 193.44 ns | 194.01 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.93 ns |  0.107 ns | 0.006 ns |  58.92 ns |  58.93 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.31 ns |  0.400 ns | 0.022 ns |  58.29 ns |  58.34 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.89 ns |  0.673 ns | 0.037 ns |  57.86 ns |  57.93 ns |      - |         - |
