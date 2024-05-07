```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **63.48 ns** |  **5.906 ns** | **0.324 ns** |  **63.19 ns** |  **63.83 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.22 ns |  2.497 ns | 0.137 ns |  61.12 ns |  61.38 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.53 ns |  6.738 ns | 0.369 ns |  65.12 ns |  65.83 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.22 ns | 10.504 ns | 0.576 ns |  19.86 ns |  20.89 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.83 ns |  0.532 ns | 0.029 ns |  19.80 ns |  19.86 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.16 ns |  0.758 ns | 0.042 ns |  19.13 ns |  19.20 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **184.10 ns** | **54.539 ns** | **2.989 ns** | **182.25 ns** | **187.55 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.83 ns | 38.123 ns | 2.090 ns | 178.56 ns | 182.67 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 204.79 ns | 11.998 ns | 0.658 ns | 204.06 ns | 205.35 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.13 ns |  4.964 ns | 0.272 ns |  58.98 ns |  59.45 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.52 ns |  2.343 ns | 0.128 ns |  58.37 ns |  58.61 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.17 ns |  0.679 ns | 0.037 ns |  58.13 ns |  58.20 ns |      - |         - |
