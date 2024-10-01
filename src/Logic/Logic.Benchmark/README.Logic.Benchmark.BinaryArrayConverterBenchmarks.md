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
| **ToBinaryArrayInt**             | **1**      |  **18.10 ns** |  **3.786 ns** | **0.208 ns** |  **17.90 ns** |  **18.31 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.05 ns |  1.088 ns | 0.060 ns |  64.98 ns |  65.09 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.09 ns |  3.983 ns | 0.218 ns |  20.86 ns |  21.29 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.01 ns |  0.173 ns | 0.009 ns |  11.00 ns |  11.02 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **60.55 ns** |  **2.892 ns** | **0.159 ns** |  **60.38 ns** |  **60.70 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.16 ns | 14.287 ns | 0.783 ns | 201.27 ns | 202.70 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.93 ns | 32.809 ns | 1.798 ns |  63.53 ns |  66.96 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.90 ns |  3.119 ns | 0.171 ns |  36.71 ns |  37.01 ns | 0.0011 |      96 B |
