```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.56 ns** |  **1.482 ns** | **0.081 ns** |  **61.47 ns** |  **61.62 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.42 ns | 21.881 ns | 1.199 ns |  59.48 ns |  61.77 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.69 ns |  8.344 ns | 0.457 ns |  66.17 ns |  67.00 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.78 ns |  0.119 ns | 0.007 ns |  19.77 ns |  19.79 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.89 ns |  2.599 ns | 0.142 ns |  19.79 ns |  20.06 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.16 ns |  0.660 ns | 0.036 ns |  19.12 ns |  19.20 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **184.44 ns** |  **8.849 ns** | **0.485 ns** | **184.01 ns** | **184.97 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.14 ns |  2.289 ns | 0.125 ns | 180.01 ns | 180.26 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 204.52 ns | 12.307 ns | 0.675 ns | 204.00 ns | 205.28 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.99 ns |  0.436 ns | 0.024 ns |  58.96 ns |  59.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.29 ns |  1.108 ns | 0.061 ns |  58.25 ns |  58.36 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.96 ns |  0.904 ns | 0.050 ns |  57.90 ns |  57.99 ns |      - |         - |
