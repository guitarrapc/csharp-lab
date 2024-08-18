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
| **ToBinaryArrayInt**             | **1**      |  **18.38 ns** |  **4.397 ns** | **0.241 ns** |  **18.13 ns** |  **18.61 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.00 ns | 13.234 ns | 0.725 ns |  64.52 ns |  65.84 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.45 ns |  8.521 ns | 0.467 ns |  20.16 ns |  20.99 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.98 ns |  4.932 ns | 0.270 ns |  10.80 ns |  11.29 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.81 ns** | **18.671 ns** | **1.023 ns** |  **54.63 ns** |  **56.48 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 205.12 ns | 13.794 ns | 0.756 ns | 204.61 ns | 205.99 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.02 ns | 10.089 ns | 0.553 ns |  59.64 ns |  60.65 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.23 ns |  8.819 ns | 0.483 ns |  35.70 ns |  36.63 ns | 0.0011 |      96 B |
