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
| **ToBinaryArrayInt**             | **1**      |  **17.54 ns** |  **6.907 ns** | **0.379 ns** |  **17.11 ns** |  **17.83 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.73 ns |  3.675 ns | 0.201 ns |  67.58 ns |  67.96 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  18.82 ns |  6.769 ns | 0.371 ns |  18.59 ns |  19.25 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.10 ns |  5.493 ns | 0.301 ns |  10.89 ns |  11.45 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **50.27 ns** |  **6.585 ns** | **0.361 ns** |  **49.88 ns** |  **50.59 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.20 ns | 13.622 ns | 0.747 ns | 205.73 ns | 207.06 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  59.58 ns | 30.089 ns | 1.649 ns |  58.40 ns |  61.47 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.94 ns | 10.654 ns | 0.584 ns |  34.53 ns |  35.61 ns | 0.0057 |      96 B |
