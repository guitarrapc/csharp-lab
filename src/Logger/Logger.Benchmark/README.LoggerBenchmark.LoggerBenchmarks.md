```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.38 ns** |  **37.923 ns** | **2.079 ns** |  **60.17 ns** |  **63.78 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  62.57 ns |  76.360 ns | 4.186 ns |  60.11 ns |  67.40 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  70.18 ns |  30.378 ns | 1.665 ns |  69.03 ns |  72.09 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.91 ns |   1.347 ns | 0.074 ns |  19.86 ns |  20.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.86 ns |   1.437 ns | 0.079 ns |  19.80 ns |  19.95 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.17 ns |   1.122 ns | 0.061 ns |  19.13 ns |  19.24 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.49 ns** |   **8.990 ns** | **0.493 ns** | **180.10 ns** | **181.05 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 183.15 ns | 151.481 ns | 8.303 ns | 177.36 ns | 192.67 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 203.60 ns |  13.180 ns | 0.722 ns | 202.77 ns | 204.03 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.03 ns |   4.411 ns | 0.242 ns |  58.88 ns |  59.31 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.33 ns |   1.559 ns | 0.085 ns |  58.27 ns |  58.43 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.48 ns |   2.317 ns | 0.127 ns |  58.37 ns |  58.61 ns |      - |         - |
