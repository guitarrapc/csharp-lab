```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **19.06 ns** |  **1.793 ns** | **0.098 ns** |  **19.00 ns** |  **19.17 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.33 ns |  1.127 ns | 0.062 ns |  65.26 ns |  65.37 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.23 ns |  9.165 ns | 0.502 ns |  20.88 ns |  21.81 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.04 ns |  0.428 ns | 0.023 ns |  11.02 ns |  11.06 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.36 ns** |  **8.098 ns** | **0.444 ns** |  **57.10 ns** |  **57.87 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 204.00 ns | 11.296 ns | 0.619 ns | 203.35 ns | 204.58 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  66.04 ns | 32.062 ns | 1.757 ns |  64.79 ns |  68.05 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.88 ns |  2.662 ns | 0.146 ns |  36.72 ns |  37.01 ns | 0.0011 |      96 B |
