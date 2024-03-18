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
| **LogWithoutIfParams**                         | **1**      |  **59.98 ns** | **12.536 ns** | **0.687 ns** |  **59.53 ns** |  **60.77 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.36 ns |  4.228 ns | 0.232 ns |  59.14 ns |  59.60 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.35 ns | 46.959 ns | 2.574 ns |  65.76 ns |  70.32 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.14 ns |  5.474 ns | 0.300 ns |  19.84 ns |  20.44 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.82 ns |  0.642 ns | 0.035 ns |  19.78 ns |  19.85 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.22 ns |  0.337 ns | 0.018 ns |  19.20 ns |  19.24 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.35 ns** | **62.055 ns** | **3.401 ns** | **178.55 ns** | **185.11 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.21 ns | 58.995 ns | 3.234 ns | 178.14 ns | 183.93 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 193.46 ns |  4.070 ns | 0.223 ns | 193.22 ns | 193.66 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.95 ns |  0.688 ns | 0.038 ns |  58.91 ns |  58.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  59.11 ns | 21.866 ns | 1.199 ns |  58.29 ns |  60.49 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.45 ns |  3.712 ns | 0.203 ns |  57.27 ns |  57.67 ns |      - |         - |
