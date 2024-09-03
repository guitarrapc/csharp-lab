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
| **LogWithoutIfParams**                         | **1**      |  **64.35 ns** |  **4.929 ns** | **0.270 ns** |  **64.12 ns** |  **64.65 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.64 ns |  2.873 ns | 0.158 ns |  59.49 ns |  59.80 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.91 ns |  1.080 ns | 0.059 ns |  65.85 ns |  65.97 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.84 ns |  0.735 ns | 0.040 ns |  19.81 ns |  19.88 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.89 ns |  1.742 ns | 0.095 ns |  19.81 ns |  20.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.14 ns |  0.298 ns | 0.016 ns |  19.13 ns |  19.16 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.20 ns** |  **5.604 ns** | **0.307 ns** | **179.99 ns** | **180.55 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.27 ns |  7.356 ns | 0.403 ns | 180.00 ns | 180.74 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 204.18 ns | 18.671 ns | 1.023 ns | 203.37 ns | 205.33 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.81 ns | 13.703 ns | 0.751 ns |  58.95 ns |  60.35 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  69.28 ns |  4.621 ns | 0.253 ns |  69.01 ns |  69.51 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.91 ns |  1.084 ns | 0.059 ns |  59.85 ns |  59.96 ns |      - |         - |
