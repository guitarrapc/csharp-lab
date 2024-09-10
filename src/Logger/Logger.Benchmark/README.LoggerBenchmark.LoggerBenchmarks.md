```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.26 ns** |  **0.210 ns** | **0.012 ns** |  **61.24 ns** |  **61.27 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.82 ns |  3.654 ns | 0.200 ns |  60.68 ns |  61.05 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.01 ns |  8.519 ns | 0.467 ns |  64.56 ns |  65.49 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.03 ns |  1.284 ns | 0.070 ns |  19.97 ns |  20.11 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.82 ns |  1.125 ns | 0.062 ns |  19.78 ns |  19.89 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.56 ns |  3.240 ns | 0.178 ns |  19.46 ns |  19.77 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.10 ns** |  **9.822 ns** | **0.538 ns** | **181.59 ns** | **182.66 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 196.60 ns | 14.153 ns | 0.776 ns | 196.10 ns | 197.50 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 200.34 ns | 16.879 ns | 0.925 ns | 199.28 ns | 201.01 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.87 ns |  4.583 ns | 0.251 ns |  59.68 ns |  60.15 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.36 ns |  4.778 ns | 0.262 ns |  58.21 ns |  58.66 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.63 ns |  1.829 ns | 0.100 ns |  57.52 ns |  57.72 ns |      - |         - |
