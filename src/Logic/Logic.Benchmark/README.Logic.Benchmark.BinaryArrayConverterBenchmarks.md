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
| **ToBinaryArrayInt**             | **1**      |  **18.25 ns** |  **6.700 ns** | **0.367 ns** |  **17.93 ns** |  **18.65 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.78 ns |  4.546 ns | 0.249 ns |  65.56 ns |  66.05 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.18 ns | 10.422 ns | 0.571 ns |  19.81 ns |  20.83 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.05 ns |  0.454 ns | 0.025 ns |  11.03 ns |  11.07 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.49 ns** | **12.904 ns** | **0.707 ns** |  **56.72 ns** |  **58.11 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.38 ns | 11.102 ns | 0.609 ns | 205.75 ns | 206.97 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.15 ns |  4.766 ns | 0.261 ns |  60.85 ns |  61.34 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.75 ns |  5.817 ns | 0.319 ns |  35.40 ns |  36.01 ns | 0.0011 |      96 B |
