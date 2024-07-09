```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **20.30 ns** |  **6.704 ns** | **0.367 ns** |  **20.01 ns** |  **20.71 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.26 ns |  3.536 ns | 0.194 ns |  65.14 ns |  65.48 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.03 ns | 10.324 ns | 0.566 ns |  20.51 ns |  21.63 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.03 ns |  0.578 ns | 0.032 ns |  10.99 ns |  11.05 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.14 ns** |  **9.947 ns** | **0.545 ns** |  **55.57 ns** |  **56.66 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 199.20 ns | 14.093 ns | 0.772 ns | 198.75 ns | 200.09 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.47 ns | 17.144 ns | 0.940 ns |  61.90 ns |  63.55 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.54 ns |  4.583 ns | 0.251 ns |  36.25 ns |  36.71 ns | 0.0011 |      96 B |
