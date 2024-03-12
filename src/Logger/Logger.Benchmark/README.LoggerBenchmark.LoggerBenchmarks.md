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
| **LogWithoutIfParams**                         | **1**      |  **64.53 ns** |  **3.440 ns** | **0.189 ns** |  **64.37 ns** |  **64.73 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  62.32 ns | 11.336 ns | 0.621 ns |  61.62 ns |  62.80 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.15 ns | 12.629 ns | 0.692 ns |  67.45 ns |  68.83 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  28.79 ns |  5.389 ns | 0.295 ns |  28.55 ns |  29.12 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.79 ns |  0.794 ns | 0.044 ns |  19.74 ns |  19.83 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.58 ns |  2.153 ns | 0.118 ns |  19.46 ns |  19.69 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **187.62 ns** | **20.379 ns** | **1.117 ns** | **186.77 ns** | **188.88 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 184.53 ns | 31.846 ns | 1.746 ns | 182.99 ns | 186.43 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 205.21 ns | 10.421 ns | 0.571 ns | 204.71 ns | 205.83 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.16 ns |  2.306 ns | 0.126 ns |  59.05 ns |  59.30 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.57 ns |  0.878 ns | 0.048 ns |  58.52 ns |  58.62 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.37 ns |  9.434 ns | 0.517 ns |  57.84 ns |  58.88 ns |      - |         - |
