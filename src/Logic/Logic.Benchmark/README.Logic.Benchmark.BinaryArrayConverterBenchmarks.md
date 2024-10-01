```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.39 ns** |  **2.635 ns** | **0.144 ns** |  **18.24 ns** |  **18.53 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.84 ns |  6.862 ns | 0.376 ns |  64.44 ns |  65.19 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.11 ns |  4.195 ns | 0.230 ns |  20.96 ns |  21.37 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.04 ns |  1.721 ns | 0.094 ns |  10.95 ns |  11.14 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **60.44 ns** | **44.810 ns** | **2.456 ns** |  **58.41 ns** |  **63.17 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.10 ns | 26.773 ns | 1.467 ns | 199.71 ns | 202.64 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  65.52 ns | 29.697 ns | 1.628 ns |  63.99 ns |  67.23 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.01 ns |  7.212 ns | 0.395 ns |  36.60 ns |  37.38 ns | 0.0011 |      96 B |
