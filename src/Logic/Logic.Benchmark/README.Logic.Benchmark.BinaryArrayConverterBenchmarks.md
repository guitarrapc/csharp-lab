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
| **ToBinaryArrayInt**             | **1**      |  **18.93 ns** |  **4.591 ns** | **0.252 ns** |  **18.66 ns** |  **19.15 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.80 ns | 15.416 ns | 0.845 ns |  66.98 ns |  68.67 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.30 ns |  1.440 ns | 0.079 ns |  20.25 ns |  20.39 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.90 ns |  0.974 ns | 0.053 ns |  10.84 ns |  10.94 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **52.84 ns** | **11.406 ns** | **0.625 ns** |  **52.35 ns** |  **53.54 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 197.96 ns | 11.400 ns | 0.625 ns | 197.35 ns | 198.59 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.39 ns |  3.680 ns | 0.202 ns |  63.18 ns |  63.58 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.36 ns |  2.940 ns | 0.161 ns |  36.19 ns |  36.52 ns | 0.0011 |      96 B |
