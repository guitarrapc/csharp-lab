```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.71 ns** |  **2.921 ns** | **0.160 ns** |  **60.55 ns** |  **60.87 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.09 ns |  7.522 ns | 0.412 ns |  59.68 ns |  60.50 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.38 ns |  2.097 ns | 0.115 ns |  66.28 ns |  66.51 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.88 ns |  0.462 ns | 0.025 ns |  19.85 ns |  19.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.73 ns |  0.577 ns | 0.032 ns |  19.70 ns |  19.76 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.29 ns |  0.486 ns | 0.027 ns |  19.27 ns |  19.32 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **185.62 ns** |  **8.819 ns** | **0.483 ns** | **185.27 ns** | **186.18 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.52 ns | 10.038 ns | 0.550 ns | 177.91 ns | 178.97 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 202.37 ns |  3.325 ns | 0.182 ns | 202.16 ns | 202.49 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.95 ns |  0.754 ns | 0.041 ns |  58.92 ns |  59.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.26 ns |  0.751 ns | 0.041 ns |  58.22 ns |  58.30 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.72 ns |  4.086 ns | 0.224 ns |  57.56 ns |  57.97 ns |      - |         - |
