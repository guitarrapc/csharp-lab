```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.88 ns** |  **0.741 ns** | **0.041 ns** |  **18.85 ns** |  **18.93 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.59 ns |  7.640 ns | 0.419 ns |  65.11 ns |  65.86 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.86 ns |  2.519 ns | 0.138 ns |  20.71 ns |  20.98 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.19 ns |  1.071 ns | 0.059 ns |  11.14 ns |  11.25 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **52.98 ns** |  **6.221 ns** | **0.341 ns** |  **52.76 ns** |  **53.38 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.19 ns | 20.585 ns | 1.128 ns | 204.97 ns | 207.21 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  68.41 ns | 12.552 ns | 0.688 ns |  67.81 ns |  69.16 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  38.66 ns |  4.247 ns | 0.233 ns |  38.51 ns |  38.92 ns | 0.0011 |      96 B |
