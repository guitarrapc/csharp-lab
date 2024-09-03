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
| **ToBinaryArrayInt**             | **1**      |  **18.50 ns** |  **6.068 ns** | **0.333 ns** |  **18.13 ns** |  **18.77 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.60 ns |  3.379 ns | 0.185 ns |  64.39 ns |  64.73 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.77 ns |  4.173 ns | 0.229 ns |  20.54 ns |  21.00 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.79 ns |  0.541 ns | 0.030 ns |  10.76 ns |  10.82 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.67 ns** |  **1.677 ns** | **0.092 ns** |  **57.57 ns** |  **57.76 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.88 ns |  4.151 ns | 0.228 ns | 202.62 ns | 203.06 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.48 ns | 11.844 ns | 0.649 ns |  59.98 ns |  61.22 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.12 ns |  8.659 ns | 0.475 ns |  35.62 ns |  36.56 ns | 0.0011 |      96 B |
