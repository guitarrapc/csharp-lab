```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.61 ns** |  **4.637 ns** | **0.254 ns** |  **18.34 ns** |  **18.85 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.93 ns |  2.706 ns | 0.148 ns |  65.80 ns |  66.09 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.72 ns |  1.290 ns | 0.071 ns |  20.65 ns |  20.79 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.16 ns |  4.322 ns | 0.237 ns |  10.99 ns |  11.43 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.84 ns** | **23.423 ns** | **1.284 ns** |  **57.80 ns** |  **60.28 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 198.89 ns | 11.060 ns | 0.606 ns | 198.36 ns | 199.55 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  66.21 ns | 10.491 ns | 0.575 ns |  65.85 ns |  66.87 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.86 ns |  6.964 ns | 0.382 ns |  36.55 ns |  37.29 ns | 0.0011 |      96 B |
