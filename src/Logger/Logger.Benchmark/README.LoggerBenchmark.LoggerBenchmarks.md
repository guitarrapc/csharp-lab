```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.58 ns** |  **3.484 ns** | **0.191 ns** |  **60.41 ns** |  **60.78 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  63.19 ns | 14.023 ns | 0.769 ns |  62.40 ns |  63.94 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.61 ns |  3.396 ns | 0.186 ns |  66.45 ns |  66.81 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.88 ns |  1.254 ns | 0.069 ns |  19.80 ns |  19.92 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.17 ns |  7.299 ns | 0.400 ns |  19.91 ns |  20.63 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.24 ns |  0.533 ns | 0.029 ns |  19.21 ns |  19.26 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.45 ns** |  **1.827 ns** | **0.100 ns** | **179.35 ns** | **179.54 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.58 ns |  9.266 ns | 0.508 ns | 178.25 ns | 179.17 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 202.28 ns |  7.631 ns | 0.418 ns | 201.81 ns | 202.61 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.30 ns |  1.311 ns | 0.072 ns |  59.23 ns |  59.38 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.42 ns |  2.288 ns | 0.125 ns |  58.30 ns |  58.55 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.16 ns |  0.767 ns | 0.042 ns |  57.11 ns |  57.19 ns |      - |         - |
