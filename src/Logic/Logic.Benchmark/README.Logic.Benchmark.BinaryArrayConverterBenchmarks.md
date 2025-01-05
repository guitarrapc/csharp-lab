```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.44 ns** |  **4.294 ns** | **0.235 ns** |  **17.19 ns** |  **17.66 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  70.35 ns | 30.944 ns | 1.696 ns |  68.88 ns |  72.20 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.38 ns |  3.146 ns | 0.172 ns |  19.19 ns |  19.54 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.34 ns |  1.264 ns | 0.069 ns |  10.27 ns |  10.41 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.60 ns** |  **6.420 ns** | **0.352 ns** |  **54.20 ns** |  **54.88 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 203.91 ns | 17.701 ns | 0.970 ns | 203.21 ns | 205.02 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  59.86 ns | 16.818 ns | 0.922 ns |  59.23 ns |  60.92 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.26 ns |  8.526 ns | 0.467 ns |  33.94 ns |  34.79 ns | 0.0057 |      96 B |
