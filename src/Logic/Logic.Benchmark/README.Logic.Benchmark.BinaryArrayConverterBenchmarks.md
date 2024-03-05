```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.40 ns** |  **2.923 ns** | **0.160 ns** |  **18.29 ns** |  **18.59 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.65 ns |  0.758 ns | 0.042 ns |  66.61 ns |  66.69 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.62 ns |  3.772 ns | 0.207 ns |  20.42 ns |  20.83 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.99 ns |  3.724 ns | 0.204 ns |  10.82 ns |  11.22 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.94 ns** | **11.360 ns** | **0.623 ns** |  **58.58 ns** |  **59.66 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 198.20 ns |  8.362 ns | 0.458 ns | 197.69 ns | 198.58 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  65.63 ns | 24.169 ns | 1.325 ns |  64.15 ns |  66.69 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.14 ns |  4.359 ns | 0.239 ns |  35.96 ns |  36.41 ns | 0.0011 |      96 B |
