```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.21 ns** |  **0.931 ns** | **0.051 ns** |  **17.15 ns** |  **17.24 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.77 ns |  3.201 ns | 0.175 ns |  69.65 ns |  69.97 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.66 ns |  4.735 ns | 0.260 ns |  20.45 ns |  20.95 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.47 ns |  9.929 ns | 0.544 ns |  11.15 ns |  12.10 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.21 ns** | **21.449 ns** | **1.176 ns** |  **52.92 ns** |  **55.22 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 203.11 ns |  4.058 ns | 0.222 ns | 202.95 ns | 203.36 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.73 ns |  7.568 ns | 0.415 ns |  63.39 ns |  64.19 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.32 ns |  2.333 ns | 0.128 ns |  37.19 ns |  37.44 ns | 0.0011 |      96 B |
