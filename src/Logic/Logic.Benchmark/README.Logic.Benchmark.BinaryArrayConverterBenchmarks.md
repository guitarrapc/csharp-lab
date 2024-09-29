```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **20.86 ns** |  **1.729 ns** | **0.095 ns** |  **20.75 ns** |  **20.92 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  74.21 ns |  9.760 ns | 0.535 ns |  73.76 ns |  74.80 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.13 ns |  3.190 ns | 0.175 ns |  21.02 ns |  21.33 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.74 ns |  2.276 ns | 0.125 ns |  10.64 ns |  10.88 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **61.70 ns** | **18.566 ns** | **1.018 ns** |  **60.53 ns** |  **62.31 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 199.21 ns | 32.925 ns | 1.805 ns | 197.94 ns | 201.27 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.91 ns |  6.354 ns | 0.348 ns |  61.52 ns |  62.19 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.48 ns |  5.065 ns | 0.278 ns |  34.16 ns |  34.66 ns | 0.0011 |      96 B |
