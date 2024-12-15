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
| **LogWithoutIfParams**                         | **1**      |  **60.92 ns** |  **1.327 ns** | **0.073 ns** |  **60.87 ns** |  **61.01 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  63.20 ns |  1.731 ns | 0.095 ns |  63.12 ns |  63.30 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.58 ns | 20.496 ns | 1.123 ns |  65.84 ns |  67.87 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.77 ns |  0.064 ns | 0.004 ns |  19.77 ns |  19.77 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.79 ns |  0.161 ns | 0.009 ns |  19.78 ns |  19.80 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.22 ns |  2.520 ns | 0.138 ns |  19.13 ns |  19.38 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.87 ns** |  **5.002 ns** | **0.274 ns** | **179.64 ns** | **180.17 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.97 ns |  6.475 ns | 0.355 ns | 178.60 ns | 179.30 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 203.02 ns |  1.616 ns | 0.089 ns | 202.93 ns | 203.11 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  60.39 ns | 25.930 ns | 1.421 ns |  59.20 ns |  61.96 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.95 ns |  0.808 ns | 0.044 ns |  58.92 ns |  59.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.62 ns |  2.792 ns | 0.153 ns |  57.51 ns |  57.80 ns |      - |         - |
