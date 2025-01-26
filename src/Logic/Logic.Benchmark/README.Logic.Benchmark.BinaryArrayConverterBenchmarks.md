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
| **ToBinaryArrayInt**             | **1**      |  **16.94 ns** |  **4.776 ns** | **0.262 ns** |  **16.73 ns** |  **17.24 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.14 ns |  9.544 ns | 0.523 ns |  66.71 ns |  67.72 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.26 ns |  3.124 ns | 0.171 ns |  19.13 ns |  19.46 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.55 ns |  2.242 ns | 0.123 ns |  10.43 ns |  10.67 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.82 ns** | **14.076 ns** | **0.772 ns** |  **54.17 ns** |  **55.67 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 207.96 ns | 21.516 ns | 1.179 ns | 206.69 ns | 209.02 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.00 ns |  5.755 ns | 0.315 ns |  60.72 ns |  61.34 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.69 ns |  4.157 ns | 0.228 ns |  35.50 ns |  35.94 ns | 0.0057 |      96 B |
