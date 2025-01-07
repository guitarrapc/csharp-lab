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
| **ToBinaryArrayInt**             | **1**      |  **17.21 ns** | **15.095 ns** | **0.827 ns** |  **16.41 ns** |  **18.06 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  70.34 ns | 78.198 ns | 4.286 ns |  67.72 ns |  75.29 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.35 ns |  2.739 ns | 0.150 ns |  19.18 ns |  19.48 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.52 ns |  1.882 ns | 0.103 ns |  10.43 ns |  10.63 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.88 ns** |  **3.457 ns** | **0.189 ns** |  **54.68 ns** |  **55.06 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 205.91 ns | 31.855 ns | 1.746 ns | 204.88 ns | 207.92 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.48 ns |  8.265 ns | 0.453 ns |  59.96 ns |  60.79 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.65 ns |  9.858 ns | 0.540 ns |  34.07 ns |  35.15 ns | 0.0057 |      96 B |
