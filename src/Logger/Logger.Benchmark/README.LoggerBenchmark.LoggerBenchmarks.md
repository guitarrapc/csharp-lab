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
| **LogWithoutIfParams**                         | **1**      |  **61.90 ns** |  **2.376 ns** | **0.130 ns** |  **61.82 ns** |  **62.05 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.92 ns |  2.531 ns | 0.139 ns |  60.83 ns |  61.08 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  69.46 ns | 58.419 ns | 3.202 ns |  67.59 ns |  73.15 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.83 ns |  1.314 ns | 0.072 ns |  19.78 ns |  19.92 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.68 ns |  0.148 ns | 0.008 ns |  19.68 ns |  19.69 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.21 ns |  0.340 ns | 0.019 ns |  19.20 ns |  19.23 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.93 ns** |  **6.779 ns** | **0.372 ns** | **182.61 ns** | **183.34 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.58 ns |  5.953 ns | 0.326 ns | 178.27 ns | 178.92 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.38 ns |  3.269 ns | 0.179 ns | 197.19 ns | 197.55 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.13 ns |  1.886 ns | 0.103 ns |  59.03 ns |  59.23 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.22 ns |  0.699 ns | 0.038 ns |  58.19 ns |  58.27 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.56 ns |  4.920 ns | 0.270 ns |  57.37 ns |  57.87 ns |      - |         - |
