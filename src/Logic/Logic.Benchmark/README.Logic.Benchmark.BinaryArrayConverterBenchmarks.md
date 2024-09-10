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
| **ToBinaryArrayInt**             | **1**      |  **17.42 ns** |  **4.021 ns** | **0.220 ns** |  **17.20 ns** |  **17.64 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.53 ns | 23.760 ns | 1.302 ns |  66.77 ns |  69.03 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.53 ns |  4.883 ns | 0.268 ns |  20.28 ns |  20.81 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.85 ns |  0.650 ns | 0.036 ns |  10.83 ns |  10.89 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.43 ns** |  **6.182 ns** | **0.339 ns** |  **57.20 ns** |  **57.82 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 205.78 ns |  2.777 ns | 0.152 ns | 205.64 ns | 205.95 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.25 ns |  4.950 ns | 0.271 ns |  63.96 ns |  64.49 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.24 ns |  6.827 ns | 0.374 ns |  34.92 ns |  35.65 ns | 0.0011 |      96 B |
