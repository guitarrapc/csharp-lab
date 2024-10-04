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
| **ToBinaryArrayInt**             | **1**      |  **19.00 ns** |  **1.372 ns** | **0.075 ns** |  **18.91 ns** |  **19.04 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.30 ns | 18.584 ns | 1.019 ns |  64.39 ns |  66.40 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.50 ns |  2.345 ns | 0.129 ns |  21.40 ns |  21.64 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.87 ns |  1.732 ns | 0.095 ns |  10.79 ns |  10.97 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.35 ns** | **13.635 ns** | **0.747 ns** |  **56.54 ns** |  **58.02 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.82 ns |  3.552 ns | 0.195 ns | 201.71 ns | 202.05 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.52 ns | 12.685 ns | 0.695 ns |  61.88 ns |  63.26 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.06 ns |  5.606 ns | 0.307 ns |  35.81 ns |  36.41 ns | 0.0011 |      96 B |
