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
| **ToBinaryArrayInt**             | **1**      |  **17.89 ns** |  **5.505 ns** | **0.302 ns** |  **17.54 ns** |  **18.08 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.17 ns |  5.947 ns | 0.326 ns |  65.98 ns |  66.55 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.35 ns |  1.329 ns | 0.073 ns |  20.27 ns |  20.40 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.91 ns |  0.373 ns | 0.020 ns |  10.89 ns |  10.93 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.38 ns** | **21.963 ns** | **1.204 ns** |  **55.43 ns** |  **57.73 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 197.14 ns | 11.268 ns | 0.618 ns | 196.74 ns | 197.85 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.92 ns | 28.648 ns | 1.570 ns |  61.70 ns |  64.69 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.89 ns |  3.552 ns | 0.195 ns |  35.67 ns |  36.04 ns | 0.0011 |      96 B |
