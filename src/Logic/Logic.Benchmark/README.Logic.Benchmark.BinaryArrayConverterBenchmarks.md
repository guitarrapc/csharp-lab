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
| **ToBinaryArrayInt**             | **1**      |  **18.69 ns** |  **3.851 ns** | **0.211 ns** |  **18.54 ns** |  **18.93 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  83.93 ns |  2.681 ns | 0.147 ns |  83.81 ns |  84.09 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.96 ns |  7.083 ns | 0.388 ns |  20.59 ns |  21.36 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.12 ns |  3.848 ns | 0.211 ns |  10.97 ns |  11.36 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **59.95 ns** |  **9.429 ns** | **0.517 ns** |  **59.50 ns** |  **60.52 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.80 ns | 25.930 ns | 1.421 ns | 200.19 ns | 202.89 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.80 ns | 14.771 ns | 0.810 ns |  64.31 ns |  65.74 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.94 ns | 19.295 ns | 1.058 ns |  37.26 ns |  39.16 ns | 0.0011 |      96 B |
