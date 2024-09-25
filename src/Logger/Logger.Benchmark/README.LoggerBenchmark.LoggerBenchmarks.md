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
| **LogWithoutIfParams**                         | **1**      |  **62.72 ns** |  **6.072 ns** | **0.333 ns** |  **62.46 ns** |  **63.10 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  67.60 ns |  3.581 ns | 0.196 ns |  67.41 ns |  67.80 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.36 ns |  6.000 ns | 0.329 ns |  66.12 ns |  66.73 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.14 ns |  0.088 ns | 0.005 ns |  20.14 ns |  20.15 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.97 ns |  0.160 ns | 0.009 ns |  19.96 ns |  19.98 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.31 ns |  0.352 ns | 0.019 ns |  19.29 ns |  19.33 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.08 ns** | **12.468 ns** | **0.683 ns** | **181.30 ns** | **182.54 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.36 ns |  8.286 ns | 0.454 ns | 179.84 ns | 180.70 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 200.23 ns |  5.495 ns | 0.301 ns | 200.04 ns | 200.58 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.95 ns |  3.508 ns | 0.192 ns |  59.73 ns |  60.09 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.62 ns |  1.259 ns | 0.069 ns |  58.57 ns |  58.70 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.50 ns |  2.929 ns | 0.161 ns |  57.35 ns |  57.67 ns |      - |         - |
