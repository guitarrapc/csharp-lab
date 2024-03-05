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
| **ToBinaryArrayInt**             | **1**      |  **18.97 ns** |  **5.658 ns** | **0.310 ns** |  **18.62 ns** |  **19.18 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.16 ns |  1.838 ns | 0.101 ns |  67.10 ns |  67.28 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.75 ns |  7.459 ns | 0.409 ns |  20.50 ns |  21.22 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.17 ns |  2.053 ns | 0.113 ns |  11.06 ns |  11.29 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **87.55 ns** |  **3.204 ns** | **0.176 ns** |  **87.40 ns** |  **87.74 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 198.58 ns | 11.186 ns | 0.613 ns | 197.88 ns | 199.03 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.70 ns | 14.456 ns | 0.792 ns |  64.17 ns |  65.61 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.51 ns |  1.433 ns | 0.079 ns |  36.46 ns |  36.60 ns | 0.0011 |      96 B |
