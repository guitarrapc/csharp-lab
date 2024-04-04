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
| **LogWithoutIfParams**                         | **1**      |  **64.49 ns** |  **8.373 ns** | **0.459 ns** |  **64.13 ns** |  **65.00 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.00 ns |  2.141 ns | 0.117 ns |  59.89 ns |  60.13 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.86 ns |  4.768 ns | 0.261 ns |  65.57 ns |  66.06 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.01 ns |  4.925 ns | 0.270 ns |  19.85 ns |  20.32 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.99 ns |  0.910 ns | 0.050 ns |  19.93 ns |  20.03 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.15 ns |  0.243 ns | 0.013 ns |  19.14 ns |  19.16 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.72 ns** |  **7.521 ns** | **0.412 ns** | **181.25 ns** | **182.01 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.75 ns | 19.525 ns | 1.070 ns | 178.12 ns | 179.99 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.17 ns |  3.513 ns | 0.193 ns | 198.96 ns | 199.33 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.93 ns |  2.622 ns | 0.144 ns |  58.85 ns |  59.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.45 ns |  1.125 ns | 0.062 ns |  58.41 ns |  58.52 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.80 ns |  2.836 ns | 0.155 ns |  57.71 ns |  57.98 ns |      - |         - |
