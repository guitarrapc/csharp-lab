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
| **LogWithoutIfParams**                         | **1**      |  **57.04 ns** |  **0.452 ns** | **0.025 ns** |  **57.02 ns** |  **57.07 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  57.87 ns | 10.399 ns | 0.570 ns |  57.36 ns |  58.49 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  61.87 ns |  6.485 ns | 0.355 ns |  61.55 ns |  62.25 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.04 ns |  1.670 ns | 0.092 ns |  19.98 ns |  20.15 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.06 ns |  1.800 ns | 0.099 ns |  19.95 ns |  20.12 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.34 ns |  1.554 ns | 0.085 ns |  19.29 ns |  19.44 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **172.50 ns** | **93.403 ns** | **5.120 ns** | **169.11 ns** | **178.39 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 169.16 ns | 14.425 ns | 0.791 ns | 168.42 ns | 169.99 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 189.48 ns | 62.245 ns | 3.412 ns | 187.12 ns | 193.40 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.28 ns |  1.081 ns | 0.059 ns |  59.23 ns |  59.35 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.26 ns |  1.077 ns | 0.059 ns |  58.20 ns |  58.31 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.00 ns |  1.150 ns | 0.063 ns |  57.95 ns |  58.07 ns |      - |         - |
