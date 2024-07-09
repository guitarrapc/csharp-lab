```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.28 ns** |  **2.978 ns** | **0.163 ns** |  **60.09 ns** |  **60.38 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.34 ns |  2.751 ns | 0.151 ns |  59.21 ns |  59.50 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.21 ns |  1.971 ns | 0.108 ns |  67.09 ns |  67.31 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.97 ns |  2.318 ns | 0.127 ns |  19.84 ns |  20.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.95 ns |  0.531 ns | 0.029 ns |  19.93 ns |  19.98 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.13 ns |  0.080 ns | 0.004 ns |  19.13 ns |  19.13 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **205.56 ns** | **17.742 ns** | **0.972 ns** | **204.57 ns** | **206.51 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 179.41 ns | 17.141 ns | 0.940 ns | 178.69 ns | 180.47 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.64 ns |  4.018 ns | 0.220 ns | 195.40 ns | 195.84 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.17 ns |  2.333 ns | 0.128 ns |  59.08 ns |  59.31 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.33 ns |  2.521 ns | 0.138 ns |  58.24 ns |  58.49 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.49 ns |  6.840 ns | 0.375 ns |  59.21 ns |  59.91 ns |      - |         - |
