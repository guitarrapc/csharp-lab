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
| **LogWithoutIfParams**                         | **1**      |  **61.59 ns** |  **4.645 ns** | **0.255 ns** |  **61.34 ns** |  **61.85 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.20 ns |  7.931 ns | 0.435 ns |  59.92 ns |  60.70 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.38 ns |  2.820 ns | 0.155 ns |  67.21 ns |  67.51 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.87 ns |  0.486 ns | 0.027 ns |  19.85 ns |  19.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.89 ns |  0.151 ns | 0.008 ns |  19.89 ns |  19.90 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.26 ns |  0.821 ns | 0.045 ns |  19.20 ns |  19.29 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **188.59 ns** |  **4.522 ns** | **0.248 ns** | **188.30 ns** | **188.75 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 186.66 ns | 18.130 ns | 0.994 ns | 185.65 ns | 187.63 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.91 ns |  4.741 ns | 0.260 ns | 197.62 ns | 198.12 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.38 ns |  4.138 ns | 0.227 ns |  59.22 ns |  59.64 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.52 ns |  0.155 ns | 0.009 ns |  58.51 ns |  58.53 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  86.23 ns |  0.761 ns | 0.042 ns |  86.18 ns |  86.27 ns |      - |         - |
