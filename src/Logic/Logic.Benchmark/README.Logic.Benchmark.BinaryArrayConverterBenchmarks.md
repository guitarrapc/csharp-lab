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
| **ToBinaryArrayInt**             | **1**      |  **17.82 ns** |  **5.229 ns** | **0.287 ns** |  **17.49 ns** |  **17.99 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.84 ns |  5.220 ns | 0.286 ns |  65.55 ns |  66.13 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.95 ns |  3.277 ns | 0.180 ns |  19.85 ns |  20.16 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.34 ns |  4.491 ns | 0.246 ns |  11.19 ns |  11.62 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.03 ns** | **13.195 ns** | **0.723 ns** |  **56.40 ns** |  **57.82 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 199.50 ns |  5.872 ns | 0.322 ns | 199.26 ns | 199.87 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.29 ns |  9.432 ns | 0.517 ns |  62.70 ns |  63.64 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.88 ns |  6.783 ns | 0.372 ns |  34.46 ns |  35.11 ns | 0.0011 |      96 B |
