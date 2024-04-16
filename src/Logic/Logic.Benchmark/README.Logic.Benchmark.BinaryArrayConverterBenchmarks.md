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
| **ToBinaryArrayInt**             | **1**      |  **18.58 ns** |  **3.502 ns** | **0.192 ns** |  **18.38 ns** |  **18.76 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  71.76 ns | 39.670 ns | 2.174 ns |  69.44 ns |  73.75 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.16 ns |  5.489 ns | 0.301 ns |  20.84 ns |  21.43 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.20 ns |  0.526 ns | 0.029 ns |  11.17 ns |  11.23 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.99 ns** | **16.808 ns** | **0.921 ns** |  **53.97 ns** |  **55.76 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 209.69 ns |  6.063 ns | 0.332 ns | 209.40 ns | 210.05 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.28 ns | 12.423 ns | 0.681 ns |  63.57 ns |  64.93 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  38.65 ns |  5.267 ns | 0.289 ns |  38.32 ns |  38.86 ns | 0.0011 |      96 B |
