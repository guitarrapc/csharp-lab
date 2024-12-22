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
| **ToBinaryArrayInt**             | **1**      |  **17.41 ns** |  **0.536 ns** | **0.029 ns** |  **17.39 ns** |  **17.44 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  72.55 ns |  1.673 ns | 0.092 ns |  72.44 ns |  72.61 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.47 ns |  1.609 ns | 0.088 ns |  20.39 ns |  20.56 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.80 ns |  0.768 ns | 0.042 ns |  10.76 ns |  10.84 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.01 ns** |  **4.568 ns** | **0.250 ns** |  **55.75 ns** |  **56.25 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 213.25 ns | 16.812 ns | 0.922 ns | 212.66 ns | 214.31 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.73 ns |  7.953 ns | 0.436 ns |  61.46 ns |  62.24 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.61 ns |  9.408 ns | 0.516 ns |  35.10 ns |  36.13 ns | 0.0011 |      96 B |
