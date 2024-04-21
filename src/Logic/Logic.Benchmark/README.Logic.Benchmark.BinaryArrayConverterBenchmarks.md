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
| **ToBinaryArrayInt**             | **1**      |  **18.54 ns** | **10.596 ns** | **0.581 ns** |  **17.87 ns** |  **18.90 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.94 ns |  9.331 ns | 0.511 ns |  67.47 ns |  68.48 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.98 ns |  2.984 ns | 0.164 ns |  20.86 ns |  21.17 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.04 ns |  0.737 ns | 0.040 ns |  11.00 ns |  11.09 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.39 ns** |  **7.906 ns** | **0.433 ns** |  **54.91 ns** |  **55.76 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 203.98 ns |  5.363 ns | 0.294 ns | 203.66 ns | 204.24 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  65.12 ns | 20.119 ns | 1.103 ns |  63.84 ns |  65.79 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.02 ns |  5.277 ns | 0.289 ns |  36.76 ns |  37.33 ns | 0.0011 |      96 B |
