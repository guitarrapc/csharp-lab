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
| **LogWithoutIfParams**                         | **1**      |  **61.60 ns** |  **0.655 ns** | **0.036 ns** |  **61.56 ns** |  **61.63 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  65.82 ns | 27.639 ns | 1.515 ns |  64.36 ns |  67.38 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  74.13 ns | 66.976 ns | 3.671 ns |  71.12 ns |  78.22 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.99 ns |  0.246 ns | 0.013 ns |  19.98 ns |  20.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.97 ns |  0.641 ns | 0.035 ns |  19.93 ns |  20.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.24 ns |  0.197 ns | 0.011 ns |  19.23 ns |  19.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **189.13 ns** | **14.079 ns** | **0.772 ns** | **188.32 ns** | **189.86 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 186.56 ns | 14.397 ns | 0.789 ns | 185.65 ns | 187.09 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.31 ns | 32.207 ns | 1.765 ns | 197.18 ns | 200.34 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.36 ns |  3.120 ns | 0.171 ns |  59.24 ns |  59.55 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.92 ns |  2.714 ns | 0.149 ns |  58.83 ns |  59.09 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.57 ns |  2.956 ns | 0.162 ns |  58.44 ns |  58.75 ns |      - |         - |
