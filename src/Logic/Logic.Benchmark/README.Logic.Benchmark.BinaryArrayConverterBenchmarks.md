```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.92 ns** |  **6.458 ns** | **0.354 ns** |  **17.54 ns** |  **18.24 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.32 ns |  0.633 ns | 0.035 ns |  65.30 ns |  65.36 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.47 ns |  5.553 ns | 0.304 ns |  20.27 ns |  20.82 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.86 ns |  0.920 ns | 0.050 ns |  10.82 ns |  10.91 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.32 ns** | **12.831 ns** | **0.703 ns** |  **55.82 ns** |  **57.13 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 204.02 ns |  6.849 ns | 0.375 ns | 203.73 ns | 204.44 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.17 ns | 21.686 ns | 1.189 ns |  62.21 ns |  64.50 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.10 ns |  5.774 ns | 0.317 ns |  35.77 ns |  36.40 ns | 0.0011 |      96 B |
