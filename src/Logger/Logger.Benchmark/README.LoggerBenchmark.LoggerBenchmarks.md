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
| **LogWithoutIfParams**                         | **1**      |  **60.70 ns** |  **6.432 ns** | **0.353 ns** |  **60.47 ns** |  **61.11 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.69 ns |  6.593 ns | 0.361 ns |  59.32 ns |  60.04 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.16 ns | 36.317 ns | 1.991 ns |  65.21 ns |  69.19 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.88 ns |  0.087 ns | 0.005 ns |  19.87 ns |  19.88 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.91 ns |  1.608 ns | 0.088 ns |  19.81 ns |  19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.20 ns |  1.413 ns | 0.077 ns |  19.11 ns |  19.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **183.40 ns** | **10.679 ns** | **0.585 ns** | **182.83 ns** | **184.00 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.21 ns | 39.963 ns | 2.190 ns | 176.56 ns | 180.70 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 193.27 ns | 11.176 ns | 0.613 ns | 192.67 ns | 193.89 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.21 ns |  6.385 ns | 0.350 ns |  58.98 ns |  59.61 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.67 ns | 10.105 ns | 0.554 ns |  58.27 ns |  59.30 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.99 ns |  2.741 ns | 0.150 ns |  58.88 ns |  59.16 ns |      - |         - |
