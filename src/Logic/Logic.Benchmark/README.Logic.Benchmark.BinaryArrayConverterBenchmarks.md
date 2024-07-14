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
| **ToBinaryArrayInt**             | **1**      |  **18.00 ns** |  **4.015 ns** | **0.220 ns** |  **17.76 ns** |  **18.20 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.38 ns |  0.717 ns | 0.039 ns |  65.36 ns |  65.43 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.87 ns |  5.648 ns | 0.310 ns |  20.64 ns |  21.22 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.88 ns |  1.822 ns | 0.100 ns |  10.78 ns |  10.98 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.18 ns** | **59.981 ns** | **3.288 ns** |  **52.48 ns** |  **58.84 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 199.84 ns |  3.765 ns | 0.206 ns | 199.71 ns | 200.07 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.95 ns |  4.650 ns | 0.255 ns |  63.77 ns |  64.24 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.13 ns |  2.917 ns | 0.160 ns |  36.01 ns |  36.31 ns | 0.0011 |      96 B |
