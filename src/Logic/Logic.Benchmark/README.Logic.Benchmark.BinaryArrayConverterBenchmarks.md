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
| **ToBinaryArrayInt**             | **1**      |  **18.26 ns** | **12.156 ns** | **0.666 ns** |  **17.82 ns** |  **19.02 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.97 ns |  1.508 ns | 0.083 ns |  68.90 ns |  69.06 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.07 ns |  4.516 ns | 0.248 ns |  19.85 ns |  20.34 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.97 ns |  2.351 ns | 0.129 ns |  10.86 ns |  11.11 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.00 ns** |  **2.698 ns** | **0.148 ns** |  **54.83 ns** |  **55.10 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 212.69 ns | 22.058 ns | 1.209 ns | 211.39 ns | 213.78 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.47 ns |  5.636 ns | 0.309 ns |  61.13 ns |  61.74 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.25 ns | 11.907 ns | 0.653 ns |  34.51 ns |  35.76 ns | 0.0057 |      96 B |
