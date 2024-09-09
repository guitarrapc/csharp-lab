```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **63.85 ns** | **3.192 ns** | **0.175 ns** |  **63.72 ns** |  **64.05 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.33 ns | 8.350 ns | 0.458 ns |  59.05 ns |  59.86 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.08 ns | 4.672 ns | 0.256 ns |  64.85 ns |  65.36 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.84 ns | 1.890 ns | 0.104 ns |  19.77 ns |  19.95 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.80 ns | 0.286 ns | 0.016 ns |  19.78 ns |  19.81 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.37 ns | 2.921 ns | 0.160 ns |  19.19 ns |  19.49 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.30 ns** | **2.898 ns** | **0.159 ns** | **179.14 ns** | **179.45 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 177.93 ns | 2.245 ns | 0.123 ns | 177.79 ns | 178.01 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.51 ns | 2.143 ns | 0.117 ns | 197.42 ns | 197.65 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.03 ns | 1.000 ns | 0.055 ns |  58.97 ns |  59.08 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.20 ns | 0.918 ns | 0.050 ns |  58.16 ns |  58.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.78 ns | 3.451 ns | 0.189 ns |  59.64 ns |  60.00 ns |      - |         - |
