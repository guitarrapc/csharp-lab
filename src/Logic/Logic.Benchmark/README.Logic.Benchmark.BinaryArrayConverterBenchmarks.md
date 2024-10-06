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
| **ToBinaryArrayInt**             | **1**      |  **18.57 ns** |  **2.683 ns** | **0.147 ns** |  **18.45 ns** |  **18.73 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.03 ns | 22.148 ns | 1.214 ns |  65.67 ns |  68.01 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.12 ns |  3.424 ns | 0.188 ns |  20.94 ns |  21.31 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.95 ns |  1.686 ns | 0.092 ns |  10.88 ns |  11.06 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **59.49 ns** | **11.726 ns** | **0.643 ns** |  **58.75 ns** |  **59.88 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.67 ns |  5.168 ns | 0.283 ns | 201.35 ns | 201.91 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.14 ns |  4.626 ns | 0.254 ns |  61.85 ns |  62.30 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.47 ns | 12.454 ns | 0.683 ns |  35.73 ns |  37.08 ns | 0.0011 |      96 B |
