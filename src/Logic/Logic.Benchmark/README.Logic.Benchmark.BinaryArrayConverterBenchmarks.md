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
| **ToBinaryArrayInt**             | **1**      |  **17.13 ns** |  **4.175 ns** | **0.229 ns** |  **16.95 ns** |  **17.39 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.70 ns |  6.720 ns | 0.368 ns |  68.27 ns |  68.93 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.64 ns |  6.303 ns | 0.346 ns |  19.25 ns |  19.90 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.45 ns |  2.630 ns | 0.144 ns |  10.33 ns |  10.61 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **53.39 ns** |  **8.676 ns** | **0.476 ns** |  **52.93 ns** |  **53.88 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 207.54 ns |  7.685 ns | 0.421 ns | 207.17 ns | 207.99 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  59.19 ns | 14.194 ns | 0.778 ns |  58.56 ns |  60.06 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.18 ns |  2.280 ns | 0.125 ns |  34.04 ns |  34.28 ns | 0.0057 |      96 B |
