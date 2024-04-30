```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.84 ns** |  **1.980 ns** | **0.109 ns** |  **17.74 ns** |  **17.96 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.43 ns |  2.902 ns | 0.159 ns |  66.28 ns |  66.60 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.41 ns | 10.899 ns | 0.597 ns |  20.86 ns |  22.05 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.01 ns |  1.046 ns | 0.057 ns |  10.94 ns |  11.05 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.47 ns** | **38.770 ns** | **2.125 ns** |  **52.02 ns** |  **55.71 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.25 ns |  9.998 ns | 0.548 ns | 201.81 ns | 202.86 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  65.48 ns | 23.342 ns | 1.279 ns |  64.23 ns |  66.79 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.24 ns |  7.563 ns | 0.415 ns |  36.90 ns |  37.70 ns | 0.0011 |      96 B |
