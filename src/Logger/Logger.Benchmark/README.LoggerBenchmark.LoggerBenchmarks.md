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
| **LogWithoutIfParams**                         | **1**      |  **60.69 ns** |  **6.524 ns** | **0.358 ns** |  **60.48 ns** |  **61.11 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.00 ns |  5.315 ns | 0.291 ns |  58.70 ns |  59.29 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.89 ns |  8.126 ns | 0.445 ns |  65.60 ns |  66.40 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.96 ns |  2.008 ns | 0.110 ns |  19.83 ns |  20.04 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.76 ns |  0.106 ns | 0.006 ns |  19.76 ns |  19.77 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.23 ns |  0.012 ns | 0.001 ns |  19.23 ns |  19.23 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.17 ns** | **17.893 ns** | **0.981 ns** | **179.06 ns** | **180.91 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 177.83 ns | 12.716 ns | 0.697 ns | 177.20 ns | 178.58 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.28 ns | 49.175 ns | 2.695 ns | 193.60 ns | 198.99 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.14 ns |  1.587 ns | 0.087 ns |  59.05 ns |  59.22 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.56 ns |  2.928 ns | 0.161 ns |  58.38 ns |  58.67 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.68 ns | 31.721 ns | 1.739 ns |  57.67 ns |  60.69 ns |      - |         - |
