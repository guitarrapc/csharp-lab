```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.69 ns** |  **2.126 ns** | **0.117 ns** |  **60.59 ns** |  **60.82 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.33 ns |  0.766 ns | 0.042 ns |  60.29 ns |  60.37 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.65 ns |  2.204 ns | 0.121 ns |  65.56 ns |  65.79 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.19 ns | 10.235 ns | 0.561 ns |  19.86 ns |  20.83 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.12 ns |  5.591 ns | 0.306 ns |  19.94 ns |  20.47 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.24 ns |  2.360 ns | 0.129 ns |  19.15 ns |  19.39 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **183.97 ns** |  **5.723 ns** | **0.314 ns** | **183.68 ns** | **184.30 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.40 ns | 58.488 ns | 3.206 ns | 179.47 ns | 185.10 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.25 ns |  8.686 ns | 0.476 ns | 194.72 ns | 195.64 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.95 ns |  0.866 ns | 0.047 ns |  58.91 ns |  59.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.28 ns |  0.257 ns | 0.014 ns |  58.26 ns |  58.29 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.39 ns |  2.340 ns | 0.128 ns |  57.28 ns |  57.53 ns |      - |         - |
