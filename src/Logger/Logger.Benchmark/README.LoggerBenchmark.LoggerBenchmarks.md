```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.39 ns** |  **1.880 ns** | **0.103 ns** |  **61.29 ns** |  **61.50 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.36 ns |  2.334 ns | 0.128 ns |  59.25 ns |  59.50 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.68 ns |  4.117 ns | 0.226 ns |  65.44 ns |  65.89 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.96 ns |  2.691 ns | 0.147 ns |  19.85 ns |  20.12 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.95 ns |  0.629 ns | 0.034 ns |  19.91 ns |  19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.16 ns |  0.535 ns | 0.029 ns |  19.13 ns |  19.18 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.98 ns** | **45.761 ns** | **2.508 ns** | **178.51 ns** | **182.88 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 177.79 ns |  7.060 ns | 0.387 ns | 177.36 ns | 178.09 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.50 ns | 18.597 ns | 1.019 ns | 196.78 ns | 198.67 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.97 ns |  1.568 ns | 0.086 ns |  58.91 ns |  59.07 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.57 ns |  6.041 ns | 0.331 ns |  58.38 ns |  58.95 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.02 ns |  0.143 ns | 0.008 ns |  59.01 ns |  59.03 ns |      - |         - |
