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
| **LogWithoutIfParams**                         | **1**      |  **63.95 ns** |  **3.424 ns** | **0.188 ns** |  **63.74 ns** |  **64.08 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.10 ns |  1.928 ns | 0.106 ns |  59.04 ns |  59.22 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.16 ns | 17.304 ns | 0.948 ns |  65.30 ns |  67.18 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.95 ns |  2.695 ns | 0.148 ns |  19.85 ns |  20.12 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.98 ns |  1.047 ns | 0.057 ns |  19.91 ns |  20.03 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.14 ns |  0.104 ns | 0.006 ns |  19.13 ns |  19.14 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.89 ns** |  **6.199 ns** | **0.340 ns** | **180.50 ns** | **181.13 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 177.36 ns |  3.062 ns | 0.168 ns | 177.18 ns | 177.51 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.95 ns | 66.365 ns | 3.638 ns | 194.49 ns | 201.13 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.97 ns |  0.783 ns | 0.043 ns |  58.92 ns |  59.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.27 ns |  0.111 ns | 0.006 ns |  58.27 ns |  58.28 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.69 ns |  1.397 ns | 0.077 ns |  57.63 ns |  57.78 ns |      - |         - |
