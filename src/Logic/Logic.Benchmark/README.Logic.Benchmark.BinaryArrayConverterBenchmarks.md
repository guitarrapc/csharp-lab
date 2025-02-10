```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.04 ns** |  **8.117 ns** | **0.445 ns** |  **17.65 ns** |  **18.52 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  72.07 ns | 38.099 ns | 2.088 ns |  70.13 ns |  74.28 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.50 ns |  4.256 ns | 0.233 ns |  20.26 ns |  20.72 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.32 ns |  2.585 ns | 0.142 ns |  11.17 ns |  11.44 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.28 ns** |  **2.006 ns** | **0.110 ns** |  **57.21 ns** |  **57.41 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 214.37 ns | 14.766 ns | 0.809 ns | 213.52 ns | 215.12 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.92 ns |  1.565 ns | 0.086 ns |  61.85 ns |  62.02 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.73 ns |  4.452 ns | 0.244 ns |  36.45 ns |  36.88 ns | 0.0057 |      96 B |
