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
| **ToBinaryArrayInt**             | **1**      |  **18.56 ns** |  **9.445 ns** | **0.518 ns** |  **18.04 ns** |  **19.08 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.04 ns | 12.031 ns | 0.659 ns |  66.48 ns |  67.77 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  23.51 ns | 12.781 ns | 0.701 ns |  22.74 ns |  24.11 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.76 ns |  1.366 ns | 0.075 ns |  10.69 ns |  10.84 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.78 ns** | **19.127 ns** | **1.048 ns** |  **56.62 ns** |  **58.65 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 197.01 ns |  4.477 ns | 0.245 ns | 196.76 ns | 197.25 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.84 ns |  5.947 ns | 0.326 ns |  63.62 ns |  64.21 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.12 ns |  5.716 ns | 0.313 ns |  36.77 ns |  37.39 ns | 0.0011 |      96 B |
