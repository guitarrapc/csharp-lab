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
| **LogWithoutIfParams**                         | **1**      |  **60.80 ns** |  **4.445 ns** | **0.244 ns** |  **60.54 ns** |  **61.01 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.31 ns |  4.399 ns | 0.241 ns |  60.14 ns |  60.58 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.72 ns |  7.850 ns | 0.430 ns |  65.25 ns |  66.10 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.93 ns |  3.582 ns | 0.196 ns |  19.79 ns |  20.15 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.98 ns |  1.886 ns | 0.103 ns |  19.92 ns |  20.10 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.47 ns |  0.900 ns | 0.049 ns |  19.44 ns |  19.53 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.93 ns** |  **3.224 ns** | **0.177 ns** | **180.73 ns** | **181.06 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 182.95 ns | 47.777 ns | 2.619 ns | 181.09 ns | 185.94 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.10 ns | 26.981 ns | 1.479 ns | 195.65 ns | 198.60 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.11 ns |  1.370 ns | 0.075 ns |  59.06 ns |  59.20 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.26 ns |  1.298 ns | 0.071 ns |  58.18 ns |  58.32 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.23 ns |  0.519 ns | 0.028 ns |  59.20 ns |  59.26 ns |      - |         - |
