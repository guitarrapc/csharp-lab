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
| **LogWithoutIfParams**                         | **1**      |  **63.67 ns** |  **2.092 ns** | **0.115 ns** |  **63.57 ns** |  **63.79 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.47 ns |  4.330 ns | 0.237 ns |  59.31 ns |  59.74 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.26 ns |  0.965 ns | 0.053 ns |  65.20 ns |  65.30 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.87 ns |  0.919 ns | 0.050 ns |  19.82 ns |  19.92 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.74 ns |  1.305 ns | 0.072 ns |  19.70 ns |  19.83 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.19 ns |  0.889 ns | 0.049 ns |  19.15 ns |  19.24 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **186.48 ns** | **13.682 ns** | **0.750 ns** | **185.97 ns** | **187.34 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.94 ns | 44.144 ns | 2.420 ns | 180.50 ns | 184.73 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 205.12 ns | 48.921 ns | 2.682 ns | 203.48 ns | 208.21 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.23 ns |  6.089 ns | 0.334 ns |  59.03 ns |  59.61 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  59.18 ns |  2.078 ns | 0.114 ns |  59.11 ns |  59.31 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.22 ns |  0.524 ns | 0.029 ns |  59.18 ns |  59.23 ns |      - |         - |
