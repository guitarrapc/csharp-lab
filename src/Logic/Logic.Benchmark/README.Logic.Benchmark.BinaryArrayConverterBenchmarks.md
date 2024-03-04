```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **16.88 ns** |   **2.189 ns** | **0.120 ns** |  **16.76 ns** |  **17.00 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  61.40 ns |  11.956 ns | 0.655 ns |  60.88 ns |  62.13 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  18.91 ns |   3.472 ns | 0.190 ns |  18.78 ns |  19.13 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.24 ns |   4.670 ns | 0.256 ns |  10.08 ns |  10.53 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **181.54 ns** | **133.823 ns** | **7.335 ns** | **175.28 ns** | **189.61 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 641.89 ns | 142.316 ns | 7.801 ns | 633.35 ns | 648.65 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 210.75 ns |  91.328 ns | 5.006 ns | 206.35 ns | 216.20 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 141.40 ns |   3.281 ns | 0.180 ns | 141.23 ns | 141.59 ns | 0.0038 |     320 B |
