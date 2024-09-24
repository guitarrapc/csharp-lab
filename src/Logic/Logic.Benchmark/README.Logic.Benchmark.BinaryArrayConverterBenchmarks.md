```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.10 ns** |  **3.225 ns** | **0.177 ns** |  **17.90 ns** |  **18.21 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.79 ns | 21.132 ns | 1.158 ns |  65.60 ns |  67.91 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.22 ns |  9.191 ns | 0.504 ns |  20.68 ns |  21.68 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.99 ns |  4.699 ns | 0.258 ns |  10.84 ns |  11.28 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.60 ns** | **17.155 ns** | **0.940 ns** |  **56.64 ns** |  **58.52 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.82 ns |  2.023 ns | 0.111 ns | 201.70 ns | 201.91 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.67 ns | 14.308 ns | 0.784 ns |  60.84 ns |  62.40 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.82 ns |  8.829 ns | 0.484 ns |  35.27 ns |  36.19 ns | 0.0011 |      96 B |
