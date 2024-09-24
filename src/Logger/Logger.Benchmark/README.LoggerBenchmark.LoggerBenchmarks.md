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
| **LogWithoutIfParams**                         | **1**      |  **62.48 ns** | **15.508 ns** | **0.850 ns** |  **61.95 ns** |  **63.46 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.13 ns | 35.139 ns | 1.926 ns |  59.71 ns |  63.32 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.57 ns |  2.710 ns | 0.149 ns |  65.40 ns |  65.68 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.97 ns |  2.052 ns | 0.112 ns |  19.87 ns |  20.09 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.98 ns |  2.531 ns | 0.139 ns |  19.82 ns |  20.07 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.23 ns |  0.472 ns | 0.026 ns |  19.20 ns |  19.26 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.72 ns** | **10.122 ns** | **0.555 ns** | **181.09 ns** | **182.13 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 183.12 ns | 20.057 ns | 1.099 ns | 181.97 ns | 184.16 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.05 ns |  1.510 ns | 0.083 ns | 198.99 ns | 199.15 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.26 ns |  1.093 ns | 0.060 ns |  59.21 ns |  59.33 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.61 ns |  0.525 ns | 0.029 ns |  58.60 ns |  58.65 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.39 ns |  5.324 ns | 0.292 ns |  59.16 ns |  59.72 ns |      - |         - |
