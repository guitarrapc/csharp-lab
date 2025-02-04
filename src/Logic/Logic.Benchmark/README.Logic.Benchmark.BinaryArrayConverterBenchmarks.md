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
| **ToBinaryArrayInt**             | **1**      |  **17.20 ns** |  **3.750 ns** | **0.206 ns** |  **17.06 ns** |  **17.43 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.94 ns | 24.586 ns | 1.348 ns |  68.38 ns |  70.75 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  18.87 ns |  1.717 ns | 0.094 ns |  18.80 ns |  18.98 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.52 ns |  1.453 ns | 0.080 ns |  10.47 ns |  10.61 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.77 ns** | **11.207 ns** | **0.614 ns** |  **54.37 ns** |  **55.48 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.22 ns | 20.780 ns | 1.139 ns | 205.32 ns | 207.50 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  57.66 ns | 25.455 ns | 1.395 ns |  56.82 ns |  59.27 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.20 ns |  6.890 ns | 0.378 ns |  34.89 ns |  35.62 ns | 0.0057 |      96 B |
