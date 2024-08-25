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
| **LogWithoutIfParams**                         | **1**      |  **61.20 ns** |  **2.948 ns** | **0.162 ns** |  **61.04 ns** |  **61.36 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.44 ns |  1.588 ns | 0.087 ns |  59.36 ns |  59.53 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.02 ns |  7.732 ns | 0.424 ns |  65.53 ns |  66.27 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.79 ns |  0.976 ns | 0.054 ns |  19.74 ns |  19.84 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.84 ns |  0.496 ns | 0.027 ns |  19.82 ns |  19.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.20 ns |  3.601 ns | 0.197 ns |  19.08 ns |  19.43 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.87 ns** | **40.562 ns** | **2.223 ns** | **179.68 ns** | **184.13 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 187.87 ns | 15.466 ns | 0.848 ns | 187.35 ns | 188.85 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.45 ns | 59.885 ns | 3.282 ns | 195.37 ns | 201.24 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.37 ns |  5.701 ns | 0.312 ns |  59.01 ns |  59.58 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  57.03 ns | 10.362 ns | 0.568 ns |  56.40 ns |  57.50 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.98 ns | 46.921 ns | 2.572 ns |  56.46 ns |  60.95 ns |      - |         - |
