```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.23 ns** |  **0.607 ns** | **0.033 ns** |  **61.20 ns** |  **61.27 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.44 ns |  1.399 ns | 0.077 ns |  59.38 ns |  59.53 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.72 ns |  2.755 ns | 0.151 ns |  67.55 ns |  67.83 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |  0.035 ns | 0.002 ns |  19.88 ns |  19.89 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.87 ns |  0.171 ns | 0.009 ns |  19.86 ns |  19.88 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.21 ns |  1.810 ns | 0.099 ns |  19.14 ns |  19.32 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.16 ns** |  **9.248 ns** | **0.507 ns** | **181.66 ns** | **182.67 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.62 ns | 11.656 ns | 0.639 ns | 181.08 ns | 182.32 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.73 ns | 17.903 ns | 0.981 ns | 198.73 ns | 200.69 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.62 ns |  0.686 ns | 0.038 ns |  59.57 ns |  59.64 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.54 ns |  0.716 ns | 0.039 ns |  58.52 ns |  58.59 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.50 ns |  0.288 ns | 0.016 ns |  57.49 ns |  57.52 ns |      - |         - |
