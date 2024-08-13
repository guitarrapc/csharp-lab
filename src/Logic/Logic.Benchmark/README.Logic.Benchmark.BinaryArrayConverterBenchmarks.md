```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.48 ns** |  **0.781 ns** | **0.043 ns** |  **17.43 ns** |  **17.50 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.28 ns |  2.890 ns | 0.158 ns |  65.13 ns |  65.44 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.04 ns |  6.427 ns | 0.352 ns |  19.71 ns |  20.41 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.96 ns |  1.312 ns | 0.072 ns |  10.90 ns |  11.04 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.47 ns** | **20.567 ns** | **1.127 ns** |  **57.36 ns** |  **59.61 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 198.97 ns |  6.853 ns | 0.376 ns | 198.59 ns | 199.34 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.83 ns | 18.321 ns | 1.004 ns |  59.73 ns |  61.70 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.68 ns |  4.214 ns | 0.231 ns |  34.51 ns |  34.94 ns | 0.0011 |      96 B |
