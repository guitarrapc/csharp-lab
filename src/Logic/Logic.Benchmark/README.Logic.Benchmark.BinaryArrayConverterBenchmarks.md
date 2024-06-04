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
| **ToBinaryArrayInt**             | **1**      |  **18.71 ns** |  **0.527 ns** | **0.029 ns** |  **18.68 ns** |  **18.74 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.59 ns |  7.035 ns | 0.386 ns |  67.15 ns |  67.87 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.56 ns |  3.222 ns | 0.177 ns |  20.41 ns |  20.76 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.83 ns |  0.577 ns | 0.032 ns |  10.81 ns |  10.87 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.32 ns** |  **1.413 ns** | **0.077 ns** |  **56.25 ns** |  **56.40 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 197.78 ns | 54.680 ns | 2.997 ns | 195.89 ns | 201.24 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.55 ns |  7.511 ns | 0.412 ns |  64.08 ns |  64.87 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.53 ns |  8.716 ns | 0.478 ns |  37.18 ns |  38.08 ns | 0.0011 |      96 B |
