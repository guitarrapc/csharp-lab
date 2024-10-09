```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.03 ns** |  **5.040 ns** | **0.276 ns** |  **60.76 ns** |  **61.31 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  62.71 ns | 30.650 ns | 1.680 ns |  60.93 ns |  64.27 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.85 ns |  7.076 ns | 0.388 ns |  66.53 ns |  67.28 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.79 ns |  1.084 ns | 0.059 ns |  19.76 ns |  19.86 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.08 ns |  1.719 ns | 0.094 ns |  19.97 ns |  20.16 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.15 ns |  0.533 ns | 0.029 ns |  19.12 ns |  19.18 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.27 ns** | **31.884 ns** | **1.748 ns** | **178.95 ns** | **182.25 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.88 ns | 12.230 ns | 0.670 ns | 178.21 ns | 179.55 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.36 ns |  3.253 ns | 0.178 ns | 197.19 ns | 197.55 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.15 ns |  2.863 ns | 0.157 ns |  59.02 ns |  59.33 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.50 ns |  7.345 ns | 0.403 ns |  58.21 ns |  58.96 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.14 ns |  3.785 ns | 0.207 ns |  56.99 ns |  57.37 ns |      - |         - |
