```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.07 ns** |   **6.092 ns** | **0.334 ns** |  **17.73 ns** |  **18.40 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.46 ns |   2.342 ns | 0.128 ns |  66.33 ns |  66.59 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.52 ns |   8.530 ns | 0.468 ns |  20.04 ns |  20.97 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.91 ns |   3.482 ns | 0.191 ns |  10.80 ns |  11.13 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **187.65 ns** | **125.023 ns** | **6.853 ns** | **182.18 ns** | **195.34 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 718.32 ns |  44.876 ns | 2.460 ns | 716.59 ns | 721.13 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 218.94 ns | 105.042 ns | 5.758 ns | 212.81 ns | 224.24 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 149.44 ns |  51.217 ns | 2.807 ns | 147.12 ns | 152.56 ns | 0.0038 |     320 B |
