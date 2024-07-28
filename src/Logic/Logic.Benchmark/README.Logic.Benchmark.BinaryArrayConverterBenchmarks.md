```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.69 ns** |  **6.095 ns** | **0.334 ns** |  **18.33 ns** |  **18.99 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.37 ns |  1.392 ns | 0.076 ns |  66.29 ns |  66.43 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.88 ns |  3.514 ns | 0.193 ns |  20.72 ns |  21.09 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.05 ns |  0.747 ns | 0.041 ns |  11.02 ns |  11.09 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.63 ns** | **15.029 ns** | **0.824 ns** |  **54.76 ns** |  **56.40 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 198.73 ns |  0.887 ns | 0.049 ns | 198.68 ns | 198.76 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  67.28 ns | 14.942 ns | 0.819 ns |  66.39 ns |  68.00 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.35 ns |  4.893 ns | 0.268 ns |  36.08 ns |  36.61 ns | 0.0011 |      96 B |
