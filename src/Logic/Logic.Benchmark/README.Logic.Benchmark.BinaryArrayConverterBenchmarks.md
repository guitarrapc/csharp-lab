```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.54 ns** |  **1.552 ns** | **0.085 ns** |  **17.48 ns** |  **17.64 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.01 ns |  2.786 ns | 0.153 ns |  64.91 ns |  65.18 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.39 ns |  4.431 ns | 0.243 ns |  20.18 ns |  20.65 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.10 ns |  1.953 ns | 0.107 ns |  11.00 ns |  11.21 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **53.69 ns** |  **5.964 ns** | **0.327 ns** |  **53.44 ns** |  **54.06 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.32 ns | 17.519 ns | 0.960 ns | 200.32 ns | 202.24 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.05 ns | 37.664 ns | 2.064 ns |  59.00 ns |  63.13 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.23 ns |  9.683 ns | 0.531 ns |  35.73 ns |  36.79 ns | 0.0011 |      96 B |
