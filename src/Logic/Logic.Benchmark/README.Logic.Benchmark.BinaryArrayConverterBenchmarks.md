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
| **ToBinaryArrayInt**             | **1**      |  **18.70 ns** |  **2.864 ns** | **0.157 ns** |  **18.55 ns** |  **18.86 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.95 ns |  3.000 ns | 0.164 ns |  69.76 ns |  70.05 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.65 ns |  3.209 ns | 0.176 ns |  20.45 ns |  20.77 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.18 ns |  0.778 ns | 0.043 ns |  11.13 ns |  11.20 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.34 ns** |  **1.980 ns** | **0.109 ns** |  **54.22 ns** |  **54.43 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.69 ns | 15.125 ns | 0.829 ns | 201.13 ns | 202.64 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.57 ns | 23.753 ns | 1.302 ns |  60.09 ns |  62.52 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.41 ns |  2.040 ns | 0.112 ns |  35.29 ns |  35.50 ns | 0.0011 |      96 B |
