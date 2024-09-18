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
| **ToBinaryArrayInt**             | **1**      |  **18.42 ns** |  **2.250 ns** | **0.123 ns** |  **18.29 ns** |  **18.54 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.59 ns |  4.944 ns | 0.271 ns |  65.34 ns |  65.88 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.82 ns |  8.436 ns | 0.462 ns |  21.28 ns |  22.11 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.03 ns |  1.253 ns | 0.069 ns |  10.95 ns |  11.07 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.22 ns** |  **5.096 ns** | **0.279 ns** |  **56.91 ns** |  **57.45 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.38 ns | 30.692 ns | 1.682 ns | 205.01 ns | 208.26 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.06 ns |  6.013 ns | 0.330 ns |  60.69 ns |  61.32 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.32 ns |  7.425 ns | 0.407 ns |  35.85 ns |  36.61 ns | 0.0011 |      96 B |
