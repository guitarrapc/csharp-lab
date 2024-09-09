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
| **LogWithoutIfParams**                         | **1**      |  **61.48 ns** | **31.094 ns** | **1.704 ns** |  **60.46 ns** |  **63.45 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.04 ns | 17.529 ns | 0.961 ns |  59.39 ns |  61.14 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.80 ns |  0.596 ns | 0.033 ns |  64.76 ns |  64.82 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.80 ns |  0.069 ns | 0.004 ns |  19.79 ns |  19.80 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.07 ns |  4.160 ns | 0.228 ns |  19.82 ns |  20.27 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.19 ns |  1.419 ns | 0.078 ns |  19.12 ns |  19.27 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.36 ns** | **16.494 ns** | **0.904 ns** | **180.65 ns** | **182.37 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.84 ns |  2.008 ns | 0.110 ns | 178.74 ns | 178.96 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.98 ns |  6.268 ns | 0.344 ns | 195.58 ns | 196.21 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  60.26 ns |  6.085 ns | 0.334 ns |  60.03 ns |  60.64 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  61.41 ns | 67.226 ns | 3.685 ns |  59.28 ns |  65.66 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.07 ns |  0.663 ns | 0.036 ns |  57.03 ns |  57.10 ns |      - |         - |
