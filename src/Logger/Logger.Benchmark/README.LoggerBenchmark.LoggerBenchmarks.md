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
| **LogWithoutIfParams**                         | **1**      |  **61.91 ns** |  **4.160 ns** | **0.228 ns** |  **61.75 ns** |  **62.17 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.02 ns |  2.586 ns | 0.142 ns |  60.86 ns |  61.12 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.64 ns |  4.837 ns | 0.265 ns |  65.37 ns |  65.90 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.13 ns |  2.014 ns | 0.110 ns |  20.05 ns |  20.25 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.12 ns |  1.537 ns | 0.084 ns |  20.06 ns |  20.21 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.38 ns |  0.774 ns | 0.042 ns |  19.35 ns |  19.42 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **183.70 ns** | **13.822 ns** | **0.758 ns** | **183.24 ns** | **184.58 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.92 ns |  7.792 ns | 0.427 ns | 181.44 ns | 182.26 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 205.45 ns | 16.174 ns | 0.887 ns | 204.43 ns | 206.07 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  60.23 ns |  3.587 ns | 0.197 ns |  60.09 ns |  60.46 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.73 ns |  2.269 ns | 0.124 ns |  58.64 ns |  58.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.28 ns |  0.640 ns | 0.035 ns |  59.24 ns |  59.31 ns |      - |         - |
