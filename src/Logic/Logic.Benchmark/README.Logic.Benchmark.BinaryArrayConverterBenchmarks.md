```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **16.94 ns** |  **3.733 ns** | **0.205 ns** |  **16.82 ns** |  **17.18 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.70 ns |  2.053 ns | 0.113 ns |  68.59 ns |  68.81 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.34 ns |  4.746 ns | 0.260 ns |  20.07 ns |  20.59 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.68 ns |  0.529 ns | 0.029 ns |  10.65 ns |  10.71 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.12 ns** | **10.450 ns** | **0.573 ns** |  **54.59 ns** |  **55.73 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.01 ns |  8.366 ns | 0.459 ns | 200.54 ns | 201.45 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.35 ns | 16.531 ns | 0.906 ns |  63.31 ns |  64.97 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.40 ns |  0.678 ns | 0.037 ns |  35.37 ns |  35.44 ns | 0.0011 |      96 B |
