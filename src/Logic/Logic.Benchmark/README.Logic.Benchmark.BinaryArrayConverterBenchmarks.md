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
| **ToBinaryArrayInt**             | **1**      |  **18.46 ns** |  **7.891 ns** | **0.433 ns** |  **17.98 ns** |  **18.81 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.75 ns |  2.648 ns | 0.145 ns |  65.61 ns |  65.90 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.61 ns |  6.316 ns | 0.346 ns |  20.39 ns |  21.01 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.05 ns |  2.398 ns | 0.131 ns |  10.97 ns |  11.20 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.47 ns** | **11.121 ns** | **0.610 ns** |  **53.89 ns** |  **55.11 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 198.72 ns | 11.598 ns | 0.636 ns | 198.04 ns | 199.30 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.23 ns | 10.439 ns | 0.572 ns |  63.89 ns |  64.89 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.49 ns |  3.696 ns | 0.203 ns |  36.26 ns |  36.64 ns | 0.0011 |      96 B |
