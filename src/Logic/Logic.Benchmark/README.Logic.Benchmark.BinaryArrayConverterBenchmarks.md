```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.64 ns** |  **4.569 ns** | **0.250 ns** |  **18.40 ns** |  **18.90 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.34 ns | 47.011 ns | 2.577 ns |  64.74 ns |  69.31 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.26 ns |  1.034 ns | 0.057 ns |  20.20 ns |  20.31 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.79 ns |  0.504 ns | 0.028 ns |  10.77 ns |  10.83 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.34 ns** | **10.274 ns** | **0.563 ns** |  **55.70 ns** |  **56.75 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.29 ns | 66.526 ns | 3.647 ns | 200.06 ns | 206.49 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.69 ns |  9.766 ns | 0.535 ns |  62.11 ns |  63.16 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.93 ns | 11.295 ns | 0.619 ns |  35.50 ns |  36.64 ns | 0.0011 |      96 B |
