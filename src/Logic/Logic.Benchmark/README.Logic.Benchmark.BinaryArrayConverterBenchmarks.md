```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.43 ns** |  **1.818 ns** | **0.100 ns** |  **17.35 ns** |  **17.54 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.39 ns |  2.369 ns | 0.130 ns |  69.25 ns |  69.51 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.38 ns |  0.800 ns | 0.044 ns |  20.33 ns |  20.40 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.86 ns |  2.332 ns | 0.128 ns |  10.78 ns |  11.01 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.22 ns** |  **3.470 ns** | **0.190 ns** |  **55.10 ns** |  **55.44 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 213.09 ns |  5.251 ns | 0.288 ns | 212.89 ns | 213.42 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.34 ns | 15.923 ns | 0.873 ns |  59.33 ns |  60.87 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.53 ns |  0.676 ns | 0.037 ns |  35.51 ns |  35.57 ns | 0.0011 |      96 B |
