```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.82 ns** |  **1.513 ns** | **0.083 ns** |  **18.77 ns** |  **18.91 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.08 ns |  4.663 ns | 0.256 ns |  67.82 ns |  68.33 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  22.10 ns | 10.383 ns | 0.569 ns |  21.45 ns |  22.52 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.27 ns |  2.598 ns | 0.142 ns |  11.17 ns |  11.43 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.95 ns** |  **3.497 ns** | **0.192 ns** |  **54.80 ns** |  **55.17 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 208.07 ns | 14.692 ns | 0.805 ns | 207.16 ns | 208.70 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  66.11 ns |  9.997 ns | 0.548 ns |  65.67 ns |  66.72 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.78 ns |  5.345 ns | 0.293 ns |  36.44 ns |  36.95 ns | 0.0011 |      96 B |
