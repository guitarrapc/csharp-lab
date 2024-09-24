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
| **LogWithoutIfParams**                         | **1**      |  **61.52 ns** |  **4.434 ns** | **0.243 ns** |  **61.26 ns** |  **61.74 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.73 ns | 27.029 ns | 1.482 ns |  59.83 ns |  62.44 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.32 ns |  8.932 ns | 0.490 ns |  66.97 ns |  67.88 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.03 ns |  1.841 ns | 0.101 ns |  19.97 ns |  20.14 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.02 ns |  3.183 ns | 0.174 ns |  19.90 ns |  20.22 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.53 ns |  0.399 ns | 0.022 ns |  19.51 ns |  19.55 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.14 ns** |  **5.059 ns** | **0.277 ns** | **181.86 ns** | **182.41 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.71 ns |  3.621 ns | 0.198 ns | 180.48 ns | 180.84 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 200.62 ns | 57.232 ns | 3.137 ns | 198.39 ns | 204.21 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.34 ns |  2.398 ns | 0.131 ns |  59.26 ns |  59.49 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.71 ns |  5.338 ns | 0.293 ns |  58.53 ns |  59.05 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.15 ns |  0.486 ns | 0.027 ns |  58.12 ns |  58.18 ns |      - |         - |
