```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.64 ns** |  **2.911 ns** | **0.160 ns** |  **61.49 ns** |  **61.81 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.13 ns |  7.656 ns | 0.420 ns |  59.79 ns |  60.60 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  69.16 ns | 15.572 ns | 0.854 ns |  68.57 ns |  70.14 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |  0.130 ns | 0.007 ns |  19.89 ns |  19.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.01 ns |  1.755 ns | 0.096 ns |  19.93 ns |  20.11 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.55 ns |  0.491 ns | 0.027 ns |  19.53 ns |  19.58 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **185.17 ns** |  **7.286 ns** | **0.399 ns** | **184.83 ns** | **185.61 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 183.61 ns |  3.220 ns | 0.176 ns | 183.42 ns | 183.77 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.12 ns |  1.135 ns | 0.062 ns | 199.05 ns | 199.17 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.44 ns |  1.271 ns | 0.070 ns |  59.39 ns |  59.52 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.56 ns |  1.151 ns | 0.063 ns |  58.52 ns |  58.63 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.55 ns |  1.780 ns | 0.098 ns |  57.46 ns |  57.65 ns |      - |         - |
