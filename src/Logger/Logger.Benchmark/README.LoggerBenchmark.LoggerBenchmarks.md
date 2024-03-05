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
| **LogWithoutIfParams**                         | **1**      |  **60.17 ns** |  **6.435 ns** | **0.353 ns** |  **59.89 ns** |  **60.57 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  58.90 ns |  4.837 ns | 0.265 ns |  58.61 ns |  59.13 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.73 ns | 29.316 ns | 1.607 ns |  65.20 ns |  68.40 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.95 ns |  1.814 ns | 0.099 ns |  19.84 ns |  20.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.73 ns |  1.231 ns | 0.067 ns |  19.68 ns |  19.80 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.23 ns |  2.377 ns | 0.130 ns |  19.13 ns |  19.38 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.31 ns** |  **4.489 ns** | **0.246 ns** | **181.02 ns** | **181.47 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 175.65 ns | 18.387 ns | 1.008 ns | 174.56 ns | 176.55 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.41 ns | 15.617 ns | 0.856 ns | 194.80 ns | 196.39 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.99 ns |  0.229 ns | 0.013 ns |  58.98 ns |  59.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.22 ns |  0.146 ns | 0.008 ns |  58.21 ns |  58.23 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  60.77 ns | 47.568 ns | 2.607 ns |  59.17 ns |  63.78 ns |      - |         - |
