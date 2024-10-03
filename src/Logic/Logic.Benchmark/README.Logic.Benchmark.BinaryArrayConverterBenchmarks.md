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
| **ToBinaryArrayInt**             | **1**      |  **18.59 ns** |  **6.428 ns** | **0.352 ns** |  **18.24 ns** |  **18.95 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.56 ns | 40.372 ns | 2.213 ns |  64.61 ns |  68.97 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.01 ns |  6.340 ns | 0.348 ns |  20.63 ns |  21.31 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.03 ns |  1.916 ns | 0.105 ns |  10.94 ns |  11.15 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.27 ns** | **17.406 ns** | **0.954 ns** |  **56.22 ns** |  **58.07 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.56 ns |  3.508 ns | 0.192 ns | 206.34 ns | 206.69 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.80 ns | 34.859 ns | 1.911 ns |  61.59 ns |  64.91 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.40 ns |  1.315 ns | 0.072 ns |  36.35 ns |  36.48 ns | 0.0011 |      96 B |
