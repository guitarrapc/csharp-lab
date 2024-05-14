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
| **ToBinaryArrayInt**             | **1**      |  **17.90 ns** |  **4.310 ns** | **0.236 ns** |  **17.71 ns** |  **18.17 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.89 ns |  3.723 ns | 0.204 ns |  67.72 ns |  68.12 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.87 ns |  8.584 ns | 0.471 ns |  21.40 ns |  22.34 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.17 ns |  0.028 ns | 0.002 ns |  11.17 ns |  11.18 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.19 ns** | **18.615 ns** | **1.020 ns** |  **55.04 ns** |  **57.01 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 204.30 ns |  9.092 ns | 0.498 ns | 203.93 ns | 204.87 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  66.12 ns |  5.952 ns | 0.326 ns |  65.88 ns |  66.49 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.78 ns |  3.441 ns | 0.189 ns |  36.63 ns |  36.99 ns | 0.0011 |      96 B |
