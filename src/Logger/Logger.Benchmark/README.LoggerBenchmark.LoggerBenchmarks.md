```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.99 ns** |  **2.513 ns** | **0.138 ns** |  **60.87 ns** |  **61.14 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.88 ns | 22.403 ns | 1.228 ns |  59.84 ns |  62.23 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.82 ns |  0.739 ns | 0.040 ns |  65.78 ns |  65.86 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.00 ns |  0.300 ns | 0.016 ns |  19.98 ns |  20.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.98 ns |  0.852 ns | 0.047 ns |  19.94 ns |  20.03 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  21.62 ns |  0.465 ns | 0.025 ns |  21.59 ns |  21.64 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **183.03 ns** | **13.586 ns** | **0.745 ns** | **182.37 ns** | **183.83 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 185.00 ns | 10.582 ns | 0.580 ns | 184.37 ns | 185.51 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 201.69 ns |  9.081 ns | 0.498 ns | 201.14 ns | 202.10 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.26 ns |  0.532 ns | 0.029 ns |  59.23 ns |  59.29 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.51 ns |  0.190 ns | 0.010 ns |  58.50 ns |  58.52 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.61 ns |  4.462 ns | 0.245 ns |  57.34 ns |  57.81 ns |      - |         - |
