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
| **ToBinaryArrayInt**             | **1**      |  **18.70 ns** |  **9.993 ns** | **0.548 ns** |  **18.16 ns** |  **19.26 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.41 ns |  0.704 ns | 0.039 ns |  68.37 ns |  68.44 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.34 ns |  1.351 ns | 0.074 ns |  21.29 ns |  21.43 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.22 ns |  3.624 ns | 0.199 ns |  11.04 ns |  11.43 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.34 ns** |  **5.951 ns** | **0.326 ns** |  **53.98 ns** |  **54.61 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.38 ns |  5.112 ns | 0.280 ns | 201.06 ns | 201.57 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  68.47 ns | 14.642 ns | 0.803 ns |  67.70 ns |  69.30 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  38.88 ns |  2.885 ns | 0.158 ns |  38.76 ns |  39.06 ns | 0.0011 |      96 B |
