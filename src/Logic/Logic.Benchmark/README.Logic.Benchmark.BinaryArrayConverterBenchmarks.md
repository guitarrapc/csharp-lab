```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.80 ns** |  **3.662 ns** | **0.201 ns** |  **18.62 ns** |  **19.01 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.92 ns |  4.994 ns | 0.274 ns |  67.68 ns |  68.22 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.44 ns |  1.588 ns | 0.087 ns |  20.36 ns |  20.53 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.77 ns |  1.294 ns | 0.071 ns |  10.69 ns |  10.83 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.98 ns** | **14.665 ns** | **0.804 ns** |  **56.16 ns** |  **57.76 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 197.83 ns | 18.684 ns | 1.024 ns | 196.78 ns | 198.82 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.09 ns | 20.580 ns | 1.128 ns |  63.40 ns |  65.39 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.34 ns |  5.760 ns | 0.316 ns |  36.05 ns |  36.68 ns | 0.0011 |      96 B |
