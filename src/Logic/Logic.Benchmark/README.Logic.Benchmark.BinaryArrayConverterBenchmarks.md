```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **19.26 ns** |  **9.409 ns** | **0.516 ns** |  **18.83 ns** |  **19.83 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.14 ns | 15.420 ns | 0.845 ns |  66.64 ns |  68.11 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.39 ns |  1.761 ns | 0.097 ns |  20.30 ns |  20.49 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.04 ns |  0.614 ns | 0.034 ns |  11.01 ns |  11.07 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.94 ns** | **14.867 ns** | **0.815 ns** |  **56.14 ns** |  **57.77 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.09 ns | 12.815 ns | 0.702 ns | 201.61 ns | 202.90 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.19 ns | 11.060 ns | 0.606 ns |  63.49 ns |  64.59 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.02 ns |  2.143 ns | 0.117 ns |  35.89 ns |  36.10 ns | 0.0011 |      96 B |
