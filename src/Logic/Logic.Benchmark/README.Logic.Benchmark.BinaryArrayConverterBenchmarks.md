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
| **ToBinaryArrayInt**             | **1**      |  **16.88 ns** |  **4.752 ns** | **0.260 ns** |  **16.71 ns** |  **17.18 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  62.16 ns | 16.729 ns | 0.917 ns |  61.48 ns |  63.21 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.78 ns | 21.412 ns | 1.174 ns |  19.58 ns |  21.92 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.31 ns |  1.114 ns | 0.061 ns |  10.27 ns |  10.38 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **52.24 ns** | **44.417 ns** | **2.435 ns** |  **50.22 ns** |  **54.94 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 196.27 ns | 26.283 ns | 1.441 ns | 195.26 ns | 197.92 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.98 ns | 20.968 ns | 1.149 ns |  63.76 ns |  66.05 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  33.96 ns |  5.545 ns | 0.304 ns |  33.72 ns |  34.31 ns | 0.0011 |      96 B |
