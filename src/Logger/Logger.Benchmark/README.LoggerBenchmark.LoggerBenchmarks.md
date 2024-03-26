```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.89 ns** |  **0.782 ns** | **0.043 ns** |  **60.85 ns** |  **60.94 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.39 ns |  0.784 ns | 0.043 ns |  59.35 ns |  59.43 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.08 ns | 14.308 ns | 0.784 ns |  65.51 ns |  66.97 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.77 ns |  2.838 ns | 0.156 ns |  20.66 ns |  20.95 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.84 ns |  2.213 ns | 0.121 ns |  19.71 ns |  19.95 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.36 ns |  0.741 ns | 0.041 ns |  19.33 ns |  19.40 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.05 ns** | **33.367 ns** | **1.829 ns** | **180.30 ns** | **183.95 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.54 ns | 23.231 ns | 1.273 ns | 180.07 ns | 182.32 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.09 ns | 11.122 ns | 0.610 ns | 198.64 ns | 199.79 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  60.07 ns |  4.760 ns | 0.261 ns |  59.90 ns |  60.38 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.28 ns |  2.529 ns | 0.139 ns |  58.19 ns |  58.44 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.57 ns |  3.077 ns | 0.169 ns |  59.44 ns |  59.76 ns |      - |         - |
