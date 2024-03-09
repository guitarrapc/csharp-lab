```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.90 ns** |  **7.282 ns** | **0.399 ns** |  **60.45 ns** |  **61.22 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.83 ns |  2.742 ns | 0.150 ns |  60.73 ns |  61.00 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.49 ns |  3.842 ns | 0.211 ns |  66.31 ns |  66.72 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.00 ns |  3.585 ns | 0.197 ns |  19.78 ns |  20.14 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.83 ns |  0.425 ns | 0.023 ns |  19.81 ns |  19.86 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.28 ns |  1.679 ns | 0.092 ns |  19.18 ns |  19.35 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.06 ns** | **17.961 ns** | **0.985 ns** | **179.97 ns** | **181.88 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 179.09 ns | 67.020 ns | 3.674 ns | 176.75 ns | 183.32 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 204.46 ns | 10.128 ns | 0.555 ns | 204.13 ns | 205.10 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  60.85 ns | 27.985 ns | 1.534 ns |  59.23 ns |  62.27 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.57 ns |  7.853 ns | 0.430 ns |  58.30 ns |  59.07 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.40 ns |  2.418 ns | 0.133 ns |  59.31 ns |  59.55 ns |      - |         - |
