```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.70 ns** |   **3.703 ns** | **0.203 ns** |  **61.56 ns** |  **61.93 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.87 ns |   4.320 ns | 0.237 ns |  60.69 ns |  61.14 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.40 ns |   3.777 ns | 0.207 ns |  66.24 ns |  66.63 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.85 ns |   1.025 ns | 0.056 ns |  19.80 ns |  19.91 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.71 ns |   0.336 ns | 0.018 ns |  19.70 ns |  19.73 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.26 ns |   3.476 ns | 0.191 ns |  19.15 ns |  19.48 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **189.27 ns** | **104.399 ns** | **5.722 ns** | **185.82 ns** | **195.87 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 189.26 ns |   6.816 ns | 0.374 ns | 188.91 ns | 189.65 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.66 ns |   5.505 ns | 0.302 ns | 198.45 ns | 199.01 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.17 ns |   0.206 ns | 0.011 ns |  59.16 ns |  59.18 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.09 ns |   1.367 ns | 0.075 ns |  58.05 ns |  58.18 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.67 ns |   0.661 ns | 0.036 ns |  57.63 ns |  57.70 ns |      - |         - |
