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
| **LogWithoutIfParams**                         | **1**      |  **59.69 ns** |  **2.484 ns** | **0.136 ns** |  **59.54 ns** |  **59.78 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.49 ns | 28.934 ns | 1.586 ns |  59.56 ns |  62.32 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.96 ns |  6.735 ns | 0.369 ns |  66.67 ns |  67.37 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |  0.746 ns | 0.041 ns |  19.85 ns |  19.93 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.00 ns |  1.573 ns | 0.086 ns |  19.94 ns |  20.10 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.28 ns |  0.662 ns | 0.036 ns |  19.25 ns |  19.32 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.19 ns** |  **6.733 ns** | **0.369 ns** | **179.77 ns** | **180.46 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 179.29 ns | 57.845 ns | 3.171 ns | 177.42 ns | 182.95 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 201.07 ns | 10.324 ns | 0.566 ns | 200.56 ns | 201.68 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.10 ns |  0.577 ns | 0.032 ns |  59.08 ns |  59.13 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.30 ns |  2.017 ns | 0.111 ns |  58.23 ns |  58.43 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.98 ns |  0.976 ns | 0.053 ns |  59.92 ns |  60.02 ns |      - |         - |
