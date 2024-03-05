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
| **ToBinaryArrayInt**             | **1**      |  **18.64 ns** |  **1.338 ns** | **0.073 ns** |  **18.59 ns** |  **18.72 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.38 ns |  8.063 ns | 0.442 ns |  64.97 ns |  65.85 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.30 ns |  1.586 ns | 0.087 ns |  20.20 ns |  20.35 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.90 ns |  2.593 ns | 0.142 ns |  10.81 ns |  11.07 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.08 ns** | **28.176 ns** | **1.544 ns** |  **53.42 ns** |  **56.46 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 197.72 ns |  3.534 ns | 0.194 ns | 197.50 ns | 197.85 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.73 ns | 12.339 ns | 0.676 ns |  62.24 ns |  63.50 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.62 ns |  7.838 ns | 0.430 ns |  37.13 ns |  37.95 ns | 0.0011 |      96 B |
