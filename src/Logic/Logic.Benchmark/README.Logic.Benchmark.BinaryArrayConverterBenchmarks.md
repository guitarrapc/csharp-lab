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
| **ToBinaryArrayInt**             | **1**      |  **17.42 ns** |  **5.198 ns** | **0.285 ns** |  **17.09 ns** |  **17.62 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.02 ns |  9.048 ns | 0.496 ns |  67.56 ns |  68.54 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.35 ns |  7.188 ns | 0.394 ns |  18.98 ns |  19.76 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.17 ns |  1.806 ns | 0.099 ns |  10.10 ns |  10.28 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **52.45 ns** |  **0.688 ns** | **0.038 ns** |  **52.41 ns** |  **52.49 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.52 ns | 68.734 ns | 3.768 ns | 203.52 ns | 210.75 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.17 ns | 19.201 ns | 1.052 ns |  61.00 ns |  63.03 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.74 ns | 15.798 ns | 0.866 ns |  33.98 ns |  35.68 ns | 0.0057 |      96 B |
