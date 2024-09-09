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
| **LogWithoutIfParams**                         | **1**      |  **60.72 ns** |  **2.254 ns** | **0.124 ns** |  **60.62 ns** |  **60.86 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.39 ns | 12.511 ns | 0.686 ns |  59.74 ns |  61.11 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.66 ns | 19.107 ns | 1.047 ns |  65.58 ns |  67.67 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.95 ns |  2.638 ns | 0.145 ns |  19.86 ns |  20.11 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.86 ns |  0.168 ns | 0.009 ns |  19.85 ns |  19.86 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.40 ns |  3.287 ns | 0.180 ns |  19.19 ns |  19.51 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.09 ns** |  **5.227 ns** | **0.287 ns** | **179.87 ns** | **180.42 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.17 ns | 12.337 ns | 0.676 ns | 179.40 ns | 180.63 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 231.76 ns | 14.753 ns | 0.809 ns | 231.14 ns | 232.68 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.97 ns |  0.862 ns | 0.047 ns |  58.94 ns |  59.02 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  57.77 ns |  0.276 ns | 0.015 ns |  57.75 ns |  57.78 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.26 ns |  1.410 ns | 0.077 ns |  58.19 ns |  58.34 ns |      - |         - |
