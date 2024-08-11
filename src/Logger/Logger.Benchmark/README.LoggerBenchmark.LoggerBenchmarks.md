```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.19 ns** |  **6.142 ns** | **0.337 ns** |  **60.88 ns** |  **61.55 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.11 ns |  4.100 ns | 0.225 ns |  58.95 ns |  59.36 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.34 ns |  5.703 ns | 0.313 ns |  66.08 ns |  66.69 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.09 ns |  2.195 ns | 0.120 ns |  20.01 ns |  20.23 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.81 ns |  0.546 ns | 0.030 ns |  19.78 ns |  19.84 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.20 ns |  0.520 ns | 0.029 ns |  19.17 ns |  19.23 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.20 ns** | **11.258 ns** | **0.617 ns** | **179.78 ns** | **180.91 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 185.56 ns | 15.287 ns | 0.838 ns | 184.78 ns | 186.45 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.90 ns | 45.847 ns | 2.513 ns | 197.16 ns | 201.78 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.16 ns |  5.045 ns | 0.277 ns |  59.00 ns |  59.48 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.24 ns |  0.724 ns | 0.040 ns |  58.20 ns |  58.28 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.84 ns |  2.109 ns | 0.116 ns |  57.72 ns |  57.95 ns |      - |         - |
