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
| **ToBinaryArrayInt**             | **1**      |  **17.90 ns** |  **7.648 ns** | **0.419 ns** |  **17.42 ns** |  **18.18 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  63.95 ns |  5.182 ns | 0.284 ns |  63.67 ns |  64.23 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.02 ns |  1.924 ns | 0.105 ns |  19.94 ns |  20.14 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.76 ns |  0.386 ns | 0.021 ns |  10.74 ns |  10.78 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **53.94 ns** |  **2.940 ns** | **0.161 ns** |  **53.76 ns** |  **54.07 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.63 ns | 23.940 ns | 1.312 ns | 201.67 ns | 204.12 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.70 ns | 10.352 ns | 0.567 ns |  64.23 ns |  65.33 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.35 ns |  7.261 ns | 0.398 ns |  35.00 ns |  35.78 ns | 0.0011 |      96 B |
