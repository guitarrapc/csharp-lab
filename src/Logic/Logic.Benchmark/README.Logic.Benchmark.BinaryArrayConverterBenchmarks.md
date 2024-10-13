```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.92 ns** | **14.202 ns** | **0.778 ns** |  **18.38 ns** |  **19.81 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.69 ns |  3.383 ns | 0.185 ns |  65.49 ns |  65.86 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.07 ns |  8.088 ns | 0.443 ns |  20.80 ns |  21.58 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.86 ns |  0.561 ns | 0.031 ns |  10.84 ns |  10.90 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.54 ns** |  **4.785 ns** | **0.262 ns** |  **55.37 ns** |  **55.84 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.09 ns | 16.128 ns | 0.884 ns | 205.15 ns | 206.90 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.18 ns |  4.877 ns | 0.267 ns |  62.94 ns |  63.47 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.44 ns |  2.502 ns | 0.137 ns |  35.35 ns |  35.59 ns | 0.0011 |      96 B |
