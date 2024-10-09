```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.34 ns** |  **1.518 ns** | **0.083 ns** |  **18.27 ns** |  **18.43 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.01 ns | 82.094 ns | 4.500 ns |  66.11 ns |  74.20 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.42 ns |  3.344 ns | 0.183 ns |  20.30 ns |  20.63 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.10 ns |  0.662 ns | 0.036 ns |  11.07 ns |  11.14 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **53.80 ns** |  **5.991 ns** | **0.328 ns** |  **53.43 ns** |  **54.04 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 204.66 ns |  1.432 ns | 0.079 ns | 204.57 ns | 204.73 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.04 ns | 27.361 ns | 1.500 ns |  62.34 ns |  65.20 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.38 ns |  3.481 ns | 0.191 ns |  37.20 ns |  37.58 ns | 0.0011 |      96 B |
