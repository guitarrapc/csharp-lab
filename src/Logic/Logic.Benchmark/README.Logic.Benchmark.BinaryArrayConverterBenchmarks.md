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
| **ToBinaryArrayInt**             | **1**      |  **17.15 ns** |  **3.278 ns** | **0.180 ns** |  **16.99 ns** |  **17.34 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.26 ns |  1.808 ns | 0.099 ns |  67.16 ns |  67.35 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.87 ns |  7.020 ns | 0.385 ns |  20.59 ns |  21.31 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.89 ns |  0.834 ns | 0.046 ns |  10.85 ns |  10.94 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **52.09 ns** |  **4.003 ns** | **0.219 ns** |  **51.86 ns** |  **52.30 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.62 ns | 10.978 ns | 0.602 ns | 201.25 ns | 202.31 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.82 ns | 13.987 ns | 0.767 ns |  63.96 ns |  65.41 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.75 ns |  2.727 ns | 0.149 ns |  35.59 ns |  35.88 ns | 0.0011 |      96 B |
