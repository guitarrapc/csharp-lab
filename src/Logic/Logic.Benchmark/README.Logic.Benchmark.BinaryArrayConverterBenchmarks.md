```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.98 ns** |  **4.814 ns** | **0.264 ns** |  **17.67 ns** |  **18.16 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  70.26 ns | 18.911 ns | 1.037 ns |  69.40 ns |  71.41 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.25 ns |  5.672 ns | 0.311 ns |  18.93 ns |  19.56 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.62 ns |  3.626 ns | 0.199 ns |  10.43 ns |  10.83 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.15 ns** |  **3.951 ns** | **0.217 ns** |  **55.96 ns** |  **56.39 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 209.58 ns | 14.796 ns | 0.811 ns | 209.07 ns | 210.51 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.39 ns |  4.228 ns | 0.232 ns |  60.15 ns |  60.61 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.03 ns |  7.488 ns | 0.410 ns |  34.62 ns |  35.44 ns | 0.0057 |      96 B |
