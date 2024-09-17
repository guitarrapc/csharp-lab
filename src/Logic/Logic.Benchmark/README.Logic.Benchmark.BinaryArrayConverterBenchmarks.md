```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.43 ns** |  **4.754 ns** | **0.261 ns** |  **18.15 ns** |  **18.66 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.36 ns |  8.638 ns | 0.473 ns |  66.02 ns |  66.90 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.83 ns |  4.469 ns | 0.245 ns |  19.56 ns |  20.03 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.07 ns |  0.291 ns | 0.016 ns |  11.05 ns |  11.09 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.63 ns** | **27.182 ns** | **1.490 ns** |  **55.58 ns** |  **58.33 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 204.08 ns | 21.902 ns | 1.200 ns | 202.95 ns | 205.34 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.49 ns | 11.505 ns | 0.631 ns |  63.12 ns |  64.22 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.13 ns |  0.908 ns | 0.050 ns |  37.08 ns |  37.18 ns | 0.0011 |      96 B |
