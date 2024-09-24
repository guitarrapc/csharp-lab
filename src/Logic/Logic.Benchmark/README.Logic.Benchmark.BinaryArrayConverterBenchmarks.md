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
| **ToBinaryArrayInt**             | **1**      |  **19.27 ns** |  **5.033 ns** | **0.276 ns** |  **18.96 ns** |  **19.47 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.35 ns | 18.469 ns | 1.012 ns |  65.76 ns |  67.52 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.85 ns |  2.777 ns | 0.152 ns |  20.75 ns |  21.02 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.93 ns |  0.504 ns | 0.028 ns |  10.90 ns |  10.96 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **59.34 ns** | **14.568 ns** | **0.799 ns** |  **58.57 ns** |  **60.16 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.24 ns |  0.713 ns | 0.039 ns | 201.20 ns | 201.28 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.61 ns |  6.075 ns | 0.333 ns |  61.23 ns |  61.87 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.44 ns |  2.407 ns | 0.132 ns |  35.30 ns |  35.57 ns | 0.0011 |      96 B |
