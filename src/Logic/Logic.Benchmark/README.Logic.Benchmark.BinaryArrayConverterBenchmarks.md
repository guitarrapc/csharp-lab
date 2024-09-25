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
| **ToBinaryArrayInt**             | **1**      |  **18.08 ns** |  **4.354 ns** | **0.239 ns** |  **17.88 ns** |  **18.35 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.54 ns | 41.651 ns | 2.283 ns |  64.97 ns |  69.16 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.00 ns |  0.965 ns | 0.053 ns |  20.96 ns |  21.06 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.00 ns |  0.985 ns | 0.054 ns |  10.96 ns |  11.06 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.28 ns** | **13.599 ns** | **0.745 ns** |  **53.69 ns** |  **55.11 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.65 ns | 14.453 ns | 0.792 ns | 200.75 ns | 202.25 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.18 ns |  9.569 ns | 0.524 ns |  62.78 ns |  63.78 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.37 ns |  7.211 ns | 0.395 ns |  36.07 ns |  36.82 ns | 0.0011 |      96 B |
