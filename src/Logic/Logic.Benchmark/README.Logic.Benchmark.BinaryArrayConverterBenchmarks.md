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
| **ToBinaryArrayInt**             | **1**      |  **19.11 ns** |  **3.532 ns** | **0.194 ns** |  **18.98 ns** |  **19.33 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.84 ns |  4.938 ns | 0.271 ns |  64.56 ns |  65.10 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.86 ns |  1.728 ns | 0.095 ns |  20.80 ns |  20.97 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.26 ns |  4.532 ns | 0.248 ns |  11.08 ns |  11.54 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.98 ns** | **25.672 ns** | **1.407 ns** |  **53.37 ns** |  **56.00 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.03 ns | 12.997 ns | 0.712 ns | 201.21 ns | 202.47 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  66.90 ns | 34.805 ns | 1.908 ns |  65.65 ns |  69.09 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.26 ns |  3.377 ns | 0.185 ns |  37.08 ns |  37.45 ns | 0.0011 |      96 B |
