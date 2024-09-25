```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **62.33 ns** |  **6.683 ns** | **0.366 ns** |  **62.01 ns** |  **62.73 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.43 ns |  2.574 ns | 0.141 ns |  59.30 ns |  59.58 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.68 ns |  1.115 ns | 0.061 ns |  64.63 ns |  64.75 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |  0.282 ns | 0.015 ns |  19.88 ns |  19.91 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.77 ns |  0.268 ns | 0.015 ns |  19.76 ns |  19.79 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.24 ns |  0.193 ns | 0.011 ns |  19.23 ns |  19.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.24 ns** |  **8.847 ns** | **0.485 ns** | **179.68 ns** | **180.55 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 182.49 ns | 23.638 ns | 1.296 ns | 181.72 ns | 183.98 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.31 ns |  5.762 ns | 0.316 ns | 195.97 ns | 196.59 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.31 ns |  0.724 ns | 0.040 ns |  59.28 ns |  59.35 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.60 ns |  0.546 ns | 0.030 ns |  58.57 ns |  58.62 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.50 ns |  1.347 ns | 0.074 ns |  57.43 ns |  57.57 ns |      - |         - |
