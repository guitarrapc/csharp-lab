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
| **ToBinaryArrayInt**             | **1**      |  **17.67 ns** |  **2.632 ns** | **0.144 ns** |  **17.53 ns** |  **17.81 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  70.93 ns |  2.873 ns | 0.157 ns |  70.76 ns |  71.08 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.68 ns |  5.721 ns | 0.314 ns |  19.33 ns |  19.94 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.48 ns |  2.022 ns | 0.111 ns |  10.35 ns |  10.56 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.08 ns** | **13.522 ns** | **0.741 ns** |  **54.52 ns** |  **55.92 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 209.02 ns | 31.664 ns | 1.736 ns | 207.26 ns | 210.73 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.58 ns |  8.941 ns | 0.490 ns |  60.02 ns |  60.87 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.58 ns |  4.230 ns | 0.232 ns |  34.34 ns |  34.80 ns | 0.0057 |      96 B |
