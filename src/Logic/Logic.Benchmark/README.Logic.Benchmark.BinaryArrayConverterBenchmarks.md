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
| **ToBinaryArrayInt**             | **1**      |  **18.91 ns** |  **1.943 ns** | **0.107 ns** |  **18.79 ns** |  **18.99 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.94 ns | 15.622 ns | 0.856 ns |  66.32 ns |  67.92 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.29 ns |  3.198 ns | 0.175 ns |  21.15 ns |  21.49 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.56 ns |  2.418 ns | 0.133 ns |  11.45 ns |  11.71 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.61 ns** |  **8.778 ns** | **0.481 ns** |  **55.27 ns** |  **56.16 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.93 ns | 70.371 ns | 3.857 ns | 204.44 ns | 211.38 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.03 ns | 29.339 ns | 1.608 ns |  60.17 ns |  63.03 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.58 ns |  5.714 ns | 0.313 ns |  35.23 ns |  35.84 ns | 0.0011 |      96 B |
