```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.43 ns** |  **1.375 ns** | **0.075 ns** |  **17.35 ns** |  **17.49 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  74.09 ns |  7.655 ns | 0.420 ns |  73.70 ns |  74.54 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.31 ns |  0.520 ns | 0.028 ns |  20.29 ns |  20.35 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.07 ns |  8.124 ns | 0.445 ns |  10.80 ns |  11.59 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.17 ns** | **15.796 ns** | **0.866 ns** |  **53.17 ns** |  **54.75 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.40 ns | 50.970 ns | 2.794 ns | 203.43 ns | 208.97 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.62 ns | 28.102 ns | 1.540 ns |  61.88 ns |  64.82 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.00 ns |  2.721 ns | 0.149 ns |  35.86 ns |  36.16 ns | 0.0011 |      96 B |
