```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.85 ns** |   **4.824 ns** | **0.264 ns** |  **18.56 ns** |  **19.08 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.24 ns |   1.746 ns | 0.096 ns |  65.13 ns |  65.30 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.38 ns |   1.311 ns | 0.072 ns |  20.32 ns |  20.46 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.02 ns |   4.744 ns | 0.260 ns |  10.84 ns |  11.32 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **53.80 ns** |   **7.016 ns** | **0.385 ns** |  **53.36 ns** |  **54.07 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 207.30 ns | 137.571 ns | 7.541 ns | 202.21 ns | 215.97 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.55 ns |  20.274 ns | 1.111 ns |  59.62 ns |  61.78 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.44 ns |   3.740 ns | 0.205 ns |  35.30 ns |  35.67 ns | 0.0011 |      96 B |
