```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.24 ns** |  **0.895 ns** | **0.049 ns** |  **61.19 ns** |  **61.29 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.35 ns |  3.190 ns | 0.175 ns |  59.17 ns |  59.52 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.81 ns |  6.115 ns | 0.335 ns |  65.50 ns |  66.17 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.79 ns |  0.644 ns | 0.035 ns |  19.76 ns |  19.83 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.86 ns |  0.438 ns | 0.024 ns |  19.83 ns |  19.88 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.44 ns |  1.797 ns | 0.098 ns |  19.33 ns |  19.53 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.75 ns** | **20.524 ns** | **1.125 ns** | **181.83 ns** | **184.01 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 179.83 ns | 10.191 ns | 0.559 ns | 179.50 ns | 180.47 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.53 ns | 20.010 ns | 1.097 ns | 198.70 ns | 200.77 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.39 ns |  7.565 ns | 0.415 ns |  58.93 ns |  59.73 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.38 ns |  1.877 ns | 0.103 ns |  58.32 ns |  58.50 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.12 ns | 16.244 ns | 0.890 ns |  57.58 ns |  59.15 ns |      - |         - |
