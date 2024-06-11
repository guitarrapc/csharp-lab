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
| **ToBinaryArrayInt**             | **1**      |  **18.66 ns** |  **4.000 ns** | **0.219 ns** |  **18.41 ns** |  **18.80 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.03 ns |  1.963 ns | 0.108 ns |  64.92 ns |  65.13 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.27 ns |  0.788 ns | 0.043 ns |  20.22 ns |  20.29 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.82 ns |  4.262 ns | 0.234 ns |  10.66 ns |  11.09 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.83 ns** | **16.853 ns** | **0.924 ns** |  **54.95 ns** |  **56.79 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 196.95 ns | 10.162 ns | 0.557 ns | 196.56 ns | 197.58 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  65.49 ns | 39.237 ns | 2.151 ns |  63.18 ns |  67.44 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.36 ns |  4.701 ns | 0.258 ns |  37.21 ns |  37.66 ns | 0.0011 |      96 B |
