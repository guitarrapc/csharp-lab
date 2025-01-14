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
| **ToBinaryArrayInt**             | **1**      |  **18.09 ns** |  **2.180 ns** | **0.120 ns** |  **18.00 ns** |  **18.23 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  72.52 ns | 11.215 ns | 0.615 ns |  71.84 ns |  73.03 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.24 ns |  4.247 ns | 0.233 ns |  20.10 ns |  20.51 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.78 ns |  1.885 ns | 0.103 ns |  10.71 ns |  10.89 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.67 ns** |  **4.908 ns** | **0.269 ns** |  **54.36 ns** |  **54.87 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 207.32 ns | 30.509 ns | 1.672 ns | 205.76 ns | 209.09 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.80 ns | 20.097 ns | 1.102 ns |  60.11 ns |  62.07 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.83 ns |  8.424 ns | 0.462 ns |  34.52 ns |  35.36 ns | 0.0057 |      96 B |
