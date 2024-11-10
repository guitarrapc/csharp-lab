```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.45 ns** | **1.883 ns** | **0.103 ns** |  **18.38 ns** |  **18.57 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.27 ns | 2.069 ns | 0.113 ns |  64.18 ns |  64.40 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.43 ns | 3.197 ns | 0.175 ns |  20.24 ns |  20.57 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.94 ns | 1.358 ns | 0.074 ns |  10.88 ns |  11.03 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.00 ns** | **6.134 ns** | **0.336 ns** |  **54.70 ns** |  **55.36 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.66 ns | 7.985 ns | 0.438 ns | 202.23 ns | 203.10 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.72 ns | 5.682 ns | 0.311 ns |  61.52 ns |  62.08 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.61 ns | 3.177 ns | 0.174 ns |  35.49 ns |  35.81 ns | 0.0011 |      96 B |
