```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.50 ns** |  **2.218 ns** | **0.122 ns** |  **60.43 ns** |  **60.64 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.31 ns |  2.287 ns | 0.125 ns |  60.18 ns |  60.43 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.87 ns | 32.057 ns | 1.757 ns |  65.66 ns |  68.88 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.99 ns |  5.722 ns | 0.314 ns |  19.81 ns |  20.35 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.82 ns |  0.437 ns | 0.024 ns |  19.81 ns |  19.85 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.27 ns |  0.703 ns | 0.039 ns |  19.24 ns |  19.31 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **186.97 ns** |  **5.955 ns** | **0.326 ns** | **186.60 ns** | **187.23 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 182.91 ns |  2.118 ns | 0.116 ns | 182.80 ns | 183.03 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.76 ns | 10.893 ns | 0.597 ns | 196.33 ns | 197.44 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.67 ns |  2.246 ns | 0.123 ns |  59.60 ns |  59.81 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.24 ns |  1.222 ns | 0.067 ns |  58.19 ns |  58.32 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.29 ns |  2.440 ns | 0.134 ns |  59.18 ns |  59.44 ns |      - |         - |
