```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.23 ns** |  **6.866 ns** | **0.376 ns** |  **17.91 ns** |  **18.65 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.50 ns | 21.480 ns | 1.177 ns |  66.16 ns |  68.36 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.03 ns |  7.378 ns | 0.404 ns |  20.60 ns |  21.41 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.90 ns |  1.344 ns | 0.074 ns |  10.86 ns |  10.99 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.40 ns** | **22.073 ns** | **1.210 ns** |  **56.44 ns** |  **58.76 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 198.91 ns | 10.826 ns | 0.593 ns | 198.26 ns | 199.42 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  65.84 ns | 12.693 ns | 0.696 ns |  65.36 ns |  66.64 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.07 ns |  1.649 ns | 0.090 ns |  36.97 ns |  37.13 ns | 0.0011 |      96 B |
