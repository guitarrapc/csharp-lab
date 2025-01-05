```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **56.16 ns** |  **4.164 ns** | **0.228 ns** |  **55.98 ns** |  **56.42 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  56.68 ns |  3.178 ns | 0.174 ns |  56.52 ns |  56.87 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.84 ns |  2.990 ns | 0.164 ns |  65.65 ns |  65.96 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.98 ns |  0.608 ns | 0.033 ns |  19.95 ns |  20.02 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.09 ns |  0.431 ns | 0.024 ns |  20.07 ns |  20.11 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.61 ns | 11.214 ns | 0.615 ns |  19.23 ns |  20.31 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **171.83 ns** | **17.104 ns** | **0.938 ns** | **171.08 ns** | **172.88 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 168.80 ns | 35.879 ns | 1.967 ns | 167.15 ns | 170.97 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 188.48 ns |  7.947 ns | 0.436 ns | 188.10 ns | 188.96 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.44 ns |  0.531 ns | 0.029 ns |  59.42 ns |  59.47 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.25 ns |  1.600 ns | 0.088 ns |  58.17 ns |  58.34 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.96 ns |  0.857 ns | 0.047 ns |  57.93 ns |  58.01 ns |      - |         - |
