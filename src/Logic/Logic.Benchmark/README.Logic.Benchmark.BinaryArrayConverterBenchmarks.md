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
| **ToBinaryArrayInt**             | **1**      |  **17.86 ns** | **10.480 ns** | **0.574 ns** |  **17.20 ns** |  **18.26 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.37 ns | 23.421 ns | 1.284 ns |  66.52 ns |  68.84 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.29 ns |  2.479 ns | 0.136 ns |  20.21 ns |  20.45 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.74 ns |  0.805 ns | 0.044 ns |  10.71 ns |  10.80 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.83 ns** | **13.228 ns** | **0.725 ns** |  **58.12 ns** |  **59.57 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 200.25 ns | 25.126 ns | 1.377 ns | 198.69 ns | 201.28 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  65.05 ns | 16.019 ns | 0.878 ns |  64.43 ns |  66.05 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.28 ns |  3.574 ns | 0.196 ns |  35.09 ns |  35.48 ns | 0.0011 |      96 B |
