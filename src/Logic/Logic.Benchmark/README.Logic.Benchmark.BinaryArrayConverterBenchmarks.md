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
| **ToBinaryArrayInt**             | **1**      |  **17.18 ns** |  **5.013 ns** | **0.275 ns** |  **16.97 ns** |  **17.49 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.21 ns |  2.031 ns | 0.111 ns |  66.13 ns |  66.33 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.57 ns |  5.223 ns | 0.286 ns |  20.24 ns |  20.76 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.38 ns |  0.176 ns | 0.010 ns |  11.37 ns |  11.39 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **52.68 ns** | **36.781 ns** | **2.016 ns** |  **51.16 ns** |  **54.96 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 211.00 ns | 50.330 ns | 2.759 ns | 207.96 ns | 213.33 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.89 ns | 18.444 ns | 1.011 ns |  59.73 ns |  61.61 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.70 ns |  0.952 ns | 0.052 ns |  35.64 ns |  35.74 ns | 0.0011 |      96 B |
