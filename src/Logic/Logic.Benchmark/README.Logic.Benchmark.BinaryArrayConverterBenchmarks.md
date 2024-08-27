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
| **ToBinaryArrayInt**             | **1**      |  **18.52 ns** |  **3.575 ns** | **0.196 ns** |  **18.36 ns** |  **18.74 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.60 ns | 13.382 ns | 0.734 ns |  64.10 ns |  65.44 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.67 ns |  1.906 ns | 0.104 ns |  21.59 ns |  21.78 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.96 ns |  0.778 ns | 0.043 ns |  10.92 ns |  11.01 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.68 ns** | **36.566 ns** | **2.004 ns** |  **55.10 ns** |  **58.94 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.02 ns | 24.487 ns | 1.342 ns | 200.62 ns | 203.29 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.68 ns | 17.017 ns | 0.933 ns |  60.75 ns |  62.62 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.50 ns |  2.837 ns | 0.156 ns |  34.35 ns |  34.66 ns | 0.0011 |      96 B |
