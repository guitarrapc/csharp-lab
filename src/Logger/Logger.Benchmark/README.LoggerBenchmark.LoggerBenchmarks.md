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
| **LogWithoutIfParams**                         | **1**      |  **60.88 ns** |  **23.462 ns** | **1.286 ns** |  **60.10 ns** |  **62.36 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.40 ns |   2.676 ns | 0.147 ns |  59.28 ns |  59.56 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.97 ns |   0.841 ns | 0.046 ns |  65.92 ns |  66.01 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.86 ns |   2.709 ns | 0.149 ns |  19.77 ns |  20.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.85 ns |   0.747 ns | 0.041 ns |  19.82 ns |  19.90 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.33 ns |   3.786 ns | 0.208 ns |  19.20 ns |  19.57 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **186.06 ns** |   **3.542 ns** | **0.194 ns** | **185.84 ns** | **186.19 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 182.83 ns | 101.369 ns | 5.556 ns | 179.37 ns | 189.24 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.44 ns |  84.141 ns | 4.612 ns | 196.49 ns | 204.75 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.88 ns |  18.355 ns | 1.006 ns |  59.28 ns |  61.04 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.22 ns |   0.287 ns | 0.016 ns |  58.21 ns |  58.24 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.26 ns |   0.947 ns | 0.052 ns |  57.20 ns |  57.30 ns |      - |         - |
