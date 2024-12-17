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
| **ToBinaryArrayInt**             | **1**      |  **17.64 ns** |  **2.472 ns** | **0.135 ns** |  **17.55 ns** |  **17.80 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  73.16 ns | 12.679 ns | 0.695 ns |  72.75 ns |  73.96 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.52 ns |  3.904 ns | 0.214 ns |  20.31 ns |  20.74 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.88 ns |  1.488 ns | 0.082 ns |  10.81 ns |  10.97 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.14 ns** |  **5.711 ns** | **0.313 ns** |  **54.88 ns** |  **55.49 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 221.95 ns | 10.589 ns | 0.580 ns | 221.54 ns | 222.62 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.09 ns |  5.803 ns | 0.318 ns |  59.72 ns |  60.32 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.75 ns |  5.860 ns | 0.321 ns |  36.38 ns |  36.95 ns | 0.0011 |      96 B |
