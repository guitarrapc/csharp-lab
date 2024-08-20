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
| **ToBinaryArrayInt**             | **1**      |  **18.41 ns** |  **4.666 ns** | **0.256 ns** |  **18.22 ns** |  **18.70 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.89 ns | 31.391 ns | 1.721 ns |  65.91 ns |  69.05 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.47 ns |  2.111 ns | 0.116 ns |  20.37 ns |  20.59 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.02 ns |  2.859 ns | 0.157 ns |  10.88 ns |  11.19 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.43 ns** | **19.497 ns** | **1.069 ns** |  **53.21 ns** |  **55.16 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.37 ns | 10.759 ns | 0.590 ns | 201.02 ns | 202.05 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.01 ns |  2.469 ns | 0.135 ns |  60.85 ns |  61.11 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.60 ns |  1.554 ns | 0.085 ns |  35.54 ns |  35.69 ns | 0.0011 |      96 B |
