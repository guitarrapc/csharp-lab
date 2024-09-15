```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.82 ns** |  **7.553 ns** | **0.414 ns** |  **18.51 ns** |  **19.29 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.21 ns |  1.106 ns | 0.061 ns |  66.14 ns |  66.25 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.52 ns |  1.467 ns | 0.080 ns |  19.47 ns |  19.61 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.86 ns |  0.853 ns | 0.047 ns |  10.81 ns |  10.90 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.20 ns** |  **6.646 ns** | **0.364 ns** |  **53.78 ns** |  **54.42 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 199.05 ns | 17.018 ns | 0.933 ns | 198.10 ns | 199.97 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.86 ns |  2.232 ns | 0.122 ns |  61.72 ns |  61.95 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.23 ns |  8.948 ns | 0.490 ns |  36.66 ns |  37.52 ns | 0.0011 |      96 B |
