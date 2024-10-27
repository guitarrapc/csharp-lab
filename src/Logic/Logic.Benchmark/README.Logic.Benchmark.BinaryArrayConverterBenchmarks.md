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
| **ToBinaryArrayInt**             | **1**      |  **18.53 ns** |  **5.950 ns** | **0.326 ns** |  **18.34 ns** |  **18.91 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.20 ns | 30.645 ns | 1.680 ns |  67.16 ns |  70.14 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.79 ns |  4.842 ns | 0.265 ns |  20.61 ns |  21.09 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.01 ns |  1.473 ns | 0.081 ns |  10.96 ns |  11.11 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.57 ns** | **11.676 ns** | **0.640 ns** |  **53.83 ns** |  **54.95 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.26 ns | 31.041 ns | 1.701 ns | 200.30 ns | 203.41 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.33 ns | 30.522 ns | 1.673 ns |  62.32 ns |  65.26 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.96 ns |  2.503 ns | 0.137 ns |  36.82 ns |  37.09 ns | 0.0011 |      96 B |
