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
| **LogWithoutIfParams**                         | **1**      |  **63.51 ns** |  **3.352 ns** | **0.184 ns** |  **63.30 ns** |  **63.64 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.26 ns |  3.983 ns | 0.218 ns |  59.07 ns |  59.50 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.56 ns |  6.227 ns | 0.341 ns |  65.21 ns |  65.89 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.85 ns |  2.499 ns | 0.137 ns |  19.77 ns |  20.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.87 ns |  1.435 ns | 0.079 ns |  19.78 ns |  19.92 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.24 ns |  1.190 ns | 0.065 ns |  19.19 ns |  19.31 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.37 ns** | **17.163 ns** | **0.941 ns** | **180.28 ns** | **181.92 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 175.52 ns |  6.037 ns | 0.331 ns | 175.28 ns | 175.90 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 192.22 ns |  8.510 ns | 0.466 ns | 191.89 ns | 192.76 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.10 ns |  2.726 ns | 0.149 ns |  58.95 ns |  59.25 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.70 ns | 13.101 ns | 0.718 ns |  58.24 ns |  59.53 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.77 ns | 22.570 ns | 1.237 ns |  57.05 ns |  59.20 ns |      - |         - |
