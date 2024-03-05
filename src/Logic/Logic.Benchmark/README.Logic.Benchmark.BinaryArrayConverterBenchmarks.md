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
| **ToBinaryArrayInt**             | **1**      |  **17.95 ns** |  **2.870 ns** | **0.157 ns** |  **17.79 ns** |  **18.11 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.17 ns |  9.033 ns | 0.495 ns |  65.88 ns |  66.74 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.60 ns |  4.708 ns | 0.258 ns |  20.33 ns |  20.84 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.04 ns |  0.504 ns | 0.028 ns |  11.01 ns |  11.06 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.55 ns** |  **4.485 ns** | **0.246 ns** |  **58.39 ns** |  **58.83 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 200.18 ns | 73.666 ns | 4.038 ns | 197.61 ns | 204.83 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.79 ns |  3.988 ns | 0.219 ns |  62.66 ns |  63.05 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.39 ns | 17.693 ns | 0.970 ns |  36.62 ns |  38.48 ns | 0.0011 |      96 B |
